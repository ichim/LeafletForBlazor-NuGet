namespace Leaflet.Geodesic.Plugins
{
    partial class LeafletGeodesic
    {
        public class Coordinates
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public Coordinates(double latitude, double longitude)
            {
                Latitude = latitude;
                Longitude = longitude;
            }
        }
    }
}
