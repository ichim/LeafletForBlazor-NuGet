# RealTimeMap and load parameteres

RealTimeMap.LoadParameters is a class that allows the map to be configured when loading. This class allow:
1. configuring the center of the RealTimeMap view:


            RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()
            {
               location =  new RealTimeMap.Location()
               {
                        latitude = 43.65406446200289,
                        longitude = 25.369446755738487
               }
            };

1. configuring the zoom level of the RealTimeMap view:

              RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()
              {
                 zoomLevel = 18
              };
