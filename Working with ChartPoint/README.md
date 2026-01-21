# DisplayChartFromObject class

The DisplayChartFromObject class provides the ability to display charts directly on the map (RealTimeMap).
Since the graphs are displayed directly on the map, all ChartPoint classes will have in common Location (latitude, longitude)

           var location = new RealTimeMap.Location()
          {
              latitude = 51.215639249505294, 
              longitude = 4.4257336791909,
          }

Another common characteristic of all graphs is that they are drawn in a ViewBox with default dimensions 100,100 (width:100, height:100).

However, this ViewBox size cannot fit all scale levels, so each ChartPoint will have a common dimension parameter with which the chart can be resized.

ex.

     dimension  =  28

## PieChartPoint

<img width="2013" height="1435" alt="image" src="https://github.com/user-attachments/assets/adf0f44a-ef50-428e-aebf-e952291006d1" />

The addChartPoint method and PieChartPoint class can add a Pie Chart directly to the map.

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

The addChartPoint method and DonutChartPoint class can add a Donut Chart directly to the map.

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

The addChartPoint method and GaugeChartPoint class can add a Gauge Chart directly to the map.

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

# DiscreteGaugeChartPoint

The addChartPoint method and DiscreteGaugeChartPoint class can add a Gauge Category Style Chart directly to the map.

    var gaugePoints = new RealTimeMap.DiscreteGaugeChartPoint()
        {
            location = new RealTimeMap.Location()
            {
                latitude = 50.81229753879652,
                longitude = 4.4274985764447905
            },
        colors = ["green", "yellow", "red", "darkgray"],
        percentageValues = [19, 18, 18, 30],
        labels = ["low", "midle", "high", "unknown"],
        label = "traffic",
        fontSize = 10,
        index = 1,
        turnedAround = false,
        heightCircularCrown = 18,
        dimension = 40,
            visibilityZoomLevel = new RealTimeMap.VisibilityZoomLevel()
            {
                minZoomLevel = 6,
                maxZoomLevel = 14
            }
        });

# QuarterGaugeChartPoint

The addChartPoint method and QuarterGaugeChartPoint class can add a Quarte Gauge Chart directly to the map.

              var quarterGaugeChartPoint = new RealTimeMap.QuarterGaugeChartPoint()
                   {
                       location = new RealTimeMap.Location()
                       {
                           latitude = 50.81229753879652,
                           longitude = 4.4274985764447905
                       },
                       dimension = 60,
                       indexQuadrant = 3,  //trigonometric quadrant number (0,1,2,3)
                       valueStart = 0,
                       valueStop = 35,
                       value = 18,
                       label="temperature",
                       opacity = 0.4
               };
               await args.sender.Geometric.DisplayChartFromObject.addChartPoint(quarterGaugeChartPoint);


<img width="945" height="682" alt="image" src="https://github.com/user-attachments/assets/6987511a-65f9-4592-a300-73f1f9f0a092" />


Clear all chart items from RealTimeMap:

    await realTimeMap.Geometric.DisplayChartFromObject.clearAll();

# QuarterGaugeScalePercentChartPoint

The addChartPoint method and QuarterGaugeScalePercent class can add a Quarte Gauge Scale And Percent Chart directly to the map.

              await args.sender.Geometric.DisplayChartFromObject.addChartPoint(new RealTimeMap.QuarterGaugeScalePercent()
              {
                  location = new RealTimeMap.Location()
                  {
                      latitude = 50.81229753879652,
                      longitude = 4.4274985764447905
                  },
                  dimension = 62,
                  visibilityZoomLevel = new RealTimeMap.VisibilityZoomLevel()
                  {
                      minZoomLevel = 10,
                      maxZoomLevel = 14
                  },
           
                  indexQuadrant = 3,
                  valueStart = 0,
                  valueStop = 120,
                  value = 60,
                  fontSize = 5,
           
                  label = "time waiting (s)",
                  fillPanel = "yellow",
                  opacity = 0.6,
           
                  fillingColor = "#ff4500",
           
                  haloText = true,
                  type = RealTimeMap.QuarterGaugeScalePercentType.HowManyAreThere //type of chart HowManyAreThere || HowManyAreLeft
              });


Example 1:

       HowManyAreThere = 0,
       HowManyAreLeft = 1,


<img width="869" height="677" alt="image" src="https://github.com/user-attachments/assets/43277e41-b1d6-4b60-9797-baa90bb51263" />

Example 2

       HowManyAreThere = 0,
       HowManyAreLeft = 1,
       Both = 2

<img width="1101" height="966" alt="image" src="https://github.com/user-attachments/assets/0bd7f5db-319a-4a41-94b9-32d9e5c32740" />


Clear all chart items from RealTimeMap:

    await realTimeMap.Geometric.DisplayChartFromObject.clearAll();

# Combined Chart


You can combine Gauge ChartPoint with other Gauge Chart Point charts, but also DiscreteGaugeChartPoint.


<img width="2576" height="1638" alt="image" src="https://github.com/user-attachments/assets/77edfb94-ec5f-4a9e-8aad-1febd8755bda" />


  
Clear all chart items from RealTimeMap:

    await realTimeMap.Geometric.DisplayChartFromObject.clearAll();

[GaugeChartPoint example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20ChartPoint/GaugeChartPoint)

