# DisplayChartFromObject class

The DisplayChartFromObject class provides the ability to display charts directly on the map (RealTimeMap).

## PieChartPoint

<img width="2013" height="1435" alt="image" src="https://github.com/user-attachments/assets/adf0f44a-ef50-428e-aebf-e952291006d1" />

This class provides the addPieChartPoint() method with which you can add Pie Chart points to the map.

     var pieChartPoint = new RealTimeMap.PieChartPoint()
      {
          location = new RealTimeMap.Location()
          {
              latitude = 51.215639249505294, 
              longitude = 4.4257336791909,
          },
          values = (new List<double>() { 20, 10, 15, 55}).ToArray(),
          colors = (new List<string>() { "#ADFF2F", "#00FFFF", "#FFA500", "azure" }).ToArray(),
          labels = (new List<string>() { "parks", "streets", "housing", "museums" }).ToArray(),
          expandedIndex = 2,
          fontSize = 8,
          dimension = 54,
          visibilityZoomLevel = new RealTimeMap.VisibilityZoomLevel()
          {
              minZoomLevel = 8,
              maxZoomLevel = 14
          }
      };
      args.sender.Geometric.DisplayChartFromObject.addChartPoint(pieChartPoint);

      
Clear all chart items from RealTimeMap:

    await realTimeMap.Geometric.DisplayChartFromObject.clearAll();

[PieChartPoint example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20ChartPoint/PieChartPoint)

## DonutChartPoint

<img width="1341" height="885" alt="image" src="https://github.com/user-attachments/assets/f84155fe-92a4-4fd2-8e1b-81de5d442a25" />

This class provides the addDonutChartPoint() method with which you can add Donut Chart points to the map.

     var chartPoint = new RealTimeMap.DonutChartPoint()
      {
          location = new RealTimeMap.Location()
          {
              latitude = 51.215639249505294, 
              longitude = 4.4257336791909,
          },
          values = (new List<double>() { 20, 10, 15, 55}).ToArray(),
          colors = (new List<string>() { "#ADFF2F", "#00FFFF", "#FFA500", "azure" }).ToArray(),
          labels = (new List<string>() { "parks", "streets", "housing", "museums" }).ToArray(),
          expandedIndex = 2,
          fontSize = 8,
          dimension = 54,
          heightCircularCrown = 20,//thickness of donut ring - default 28
          visibilityZoomLevel = new RealTimeMap.VisibilityZoomLevel()
          {
              minZoomLevel = 8,
              maxZoomLevel = 14
          }
      };
      args.sender.Geometric.DisplayChartFromObject.addChartPoint(chartPoint);
      
Clear all chart items from RealTimeMap:

    await realTimeMap.Geometric.DisplayChartFromObject.clearAll();

[DonutChartPoint example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20ChartPoint/DonutChartPoint)

## GaugeChartPoint

<img width="1339" height="1293" alt="image" src="https://github.com/user-attachments/assets/93fa6ac5-5b01-4234-8760-df6b43dbbcda" />

This class provides the addGaugeChartPoint() method with which you can add Gauge Chart points to the map.

    var gaugeChartPoint = new RealTimeMap.GaugeChartPoint()
    {
        location = new RealTimeMap.Location()
        {
            latitude = 51.02094731770253,
            longitude = 4.523290395225346,
        },
         valueStart = 0,
         valueStop = 100,
         value = 82,
         colorStart = "yellow",
         colorStop = "#8F2A18",
         heightCircularCrown  = 18,
         fontColorStart = "black",
         fontColorMiddle = "white",
         fontColorStop = "yellow",
         fontSize  = 6,
         dimension = 40,       
         visibilityZoomLevel = new RealTimeMap.VisibilityZoomLevel(){
            minZoomLevel = 6,
            maxZoomLevel = 14
        }
    };
    await args.sender.Geometric.DisplayChartFromObject.addChartPoint(gaugeChartPoint);

  
Clear all chart items from RealTimeMap:

    await realTimeMap.Geometric.DisplayChartFromObject.clearAll();

[GaugeChartPoint example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20ChartPoint/GaugeChartPoint)

