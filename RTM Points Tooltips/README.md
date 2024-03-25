# Using RealTimeMap tooltips
This project is an example of how you can display the attributes of the points (StreamPoint) in the map.
## Input data
In this example, each point was associated with a set of data with the following structure:
    public class Attributes
    {
        public string? registrationNumber { get; set; }
        public string? vehicleType { get; set; }
        public string? description { get; set; }
    }
A point from the collection of points, will have a data set similar to:

    new RealTimeMap.StreamPoint()
     {
          guid = Guid.Parse("48466d7f-0689-4b8e-a2ee-28e5cb27f86f"),
          latitude=43.971876662076546, 
          longitude = 25.328737648076636,
          type = "asked for help",
          value = new Attributes() { registrationNumber = "B 24 AAD", vehicleType = "5 seats", description="black color, two occupants in the car" }
     },

### Points Attributes
