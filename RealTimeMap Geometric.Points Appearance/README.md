# Appearance render

Configuring the "appearance render" of the StreamPoint collection from the map.
Configuring StreamPoint Appearance:

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

The project has a list of StreamPoint items.

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
