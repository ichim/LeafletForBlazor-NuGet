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
# Upload data on map

Upload data in the map:

     await args.sender.Geometric.Points.upload(new InputData().input);

# Appearance based on custom attributes


        args.sender.Geometric.Points.Appearance(item => (item.value as Attributes)!.vehicleType == "bus").pattern = new RealTimeMap.PointSymbol()
            {  //item.value is Attributes object
                fillColor = "red",
                radius = 8
            };

Where Attributes represents the StreamPoint custom attribute class.

The complete example:

Blazor Page:

     <RealTimeMap height="calc(100vh - 6rem)" width="calc(100vw - 18rem)" OnAfterMapLoaded="onAfterMapLoaded"></RealTimeMap>

Code block:

     @code {
         public async Task onAfterMapLoaded(RealTimeMap.MapEventArgs args)
         {
             args.sender.Geometric.Points.Appearance(item => (item.value as Attributes)!.vehicleType == "bus").pattern = new RealTimeMap.PointSymbol()
                 {  //item.value is Attributes object
                     fillColor = "red",
                     radius = 8
                 };
             await args.sender.Geometric.Points.upload(new InputData().input);
         }
     }



