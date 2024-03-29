# Input data

Custom attributes can be defined on the value property of the StreamPoint object. For example, I chose an attribute structure like this:

     public class Attributes
     {
         public string? registrationNumber { get; set; }
         public string? vehicleType { get; set; }
         public string? description { get; set; }
     }

Populating the StreamPoint collection will be similar to:

       public List<RealTimeMap.StreamPoint> input = new List<RealTimeMap.StreamPoint>() {
           new RealTimeMap.StreamPoint()
            {
                   guid = Guid.Parse("28466d7f-0689-4b8e-a2ee-28e5cb27f86f"),
                   latitude=43.972801938829356,
                   longitude = 25.326177627532893,
                   type = "intervention crew",
                   value = new Attributes() { registrationNumber = "B 24 AAB", vehicleType = "bus" }
            },
        };

# Appearance based on custom attributes 
