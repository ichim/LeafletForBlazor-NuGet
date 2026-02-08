# Sigma Drone Chart

You can create charts specific to drone monitoring. This type of chart is a combination of Gauge and vehicle-specific indicators.

     var sigmaDroneChartPoint = new RealTimeMap.SigmaDroneChartPoint()
        {
            location = new RealTimeMap.Location()
            {
                latitude = 50.81229753879652,
                longitude = 4.4274985764447905
            },
            dimension = 80,
            wifiIndicator = new RealTimeMap.WiFiIndicator()
            {
                    level = 1
            },
            altitudeIndicator = new RealTimeMap.AltitudeIndicator()
            {
                    altitude = 800,
                    maximumAltitude = 1200,
              
            },
            //... and more indicators
        };
        await args.sender.Geometric.DisplayChartFromObject.addChartPoint(sigmaDroneChartPoint);

You can expand the display of parameters in the crown area:

           new RealTimeMap.SigmaDronePoint()
             {
                 location = new RealTimeMap.Location()
                 {
                     latitude = 54.35466498261377, 
                     longitude =18.510558072735957,
                 },
                 dimension = 62,
                 fontSize = 6,
                 heightCrown = 12,
                 //moreThan180DegreesWith = 60,
                 visibilityZoomLevel = new RealTimeMap.VisibilityZoomLevel()
                 {
                     minZoomLevel = 6,
                     maxZoomLevel = 14
                 },
               
                 crownIndicators = new List<RealTimeMap.SigmaDroneObject>()
             {
                   new RealTimeMap.SigmaDroneCrownDiscrete()
                 {
                     label  = "battery",
                     colors = new List<string>() { "red", "orange", "yellow", "green" }.ToArray(),
                     percentageValues = new List<int>() { 33, 33, 33, 33 }.ToArray(),
                     index=1,
                     labels = new List<string>() { "critical", "low", "long range", "full" }.ToArray(),
                     percentageOfTheEntireCrown = 80,
                     backgroundColor = "lightgray",
                     haloText = true,
                 },
          
                    new RealTimeMap.SigmaDroneCrownPercent()
                 {
                     label = "fuel",
                     valueStart = 0,
                     valueStop = 10,
                     value = 3,
                     percentageOfTheEntireCrown = 20,
                     backgroundColor = "lime",
                     fillColor = "orange",
                     haloText = true
                 },
               }
          };
