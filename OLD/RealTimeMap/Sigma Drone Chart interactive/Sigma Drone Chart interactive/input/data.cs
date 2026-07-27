using LeafletForBlazor;

namespace Input.Data
{
    public class data
    {

        public List<RealTimeMap.SigmaDronePoint> items = new List<RealTimeMap.SigmaDronePoint>()
        {
            new RealTimeMap.SigmaDronePoint()
            {
                location = new RealTimeMap.Location()
                {
                    latitude = 54.349746877082964, 
                    longitude = 18.74062644099916,
                },
                dimension = 62,
                fontSize = 6,
                heightCrown = 12,
                //moreThan180DegreesWith = 60,
                visibilityZoomLevel = new RealTimeMap.VisibilityZoomLevel()
                {
                    minZoomLevel = 6,
                    maxZoomLevel = 14
                },
                interactive = new RealTimeMap.InteractiveChart()
                {
                   // eventsEnabled = true,
                    opacityAfterLeaving = 0.6,
                    proportionOfdimensionAfterLeaving = 0.6,
                },
                crownIndicators = new List<RealTimeMap.SigmaDroneObject>()
            {
                new RealTimeMap.SigmaDroneCrownPercent()
                {
                    label = "battery",
                    valueStart = 0,
                    valueStop = 4,
                    value = 2.4,
                    percentageOfTheEntireCrown = 20,
                    backgroundColor = "gray",
                    fillColor = "yellow",
                    haloText = true,
                },
                   new RealTimeMap.SigmaDroneCrownScale()
                {
                    label = "x 10 km/h",
                    valueStart = 0,
                    valueStop = 18,
                    value = 6,
                    percentageOfTheEntireCrown = 50,
                    backgroundColor = "#f8f8ff"
                },
                new RealTimeMap.SigmaDroneCrownDiscrete()
                {
                    label  = "fuel",
                    colors = new List<string>() { "green", "yellow", "red" }.ToArray(),
                    percentageValues = new List<int>() { 33, 33, 33 }.ToArray(),
                    index=1,
                    labels = new List<string>() { "full", "half", "low" }.ToArray(),
                    percentageOfTheEntireCrown = 30,
                    backgroundColor = "lightgray"
                },


            },
            wifiIndicator = new RealTimeMap.WiFiIndicator()
            {
                    level = 1
            },
            altitudeIndicator = new RealTimeMap.AltitudeIndicator()
            {
                    altitude = 820,
                    maximumAltitude = 1200,

            }
            },
              new RealTimeMap.SigmaDronePoint()
            {
                location = new RealTimeMap.Location()
                {
                    latitude = 54.32072221373645, 
                    longitude = 18.77120075093263,
                },
                dimension = 62,
                fontSize = 6,
                heightCrown = 12,
                //moreThan180DegreesWith = 60,
                visibilityZoomLevel = new RealTimeMap.VisibilityZoomLevel()
                {
                    minZoomLevel = 6,
                    maxZoomLevel = 14
                },
                interactive = new RealTimeMap.InteractiveChart()
                {
                   // eventsEnabled = true,
                    opacityAfterLeaving = 0.6,
                    proportionOfdimensionAfterLeaving = 0.6,
                },
                crownIndicators = new List<RealTimeMap.SigmaDroneObject>()
            {
              
                   new RealTimeMap.SigmaDroneCrownScale()
                {
                    label = "x 10 km/h",
                    valueStart = 0,
                    valueStop = 20,
                    value = 6,
                    percentageOfTheEntireCrown = 30,
                    backgroundColor = "#f8f8ff"
                },
                new RealTimeMap.SigmaDroneCrownDiscrete()
                {
                    label  = "fuel",
                    colors = new List<string>() { "green", "yellow","orange", "red" }.ToArray(),
                    percentageValues = new List<int>() { 25, 25, 25, 25 }.ToArray(),
                    index=0,
                    labels = new List<string>() { "Full", "Lrange", "Half", "Low" }.ToArray(),
                    percentageOfTheEntireCrown = 70,
                    backgroundColor = "lightgray"
                },


            },
            wifiIndicator = new RealTimeMap.WiFiIndicator()
            {
                    level = 0
            },
            altitudeIndicator = new RealTimeMap.AltitudeIndicator()
            {
                    altitude = 620,
                    maximumAltitude = 1200,

            }
            },
                new RealTimeMap.SigmaDronePoint()
            {
                location = new RealTimeMap.Location()
                {
                    latitude =54.312444166201125, 
                    longitude =18.6621166282996,
                },
                dimension = 62,
                fontSize = 6,
                heightCrown = 12,
                //moreThan180DegreesWith = 60,
                visibilityZoomLevel = new RealTimeMap.VisibilityZoomLevel()
                {
                    minZoomLevel = 6,
                    maxZoomLevel = 14
                },
                interactive = new RealTimeMap.InteractiveChart()
                {
                   // eventsEnabled = true,
                    opacityAfterLeaving = 0.6,
                    proportionOfdimensionAfterLeaving = 0.6,
                },
                crownIndicators = new List<RealTimeMap.SigmaDroneObject>()
            {
                new RealTimeMap.SigmaDroneCrownPercent()
                {
                    label = "fuel",
                    valueStart = 0,
                    valueStop = 4,
                    value = 3,
                    percentageOfTheEntireCrown = 20,
                    backgroundColor = "lightgray",
                    fillColor = "indigo",
                    haloText = true
                },
                   new RealTimeMap.SigmaDroneCrownScale()
                {
                    label = "x 10 km/h",
                    valueStart = 0,
                    valueStop = 12,
                    value = 6,
                    percentageOfTheEntireCrown = 30,
                    backgroundColor = "#f8f8ff"
                },
                new RealTimeMap.SigmaDroneCrownDiscrete()
                {
                    label  = "presure",
                    colors = new List<string>() { "green", "yellow", "red" }.ToArray(),
                    percentageValues = new List<int>() { 33, 33, 33 }.ToArray(),
                    index=1,
                    labels = new List<string>() { "optim", "mean", "low" }.ToArray(),
                    percentageOfTheEntireCrown = 50,
                    backgroundColor = "lightgray"
                },


            },
            wifiIndicator = new RealTimeMap.WiFiIndicator()
            {
                    level = 2
            },
            altitudeIndicator = new RealTimeMap.AltitudeIndicator()
            {
                    altitude = 260,
                    maximumAltitude = 1200,

            },
            batteryIndicator = new RealTimeMap.BatteryIndicator()
            {
                    level = 2,
                    rotate =0
            }
            },
                        new RealTimeMap.SigmaDronePoint()
            {
                location = new RealTimeMap.Location()
                {
                    latitude =54.39416300358305, 
                    longitude =18.781932557962982,
                },
                dimension = 62,
                fontSize = 6,
                heightCrown = 12,
                moreThan180DegreesWith = 20,
                visibilityZoomLevel = new RealTimeMap.VisibilityZoomLevel()
                {
                    minZoomLevel = 6,
                    maxZoomLevel = 14
                },
                interactive = new RealTimeMap.InteractiveChart()
                {
                   eventsEnabled = true,
                    opacityAfterLeaving = 0.6,
                    proportionOfdimensionAfterLeaving = 0.6,
                },
                crownIndicators = new List<RealTimeMap.SigmaDroneObject>()
            {
              

          
                new RealTimeMap.SigmaDroneCrownScale()
                {
                    label = "x 10 km/h",
                    valueStart = 0,
                    valueStop = 12,
                    value = 9,
                    percentageOfTheEntireCrown = 100,
                    backgroundColor = "#f8f8ff",
              
                },

            },
            wifiIndicator = new RealTimeMap.WiFiIndicator()
            {
                    level = 0
            },
                 batteryIndicator = new RealTimeMap.BatteryIndicator()
            {
                    level = 9,
                    rotate =-90
            }
            //altitudeIndicator = new RealTimeMap.AltitudeIndicator()
            //{
            //        altitude = 28,
            //        maximumAltitude = 1200,

            //}
            },
      new RealTimeMap.SigmaDronePoint()
            {
                location = new RealTimeMap.Location()
                {
                    latitude = 54.39612410540988, 
                    longitude = 18.503742001389753,
                },
                dimension = 62,
                fontSize = 6,
                heightCrown = 12,
                //moreThan180DegreesWith = 60,
                visibilityZoomLevel = new RealTimeMap.VisibilityZoomLevel()
                {
                    minZoomLevel = 6,
                    maxZoomLevel = 14
                },
                interactive = new RealTimeMap.InteractiveChart()
                {
                   // eventsEnabled = true,
                    opacityAfterLeaving = 0.6,
                    proportionOfdimensionAfterLeaving = 0.6,
                },
                crownIndicators = new List<RealTimeMap.SigmaDroneObject>()
            {
                  new RealTimeMap.SigmaDroneCrownDiscrete()
                {
                    label  = "battery",
                    colors = new List<string>() { "red", "orange", "yellow", "green" }.ToArray(),
                    percentageValues = new List<int>() { 33, 33, 33, 33 }.ToArray(),
                    index=1,
                    labels = new List<string>() { "critical", "low", "long range", "full" }.ToArray(),
                    percentageOfTheEntireCrown = 80,
                    backgroundColor = "lightgray",
                    haloText = true,
                
                },
                   new RealTimeMap.SigmaDroneCrownScale()
                {
                    label = "x 10 km/h",
                    valueStart = 0,
                    valueStop = 12,
                    value = 8,
                    percentageOfTheEntireCrown = 20,
                    backgroundColor = "#f8f8ff"
                },
           
              

            },
            wifiIndicator = new RealTimeMap.WiFiIndicator()
            {
                    level = 2
            },
            altitudeIndicator = new RealTimeMap.AltitudeIndicator()
            {
                    altitude = 260,
                    maximumAltitude = 1200,

            }
            },
          new RealTimeMap.SigmaDronePoint()
            {
                location = new RealTimeMap.Location()
                {
                    latitude = 54.35466498261377, 
                    longitude =18.510558072735957,
                },
                dimension = 62,
                fontSize = 6,
                heightCrown = 12,
                //moreThan180DegreesWith = 60,
          
                visibilityZoomLevel = new RealTimeMap.VisibilityZoomLevel()
                {
                    minZoomLevel = 6,
                    maxZoomLevel = 14
                },
                interactive = new RealTimeMap.InteractiveChart()
                {
                   // eventsEnabled = true,
                    opacityAfterLeaving = 0.6,
                    proportionOfdimensionAfterLeaving = 0.6,
                },
                crownIndicators = new List<RealTimeMap.SigmaDroneObject>()
            {
                  new RealTimeMap.SigmaDroneCrownDiscrete()
                {
                    label  = "battery",
                    colors = new List<string>() { "red", "orange", "yellow", "green" }.ToArray(),
                    percentageValues = new List<int>() { 33, 33, 33, 33 }.ToArray(),
                    index=1,
                    labels = new List<string>() { "critical", "low", "long range", "full" }.ToArray(),
                    percentageOfTheEntireCrown = 80,
                    backgroundColor = "lightgray",
                    haloText = true,
                },

                   new RealTimeMap.SigmaDroneCrownPercent()
                {
                    label = "fuel",
                    valueStart = 0,
                    valueStop = 10,
                    value = 3,
                    percentageOfTheEntireCrown = 20,
                    backgroundColor = "lime",
                    fillColor = "orange",
                    haloText = true
                },


            },
            wifiIndicator = new RealTimeMap.WiFiIndicator()
            {
                    level = -1
            },
            altitudeIndicator = new RealTimeMap.AltitudeIndicator()
            {
                    altitude = 260,
                    maximumAltitude = 1200,

            },
            batteryIndicator = new RealTimeMap.BatteryIndicator()
            {
                    level = 2
            }
            },
        };  
    }
}
