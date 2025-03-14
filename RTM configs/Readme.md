# RealTimeMap and load parameteres

[Video Example - location, zoom level and Map Scale](https://www.youtube.com/watch?v=zisprc60S88)

[Video Example - basemap layers](https://www.youtube.com/watch?v=2Ut4ugCuCJk&t=221s)

RealTimeMap.LoadParameters is a class that allows the map to be configured when loading. 

Blazor page:

            <RealTimeMap height="calc(100vh - 6rem)" width="calc(100vw - 18rem)" Parameters="@parameters"></RealTimeMap>

Code block:

            @code{
                RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters();
            }

This class allow:

 - configuring the center of the RealTimeMap view:


            RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()
            {
               location =  new RealTimeMap.Location()
               {
                        latitude = 43.65406446200289,
                        longitude = 25.369446755738487
               }
            };


- configuring the zoom level of the RealTimeMap view:

              RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()
              {
                 zoomLevel = 18
              };

- scale of view:
  
               RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()
               {
                 mapScale = new RealTimeMap.MapScale()
                 {
                     has = true,
                     meters = true,
                     miles = true
                 }  
               };
