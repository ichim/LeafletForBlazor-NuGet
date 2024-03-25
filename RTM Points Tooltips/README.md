# Using RealTimeMap tooltips
This project is an example of how you can display the attributes of the points (StreamPoint) in the map.

![image](https://github.com/ichim/LeafletForBlazor-NuGet/assets/8348463/90730278-eec0-4b82-921f-08c271291541)

## Input data
In this example, each point was associated with a set of data with the following structure:

    public class Attributes
    {
        public string? registrationNumber { get; set; }
        public string? vehicleType { get; set; }
        public string? description { get; set; }
    }
    
### Points Attributes

A point from the collection of points, will have a data set similar to:

    new RealTimeMap.StreamPoint()
     {
          guid = Guid.Parse("48466d7f-0689-4b8e-a2ee-28e5cb27f86f"),
          latitude=43.971876662076546, 
          longitude = 25.328737648076636,
          type = "asked for help",
          value = new Attributes() { registrationNumber = "B 24 AAD", vehicleType = "5 seats", description="black color, two occupants in the car" }
     }

This is a **StreamPoint** whose structure is predefined and which has been extended with a new structure using the value property:

        value = new Attributes() { 
            registrationNumber = "B 24 AAD", 
            vehicleType = "5 seats", 
            description="black color, two occupants in the car" 
        }

## Configuring tooltips

The configuration of the tooltips was done on the onAfterMapLoaded event of the RealTimeMap control. Two categories of tooltips have been configured:
- a category that only displays **registrationNumber** and **vehicleType**
- and a second category that displays **registrationNumber**, **vehicleType** and **description**

Code example:

    public async Task onAfterMapLoaded(RealTimeMap.MapEventArgs args)
    {
        var realTimeMap = args.sender as RealTimeMap;
        realTimeMap.Geometric.Points.Appearance(item => item.type == "asked for help").pattern = new RealTimeMap.PointTooltip()
            {
                content = "<b>Registration number: </b>${value.registrationNumber}</br><b>Vehicle type: </b>${value.vehicleType}</br>${value.description}"
            };
        realTimeMap.Geometric.Points.Appearance(item => item.type != "asked for help").pattern = new RealTimeMap.PointTooltip()
            {
                content = "<b>${type}</b><br><b>Vehicle type: </b>${value.vehicleType}"
            };
    }


