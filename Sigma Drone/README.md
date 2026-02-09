# Sigma Drone Chart


![interactive08](https://github.com/user-attachments/assets/64fbf731-61a2-47dc-bb41-8a917cd879e1)


## Basic properties

Just as each chart that is displayed on the map has a location, Sigma Drone Chart has properties related to location, size, and visibility levels:

     var sigmaDroneChartPoint = new RealTimeMap.SigmaDroneChartPoint()
        {
            location = new RealTimeMap.Location()                  //mandatory
            {
                latitude = 50.81229753879652,
                longitude = 4.4274985764447905
            },
            dimension = 80,
            visibilityZoomLevel = new RealTimeMap.VisibilityZoomLevel()     //not mandatory
             {
                 minZoomLevel = 6,
                 maxZoomLevel = 14
             },
          };


## Configuring the first indicators

A first set of indicators are displayed on the circle sector of the gauge chart and refer to the 
 - **WiFi signal** - level between -1 (without signal) and 3 (maximum level of signal);
 - **Altimeter** - configurable between 0 (default) and maximum height;

Both altimeter and WiFi signal are optional.

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

        
## Crown Indicators

The chart crown can host one or more indicators, of the same type or of different types. 3 distinct types of indicators can be added to the crown:
<table>
     <tr>
          <td> Scale </td>
          <td> Discrete </td>
          <td> Percent </td>
     </tr>
    <tr>
         <td>
              <img width="240" height="124" alt="image" src="https://github.com/user-attachments/assets/363a08b4-8e74-4b69-a234-0cefe5c64ca2" />
         </td>
         <td>
              <img width="241" height="129" alt="image" src="https://github.com/user-attachments/assets/c466b3ab-4722-48a1-ac84-de04b7318d18" />
         </td>
         <td>
               <img width="240" height="124" alt="image" src="https://github.com/user-attachments/assets/30da9478-be5c-4a1a-a8d8-6e822fdb7fad" />
         </td>
    </tr>
</table>

- **Scale indicator**. It is a scale type indicator (similar to the metric one) and can display speed, battery level, fuel level, engine speed, etc. Is implemented by the class **RealTimeMap.SigmaDroneCrownScale**

            new RealTimeMap.SigmaDroneCrownScale()
            {
                label = "x 10 km/h",
                valueStart = 0,
                valueStop = 12,
                value = 8,
                percentageOfTheEntireCrown = 20,          //how much of the circular crown will be filled with this indicator
            }

- **Discrete indicator**. It is an indicator that can display discrete classes of a parameter (e.g. half, full). Is implemented by the class **RealTimeMap.SigmaDroneCrownDiscrete**

               new RealTimeMap.SigmaDroneCrownDiscrete()
              {
                  label  = "battery",
                  colors = new List<string>() { "red", "orange", "yellow", "green" }.ToArray(),
                  percentageValues = new List<int>() { 33, 33, 33, 33 }.ToArray(),
                  index=1,
                  labels = new List<string>() { "critical", "low", "long range", "full" }.ToArray(),
                  percentageOfTheEntireCrown = 80,          //how much of the circular crown will be filled with this indicator
              }

- **Percent indicator**. It is an indicator dedicated to displaying percentage values ​​(of a whole).Is implemented by the class **RealTimeMap.SigmaDroneCrownPercent**

                 new RealTimeMap.SigmaDroneCrownPercent()
                {
                    label = "fuel",
                    valueStart = 0,
                    valueStop = 10,
                    value = 3,
                    percentageOfTheEntireCrown = 20,          //how much of the circular crown will be filled with this indicator
                }

  The **percentageOfTheEntireCrown** parameter will set how much of the circular crown will be filled with this indicator.

## Multiple indicators on the same crown

The crown of a Sigma Drone Chart can have one or more indicators of the same type or of different types (RealTimeMap.SigmaDroneCrownScale, RealTimeMap.SigmaDroneCrownDiscrete, RealTimeMap.SigmaDroneCrownPercent).
<table>
     <tr>
          <td>Case 1</td>
     </tr>
     <tr>
          Two indicators of the same type and same percentage of coverage of the circular crown
     </tr>
     <tr>
          <img width="240" height="141" alt="image" src="https://github.com/user-attachments/assets/6c47cdfa-7d04-4d42-968c-d73a199bd03d" />
     </tr>
</table>
**Case 1**. Two indicators of the same type and same percentage of coverage of the circular crown



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

[more about basic config](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Sigma%20Drone/Sigma%20Drone%20Chart%20basic#sigma-drone-chart-basic)
