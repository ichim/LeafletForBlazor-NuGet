# Nearby Points Tracking 
![NearbyPointsTracking](https://github.com/ichim/LeafletForBlazor-NuGet/assets/8348463/9449f6f7-d980-40b5-97aa-55930376b739)
## About example
In this example, a simulator for moving points on the map is used. 4 distinct points will move on the map (each point represents something distinct - type property).
## Configuring the analysis of Nearby Points Tracking
The configuration is done on the Analysis class hosted by Points. All or part of the points can participate in the Nearby Points Tracking type analysis.
If we choose to participate only a part of the points:
         var analysis = realTimeMap.Geometric.Points.Analysis(item => 
                                                             item.type == "intervention crew" || 
                                                             item.type == "suspicious vehicle");
## Points map appearance
The points will be displayed with distinct symbols depending on the type property. There will be two distinct situations:
 - 1 the points are not close (distance > 30 m);
 - 2 the points are close (distance < 30 m);
### Points are not close
When the points are not nearby, they will be displayed with separate symbols according to the **type** property.
The defaultAppearace method is used to display points when they are not nearby:

     public void defaultAppearace()
     {
         //the default appearance of the points depending on the type, ex:
         // - police crew -> fillColor "#d8bfd8"
         if (realTimeMap != null)
         {
             realTimeMap.Geometric.Points.Appearance(item => item.type == "intervention crew").pattern = new RealTimeMap.PointSymbol()
                 {
                     color = "#800080",
                     fillColor = "#9932cc",
                     fillOpacity = 0.5,
                     weight = 2,
                     opacity = 1,
                     radius = 10
                 };
             realTimeMap.Geometric.Points.Appearance(item => item.type == "suspicious vehicle").pattern = new RealTimeMap.PointSymbol()
                 {
                     color = "blue",
                     fillColor = "#4682b4",
                     fillOpacity = 0.5,
                     weight = 2,
                     opacity = 1,
                     radius = 10
                 };
             realTimeMap.Geometric.Points.Appearance(item => item.type == "ambulance").pattern = new RealTimeMap.PointSymbol()
                 {
                     color = "#648c11",
                     fillColor = "#bfff00",
                     fillOpacity = 0.5,
                     weight = 2,
                     opacity = 1,
                     radius = 10
                 };
             realTimeMap.Geometric.Points.Appearance(item => item.type == "police crew").pattern = new RealTimeMap.PointSymbol()
                 {
                     color = "#000080",
                     fillColor = "#d8bfd8",
                     fillOpacity = 0.5,
                     weight = 2,
                     opacity = 1,
                     radius = 10
                 };
         }
     }
### The points are nearby
