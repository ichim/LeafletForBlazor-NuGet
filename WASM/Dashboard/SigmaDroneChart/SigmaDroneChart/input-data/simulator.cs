using System;
using System.Timers;

namespace DroneSimulator
{
    public class Position
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Position(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public Position Clone()
        {
            
            return new Position(Latitude, Longitude);
        }
    }

    public class Bounds
    {
        public double LatitudeMin { get; set; }
        public double LongitudeMin { get; set; }
        public double LatitudeMax { get; set; }
        public double LongitudeMax { get; set; }

        public Bounds(double latMin, double lonMin, double latMax, double lonMax)
        {
            LatitudeMin = latMin;
            LongitudeMin = lonMin;
            LatitudeMax = latMax;
            LongitudeMax = lonMax;
        }
    }

    public class DroneState: ICloneable
    {
        public Position Position { get; set; }
        public double Speed { get; set; } // m/s
        public double Fuel { get; set; } // procent
        public double Direction { get; set; } // grade
        public double Altitude { get; set; } // metri
        public bool IsActive { get; set; }

        public DroneState Clone()
        {
            return new DroneState
            {
                Position = this.Position.Clone(),
                Speed = this.Speed,
                Fuel = this.Fuel,
                Direction = this.Direction,
                Altitude = this.Altitude,
                IsActive = this.IsActive
            };
        }

        object ICloneable.Clone()
        {
            
            return Clone();
        }
    }

    public delegate void DroneUpdateEventHandler(object sender, DroneUpdateEventArgs e);

    public class DroneUpdateEventArgs : EventArgs
    {
        public DroneState State { get; }

        public DroneUpdateEventArgs(DroneState state)
        {
            State = state;
        }
    }

    public class DroneSimulator : IDisposable
    {
        private readonly Bounds _bounds;
        private readonly double _timeStep; // în secunde
        private System.Timers.Timer _timer;
        private DroneState _currentState;
        private Random _random;
        private DateTime _lastUpdate;

        public event DroneUpdateEventHandler OnDroneUpdate;

        public DroneSimulator(Bounds bounds,double latitude, double longitude, double timeStep)
        {
            _bounds = bounds;
            _timeStep = timeStep;
            _random = new Random();

            _currentState = new DroneState
            {
                Position = new Position(
                   latitude,
                   longitude
                ),
                Speed = 0,
                Fuel = 100,
                Direction = 0,
                Altitude = 50,
                IsActive = true
            };

            _lastUpdate = DateTime.Now;

            _timer = new System.Timers.Timer(timeStep * 1000);
            _timer.Elapsed += TimerElapsed;
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            UpdateDroneState();
        }

        private void UpdateDroneState()
        {
            if (!_currentState.IsActive || _currentState.Fuel <= 0)
            {
                _timer.Stop();
                return;
            }

            var now = DateTime.Now;
            var elapsedTime = (now - _lastUpdate).TotalSeconds;
            _lastUpdate = now;

            _currentState.Direction = (_currentState.Direction + (_random.NextDouble() * 60 - 30)) % 360;

            _currentState.Speed = 20 + _random.NextDouble() * 100;

            _currentState.Position = CalculateNewPosition(
                _currentState.Position,
                _currentState.Speed,
                _currentState.Direction,
                elapsedTime
            );
            
            double fuelConsumption = (_currentState.Speed / 20) * 0.1; // 0-0.1% per update
            _currentState.Fuel = Math.Max(0, _currentState.Fuel - fuelConsumption);

            if (_currentState.Fuel <= 0)
            {
                _currentState.Speed = 0;
                _currentState.IsActive = false;
                _timer.Stop();
            }

            _currentState.Speed = Math.Round(_currentState.Speed, 2);
            _currentState.Fuel = Math.Round(_currentState.Fuel, 2);
            _currentState.Direction = Math.Round(_currentState.Direction, 1);
            _currentState.Altitude = Math.Round(_currentState.Direction, 0);
            OnDroneUpdate?.Invoke(this, new DroneUpdateEventArgs(_currentState.Clone()));
        }

        private Position CalculateNewPosition(Position currentPosition, double speed, double direction, double elapsedTime)
        {
            double directionRad = direction * Math.PI / 180;


            double latDistance = (speed * elapsedTime) / 111000;
            double longDistance = (speed * elapsedTime) / (111000 * Math.Cos(currentPosition.Latitude * Math.PI / 180));

            double deltaLat = latDistance * Math.Cos(directionRad);
            double deltaLong = longDistance * Math.Sin(directionRad);

            double newLat = currentPosition.Latitude + deltaLat;
            double newLong = currentPosition.Longitude + deltaLong;

            newLat = Math.Max(_bounds.LatitudeMin, Math.Min(_bounds.LatitudeMax, newLat));
            newLong = Math.Max(_bounds.LongitudeMin, Math.Min(_bounds.LongitudeMax, newLong));

            return new Position(newLat, newLong);
        }

        public DroneState GetCurrentState()
        {
            return _currentState.Clone();
        }

        public void SetDirection(double newDirection)
        {
            if (_currentState.IsActive)
            {
                _currentState.Direction = newDirection % 360;
            }
        }

        public void SetSpeed(double newSpeed)
        {
            if (_currentState.IsActive)
            {
                _currentState.Speed = Math.Max(0, Math.Min(30, newSpeed)); // limită 30 m/s
            }
        }

        public void SetAltitude(double newAltitude)
        {
            if (_currentState.IsActive)
            {
                _currentState.Altitude = Math.Max(10, Math.Min(200, newAltitude)); // limită 10-200m
            }
        }

        public void Refuel(double amount)
        {
            _currentState.Fuel = Math.Min(100, _currentState.Fuel + amount);
            if (_currentState.Fuel > 0 && !_currentState.IsActive)
            {
                _currentState.IsActive = true;
                _timer.Start();
            }
        }

        public void Stop()
        {
            _currentState.IsActive = false;
            _currentState.Speed = 0;
            _timer.Stop();
        }

        public void Start()
        {
            if (_currentState.Fuel > 0)
            {
                _currentState.IsActive = true;
                _lastUpdate = DateTime.Now;
                _timer.Start();
            }
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}