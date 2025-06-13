> Here you will find examples of the default configuration of the RealTimeMap and its dynamic configuration (ex. Basemap, Attribution etc)

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


- configuring basemaps


                static string openCycleMapAPIKey = "--- your Open Cycle Map API Key ---";
                RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()
                    {
                        basemap = new RealTimeMap.Basemap()
                        {
                            basemapLayers = new List<RealTimeMap.BasemapLayer>()
                                 {
                                            new RealTimeMap.BasemapLayer()
                                            {
                                                url = "https://tile.thunderforest.com/cycle/{z}/{x}/{y}.png?apikey=" + openCycleMapAPIKey,
                                                attribution = "©Open Cycle Map",
                                                title = "Open Cycle Map"
                                            },
                                 }
                            },
                    };

- confinguring map attribution


                RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()
                    {
                       defaultAttribution = new RealTimeMap.DefaultAttribution()
                       {
                           has =  true,
                           defaultHtmlContent = "<h6 style = \"font-style:italic;opacity:0.2\">My Map</h6>"
                       }
                    };

# RealTimeMap and dynamic settings

Blazor page:

            <RealTimeMap height="calc(100vh - 6rem)" width="calc(100vw - 18rem)"  OnAfterMapLoaded="@OnAfterMapLoaded"></RealTimeMap>

Code block:

            @code{
                        public async Task OnAfterMapLoaded(RealTimeMap.MapEventArgs args)
                            {
                                   //settings code example
                            }
            }

## Map Attribution

- add more attribution

            public async Task OnAfterMapLoaded(RealTimeMap.MapEventArgs args)
                {
                        args.sender.Map.Attributions.add("<h6 style = \"font-style:italic;opacity:0.2\">My GeoJSON data</h6>");
                }

- remove attribution

            public async Task OnAfterMapLoaded(RealTimeMap.MapEventArgs args)
                {
                        args.sender.Map.Attributions.remove("<h6 style = \"font-style:italic;opacity:0.2\">My GeoJSON data</h6>");
                }

## View dynamic settings

Blazor page

        <RealTimeMap @ref = "realTimeMap" height="calc(100vh - 6rem)" width="calc(100vw - 18rem)"></RealTimeMap>

Code block

            @code{
            RealTimeMap? realTimeMap;
            
                                realTimeMap?.View.setCenter = new RealTimeMap.Location()
                                {
                                        latitude = 40.712,
                                        longitude = -74.227
                                };
            
                    }
