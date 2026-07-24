using LeafletForBlazor;

namespace streamPoints.data
{
    public class Attributes
    {
        public string? registrationNumber { get; set; }
        public string? vehicleType { get; set; }
        public string? description { get; set; }

    }
    public class InputData
    {
        public List<RealTimeMap.StreamPoint> input = new List<RealTimeMap.StreamPoint>() {
          new RealTimeMap.StreamPoint()
         {
                guid = Guid.Parse("28466d7f-0689-4b8e-a2ee-28e5cb27f86f"),
                latitude=43.972801938829356,
                longitude = 25.326177627532893,
                type = "intervention crew",
                value = new Attributes() { registrationNumber = "B 24 AAB", vehicleType = "bus" }
         }
        };
    }

}