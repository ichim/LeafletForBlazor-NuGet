# RealTimeMap and load parameteres

RealTimeMap.LoadParameters is a class that allows the map to be configured when loading. 
1. This class allows configuring the center of the map view:


            RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()
            {
               location =  new RealTimeMap.Location()
               {
                        latitude = 43.65406446200289,
                        longitude = 25.369446755738487
               }
            };
