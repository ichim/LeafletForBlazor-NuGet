# RealTimeMap and load parameteres

RealTimeMap.LoadParameters is a class that allows the map to be configured when loading. 

Blazor page:

            <RealTimeMap height="calc(100vh - 6rem)" width="calc(100vw - 18rem)" Parameters="@parameters"></RealTimeMap>

Code block:

            @code{
                RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()
            }

This class allow:

1. configuring the center of the RealTimeMap view:


            RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()
            {
               location =  new RealTimeMap.Location()
               {
                        latitude = 43.65406446200289,
                        longitude = 25.369446755738487
               }
            };


2.configuring the zoom level of the RealTimeMap view:

              RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()
              {
                 zoomLevel = 18
              };

3. scale of view map:
  
               RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()
               {
                 mapScale = new RealTimeMap.MapScale()
                 {
                     has = true,
                     meters = true,
                     miles = true
                 }  
               };
