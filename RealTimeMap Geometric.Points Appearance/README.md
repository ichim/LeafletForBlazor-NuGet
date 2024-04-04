# Appearance render

Configuring the "appearance render" of the **StreamPoint** collection from the map.

Configuring **StreamPoint** appearance example code:

        if (realTimeMap != null)
        {
                   realTimeMap.Geometric.Points.Appearance(item => item.type == "intervention crew").pattern = 
                          new RealTimeMap.PointSymbol() 
                                 { 
                                        radius = 8, 
                                        color = "#28ffff", 
                                        opacity = 0.68, 
                                        fillColor = "orange", 
                                        weight = 2, 
                                        fillOpacity = 0.68 
                                   };
       }

## Input data source

The sample project working with a list of **StreamPoint** items. Example code:

       public List<RealTimeMap.StreamPoint> pointsStart = new List<RealTimeMap.StreamPoint> {
          new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                type = "Intervention crew",
                value = "5 seats",
                latitude = 44.45028925827577,
                longitude =  26.10629452317551
            }
        };

## Appearance render

Configuring of a render class is done using the **Appearance()** method and an object defined by the **PointSymbol** class:


        realTimeMap.Geometric.Points.Appearance().pattern = new RealTimeMap.PointSymbol(){}

Example code:

        if (realTimeMap != null)
        {
                    realTimeMap.Geometric.Points.Appearance(item => !(item.type == "red" || item.type == "green" || item.type == "blue")).pattern = new RealTimeMap.PointSymbol() { radius = 8, color = "#28ffff", opacity = 0.68, fillColor = "orange", weight = 2, fillOpacity = 0.68 };
                    realTimeMap.Geometric.Points.Appearance(item => item.type == "red").pattern = new RealTimeMap.PointSymbol() { radius = 8, color = "rgb(200,100,0)", opacity = 0.68, fillColor = "red", weight = 4, fillOpacity = 0.68 };
                    realTimeMap.Geometric.Points.Appearance(item => item.type == "green").pattern = new RealTimeMap.PointSymbol() { radius = 10, color = "white", opacity = 0.68, fillColor = "green", weight = 2, fillOpacity = 0.68 };
                    realTimeMap.Geometric.Points.Appearance(item => item.type == "blue").pattern = new RealTimeMap.PointSymbol() { radius = 12, color = "#28ffff", opacity = 0.68, fillColor = "blue", weight = 2, fillOpacity = 0.68 };
        }
