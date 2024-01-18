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

In this example, it was chosen that all points participate in the Nearby Points Tracking analysis:

         var analysis = realTimeMap.Geometric.Points.Analysis(item => true);

Configuring the threshold that make event methods to fire:


            analysis.nearby = new RealTimeMap.NearbyAnalysis()
                {
                    threshold = 30,
                    unit = RealTimeMap.UnitOfMeasure.meters
                };

Adding the event methods of Nearby Points type analysis:

           analysis.OnNearbyThresholdFired += onNearbyThresholdTrigger;
           analysis.OnNearbyThresholdClosed += nearbyThresholdTriggerClosed;

The method that is triggered when the points are close:

          public void onNearbyThresholdTrigger(object sender, RealTimeMap.NearbyThresholdArgs args)
          {
         
          }

The method that is triggered when the proximity condition is no longer satisfied:

         public void nearbyThresholdTriggerClosed(object sender)
         {
         
         }

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

The defaultAppearance() method will also be called on the triggered method when the proximity condition is no longer satisfied:

    public void nearbyThresholdTriggerClosed(object sender)
    {
            defaultAppearace();             //we return to the default appearance
    }

### The points are nearby

**onNearbyThresholdTrigger** method will be used to highlight nearby points:

    public void onNearbyThresholdTrigger(object sender, RealTimeMap.NearbyThresholdArgs args)
    {
        //when the points are close, we will symbolize them distinctly (red and orange)
        if (args.tuples == null)
            return;
        foreach (var item in args.tuples)
        {
            if(item.tuple !=null)
            {
                var guid = item.tuple.Item1.guid;
                appointmentInformation = $"{item.tuple.Item1.value} / {item.tuple.Item2.value}";
                distanceBetween = $"{Math.Round(item.distance, 0)} meters";
                StateHasChanged();
                if(realTimeMap !=null)
                {
                    realTimeMap.Geometric.Points.Appearance(item => item.guid == guid).pattern = new RealTimeMap.PointSymbol()
                        {
                            color = "red",
                            opacity = 0.8,
                            fillColor = "orange",
                            fillOpacity = 0.5,
                            weight = 2,
                            radius = 10
                        };
                }
            }
        }
        pas++;
    }


