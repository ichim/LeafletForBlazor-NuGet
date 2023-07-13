# ![LealletForBlazor32](https://user-images.githubusercontent.com/8348463/224698821-8768d8af-46ea-462a-a603-a7adf9095594.png) Leaflet Map for Blazor

 > You can quickly add a map to the blazor page. 
 > In addition, you can add GeoJSON data in the map, symbolize Map items, add tooltips to map items, working with basemap and overlay layers and others 

[NuGet Package](https://www.nuget.org/packages/LeafletForBlazor#versions-body-tab)

This package is under development, but I will keep the code compatible from one version to another.

You can find more information:

 - [LeafletForBlazor GitHub](https://github.com/ichim/LeafletForBlazor-NuGet)
 - [Youtube channel](https://www.youtube.com/@step-by-step-cs)
 - [Youtube LeafletForBlazor playlist](https://youtube.com/playlist?list=PLDpzfV5MtMji-wml7dm5S80hOc1Nzywtc)

 _____________

## What's New? ##

> Starting with version 2.0, the Map component will be replaced with RealTimeMap. The RealTimeMap component is designed to update the position of a single point (my position) or to update large collections of points.
> Eventually, the Map control will become deprecated and replaced by RealTimeMap.
> In future versions (2 +), functionality will be added to track updated data in real time.

###RealTimeMap

> Starting with current version, LeafletForBlazor provide a new map control named RealTimeMap. This new control is optimized for working with streaming data.

####Working with a single point (ex. my position)

> A first method added to the control is movePoint(args...) which allows displaying the position of a single point. The method can be used to monitor one's own position.

The movePoint() method accepts from one argument to three arguments:
 - coordinate (double[2]): point coordinate. For example: realTimeMap.movePoint([44.4502578, 26.1108199]). Latitude and Longitude in degrees, geographical coordinates;
 - symbol (PointSymbol/PointIcon): the point can be displayed with a circle (PointSymbol) or an icon/*.png (PointIcon);
 - tooltip (PointTooltip): configuring a tooltip with various information;

![movePoint](https://github.com/ichim/LeafletForBlazor-NuGet/assets/8348463/4ddf32b1-abcb-463c-988e-1633e0224f2a)

    public class PointTooltip
    {
        public string? content { get; set; }
        public bool permanent { get; set; } = true;
        public double opacity { get; set; } = 0.9;
    }
####Add in __Imports.razor_ project file

    @using LeafletForBlazor

####Blazor Page:

    <button @onclick="onClickRun">Run</button> //launch moving points
    <RealTimeMap
        @ref="realTimeMap"
        width="600px" 
        height="600px"
        Parameters="@parameters"
    ></RealTimeMap>

####Blazor code block:

    @code {
        RealTimeMap? realTimeMap;	//reference to map control
        RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()  //general map settings
        {
            zoom_level = 18,
            location = new RealTimeMap.Location()
            {
                latitude = 44.4501715,
                longitude = 26.1107672,
            }
        }
        
        //points (coordonate) on the route. For simulation...
        List<List<double>> coordinates = new List<List<double>>() {
        new List<double>() { 44.4502578, 26.1108199 },
        new List<double>() { 44.4500215, 26.1105407 },
        new List<double>() { 44.4497369, 26.1093086 },
        new List<double>() { 44.4496145 , 26.1088460 },
        new List<double>() {  44.4491875, 26.1079328 }
        };

        RealTimeMap.PointSymbol symbol = new RealTimeMap.PointSymbol()
        {
            color = "red",
            fillColor = "yellow",
            radius = 10,
            weight = 3,
            opacity = 1,
            fillOpacity = 1
        };
        bool run = false;
        private async Task onClickRun() //Button onclick event
        {
            run = !run;
            for(var i=0;i<1000;i++)
            {
                pas = i % coordinates.Count;
                RealTimeMap.PointTooltip tooltip = new RealTimeMap.PointTooltip() { 
                    content=$"{Math.Round( coordinates[pas][0],3)},{Math.Round( coordinates[pas][1],3)}", 
                    opacity = 0.6 
                };

                await  realTimeMap.movePoint(coordinates[pas].ToArray(),  symbol, tooltip);
                await Task.Delay(1000);
                if (run == false)
                    return;
            }
        }

    }

 _____________

## Basic Map configuration ##

#### Add in __Imports.razor_ project file

    @using LeafletForBlazor

#### Blazor Page:

    <Map 
        width="600px" 
        height="600px"
        Parameters="@parameters"
    ></Map>

#### Blazor code block:

    @code {
        //map initialization parameters
        Map.LoadParameters parameters = new Map.LoadParameters()
        {
            location = new Map.Location()
            {
                longitude = 26.097133,
                latitude = 44.446165
            },
            zoom_level = 12
        };
    }

[Basic Map configuration - GitHub example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Map%20with%20LeafletForBlazor%20NuGet)

## Map scale

#### Blazor Page:

    <Map 
        width="600px" 
        height="600px"
        Parameters="@parameters"
    ></Map>

#### Blazor code block:

    @code {
        //map initialization parameters
        Map.LoadParameters parameters = new Map.LoadParameters()
        {
            map_scale = new Map.MapScale()
            {
                has = true,
                meters = true,
                miles = false
            }
        };
    }

[Map Scale - GitHub example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Map%20Scale)

## Basemaps ##

Now, you can define a base map list, from various sources (Open Street Map, Open Cycle Map and so one). 

The user of the application, created by you, will be able to change the basemap.

#### Blazor page: ####

    <Map
        width="800px"
        height="700px"
        Parameters="@parameters"
        ></Map>

#### Blazor code block ####

        Map.LoadParameters parameters = new Map.LoadParameters()
        {
            ....
            basemap_layers = new List<Map.BasemapConfigLayer>
            {
                new Map.BasemapConfigLayer()
                {
                    url = "http://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png",
                    attribution = "©Open Street Map",
                    title = "Open Street Map",
                    detect_retina = true
                },
                new Map.BasemapConfigLayer()
                {
                    url = "https://tile.thunderforest.com/cycle/{z}/{x}/{y}.png?apikey=[your API Key]",
                    attribution = "©Open Cycle Map",
                    title = "Open Cycle Map"
                }
            }
        };

![basemap](https://user-images.githubusercontent.com/8348463/221944717-b77efc27-c695-4768-9f4d-aa1e35aeef0d.gif)

[Basemap - GitHub example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Basemap%20Layers%20Control)

## Map Events

Click on Map method trigger:

>	onMapClick return Map.CurrentMapState object

Double Click on Map method trigger:

>	onMapDblClick return Map.CurrentMapState object

Recomandation! Use _doubleClickZoom = false_ to disable zoom on double click, as can be seen below (below is an example).

Code Block:

    Map.MapOptions map_options = new Map.MapOptions()
    {
        interaction_options = new Map.InteractionOptions()
        {
            doubleClickZoom = false
        }
    };
Blazor page:

    <Map
        width="800px"
        height="600px"
        Parameters="@parameters"
        Options="@map_options"
        onMapDblClick="@OnMapDoubleClick"
    ></Map>

Load Map method trigger:

>	onLoadMap return Map.CurrentMapState object

[Working onLoadMap event - GitHub example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Map%20Events%20onLoadMap)

Zoom on Map method trigger:

>	onZoomChange return Map.CurrentMapState object

Pan or Zoom on Map method trigger:

>	onMoveChange return Map.CurrentMapState object

Events parameter (blue print) of all methods trigger:

    #region CurrentMapState and Location blue print
        public class CurrentMapState	//current state (bound, center and zoom level) of the Map
        {
            public Location location { get; set; } = new Location();
            public int zoom_level { get; set; }
            public MapBounds map_bounds { get; set; } = new MapBounds();
        }
        public class MapBounds		//Map bound coordinates
        {
            public Location _southWest { get; set; } = new Location();
            public Location _northEast { get; set; } = new Location();
        }
        public class Location		//center Map location
        {
            public double longitude { get; set; }
            public double latitude { get; set; }
        }
    #endregion

### Map event example code
Below will be presented a simple example with the Double Click on Map event

#### Blazor Page:

    <Map
        width="800px"
        height="600px"
        Parameters="@parameters"
        Options="@map_options"
        onMapDblClick="@OnMapDblClick"
    ></Map>
#### Blazor code block:
    @code{
        public void OnMapDblClick(Map.CurrentMapState evt_parameters)
        {

        }

        Map.MapOptions map_options = new Map.MapOptions()
            {
                interaction_options = new Map.InteractionOptions()
                {
                    doubleClickZoom = false //here we will disable navigation in the map on double click. Is not mandatory!
                }
            };

        Map.LoadParameters parameters = new Map.LoadParameters()
            {
                location = new Map.Location()
                {
                    longitude = 26.1107672,
                    latitude = 44.4501715
                },
                zoom_level = 14
            };
    }

## JSON file example (GeoJSON_urls Map parameter)

#### Blazor Page:

    <Map 
        width="600px" 
        height="600px"
        GeoJSON_urls="@urls.ToArray()"
    ></Map>

#### Blazor Code:

    @code {
        //working with GEOJson file
        /*	
            GeoJSON_urls <Map> parameter expects an array of JSON url
            1. The JSON data complies with the Leaflet documentation
            2. A improved format that allows custom symbolization
            3. The simultaneous use of the two types of format (RFC 7946 format and improved format)
        */
        List<string> urls = new List<string>() { 
            "http://localhost:5078/polygonsfile.json", 
            "http://localhost:5078/pointsfile.json"  
            };
        }

### 1. Leaflet documentation format

_Is the format shown in the Leaflet documentation_

- [Leaflet GeoJSON page](https://geojson.org/)
- [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946)

        [
            {
              "type": "Feature",
              "geometry": {
                "type": "Polygon",
                "coordinates": [
                  [
                    [ 26.0931846, 44.4432512 ],
                    [ 26.0945783, 44.4435381 ],
                    [ 26.0959206, 44.4438006 ],
                    ...
                  ]
                ]
              }
        ]

### 2. Improved Leaflet Format. This format allows configuring the symbolization of map elements

_Is an leaflet format in which symbolization (with scaling) and tooltip configuration (with scaling) has been added_ to the leaflet data [(RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946).

### Advantages ###
    
- The symbology and tooltips configuration are stored along with the data;
- Changing the symbolization will be done without changing the code;
- Also, changing tooltips configuration will be done without changing the code;
- Several applications (web, mobile, etc.) will display the same map, the same symbols;

            {
                  "data": [...GeoJSON specification (RFC 7946)...],
                  "symbology": { ... },
                  "tooltip": { ... }
            }
            

Meaning of JSON (improved format) parameters:

 - JSON _"data"_ paratemeter expects an array of GeoJSON items [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946)
 - JSON _"symbology"_ parameter expects the custom symbology of GeoJSON items

       "symbology": {
            "default": {
            "color": "red",
            "weight": 5,
            "opacity": 0.4
            },
            "case": {
                "field_name": "name",
                "classes": [
                        {
                        "value": "Bdul Magheru",
                        "symbol": {
                            "color": "yellow",
                            "weight": 5,
                            "opacity": 0.4
                            }
                        },
                        {
                      "value": "Bdul Dacia",
                      "symbol": {
                            "color": "green",
                            "weight": 5,
                            "opacity": 0.4
                        }
                    }
                ]
            }
            "scaling": {
                "start_with": 16,
                "stop_with": 18
                }
        }

In the previous example, we have a default symbol and two other symbols for two predefined classes. This two classes are defined based on the values in the "name" field.

Result of polygons classes symbolization of [GitHub example](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/PolygonsSymbolization):

Symbolization by classes is done based on a property (field) of the GeoJSON elements.

for example:
- commercial areas were symbolized in yellow;
- residential areas were symbolized in green;
- other areas were symbolized in red;

![PolygonsSymbolization](https://user-images.githubusercontent.com/8348463/221033035-2f11654e-010c-4c64-b1c9-ae9cbe4737bf.png)

[Working with JSON file - GitHub example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Basemap%20Layers%20Control)

### Symbology and tooltip scaling ###

> Map elements (with symbology) and tooltips will be displayed in the map only for zoom levels between start_with and stop_with.


![scaling01](https://user-images.githubusercontent.com/8348463/221374917-8a662947-6ae7-4ddb-9cf7-7ae79329c72b.gif)

_In the case of the GeoJSON layer, scaling will only work when we have defined at least one default symbol_

 - JSON _"symbology"_ parameter expects the definition of GeoJSON items tooltip. _"scaling"_ parameter is not mandatory.


         "symbology": {
            "default": {
                "color": "red",
                "weight": 5,
                "opacity": 0.4
            },
            "scaling": {
                "start_with": 15,
                "stop_with": 18
            }
          }

 - JSON _"tooltip"_ parameter expects the definition of GeoJSON items tooltip. _"scaling"_ parameter is not mandatory.


       "tooltip": {
            "fields_name": [ "name", "lanes" ],
            "offset": [ 0, 0 ],
            "permanent": true,
            "opacity": 0.5,
            "coordinate_inversion": true,
                "scaling": {
                    "start_with": 16,
                    "stop_with": 18
                    }
        }

### GeoJSON files and working with Layers Control ###

The Load Map boolean parmeter (anyway_overlay_layers_control) forces the display of GeoJSON layers in the Layers Control.


        Map.LoadParameters parameters = new Map.LoadParameters()
        {
            anyway_overlay_layers_control = true
        }


![Overlay Layers](https://user-images.githubusercontent.com/8348463/222403645-808e878c-79d1-425f-a302-38ab09718f78.gif)

The names of the files will be displayed in the Layers Control, the overlay layers section.

### Working with GeoJSON string array

GeoJSON data can be loaded as strings.

#### Add in your Blazor Page:

    <Map
        width="800px"
        height="600px"
        Parameters="@parameters"
        GeoJSON_strings="@date_geojson.ToArray()"
    ></Map>

#### Blazor code block:

    List<string> date_geojson = new List<string>()
    {
       "[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[26.097369,44.444941]},\"properties\":{\"name\":\"Beautiful Memories Store\"}}]"
    };

... and optional parameters:

    Map.LoadParameters parameters = new Map.LoadParameters()
    {
        location = new Map.Location()
        {
            longitude = 26.1107672,
            latitude = 44.4501715
        },
        zoom_level = 14,
        map_scale = new Map.MapScale()
        {
            has = false,
            meters = true
        }
    };

## Images Overlay

Load and display images over specific bounds of the map.

![ImagesOverlay3](https://user-images.githubusercontent.com/8348463/230477893-8966306e-2cae-44bf-b3ad-8ef7870f1111.gif)

### Blazor Page:

    <Map
        width="750px"
        height="650px"
        MapOverlays="@overlays"
    ></Map>

### Blazor code block:

    @code{
        Map.Overlays overlays = new Map.Overlays()
        {
            images = new Map.ImageOverlay()
            {
                images_and_bounds = new List<Map.ImagesAndBoundsCoordinates>()
                {
                    new Map.ImagesAndBoundsCoordinates()
                    {
                        url = "http://localhost:5116/atene.png",
                        map_bounds = new Map.MapBounds()
                        {
                            _southWest = new Map.Location()
                            {
                                longitude = 26.0970904,
                                latitude=44.4409802
                            },
                            _northEast = new Map.Location()
                            {
                                longitude = 26.0985575,
                                latitude=44.4418393
                            }
                        }
                    },
                new Map.ImagesAndBoundsCoordinates()
                    {
                        url = "http://localhost:5116/romana.png",
                        map_bounds = new Map.MapBounds()
                        {   
                            _southWest = new Map.Location()
                            {
                                longitude = 26.0964848,
                                latitude=44.4465985
                            },
                            _northEast = new Map.Location()
                            {
                                longitude = 26.0983148,
                                latitude=44.4475250
                            }
                        }
                    }
                }
            }    
        };
    }

[Image overlay - GitHub example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Images%20overlay%20on%20map)

## Working with Leaflet Plungins ##

Starting with 1.1.8 version, LeafletForBlazor NuGet is able to implement Leaflet plugins.
These plugins will be adapted for use in Blazor.

### Configuring the Geolet plugin ###

_The configuration parameters have the same names as those in the Leaflet documentation:_

#### Blazor page ####

    <Map
        width="800px"
        height="700px"
        Plugins="@plugins"
    ></Map>

#### Blazor code block ####

    Map.PluginsConfig plugins = new Map.PluginsConfig()
    {
        display_all = true,
        plugins = new List<Map.Plugin>() { 
        new Map.Plugin() { 
            name = "Geolet",
            config = "{\"title\": \"Locatia mea\", \"position\": \"topleft\", \"popupContent\": \"`latitudine ${latlng.lat}<br>longitudine ${latlng.lng}`\"}" 
            } 
        }
    };

The "config" parameter is a string json object.

![Geolet](https://user-images.githubusercontent.com/8348463/223373865-41c29b8e-fa2f-4df2-a2ef-8d3b52a87c1f.gif)


### Using Esri plugins ###

Esri is the most important player of the GIS market. Esri software solutions are complete and guarantee high performance. 
In addition, Esri offers users many open and/or freely used software solutions. You can freely use the power of Esri tools, only on the basis of an _Esri API Key code_

### Extending the Leaflet API with Esri Basemaps plugin ###

Adding Esri basemaps is done on the PluginsConfig interface and the Plugins parameter of the LeafletForBlazor package.

First of all, you will need an _Esri API Key code_. Generating an Esri API Key code is free, but you need an Esri developer account.

 [Here you will find a guide for generating an _Esri API Key code_](https://developers.arcgis.com/esri-leaflet/get-started/)

#### Add in your Blazor Page:

    <Map
        width="800px"
        height="700px"
        Plugins="@plugins"
    ></Map>

#### Blazor code block:

    @code{
        Map.PluginsConfig plugins = new Map.PluginsConfig()
        {
            display_all = true,
            plugins = new List<Map.Plugin>() 
            { 
                new Map.Plugin()
                {
                    name = "Esri",
                    config =  new Map.EsriPlugin()
                        {
                            apiKey = "[your Esri API Key code]",
                            esri_plugins_config = new List<object>()
                            {
                                new Map.EsriBasemapConfig()
                                {
                                enable = true,
                                esri_basemap_layers = new List<Map.EsriBasemapLayer>()
                                    {
                                        new Map.EsriBasemapLayer(){basemap_id ="ArcGIS:Imagery"},
                                        new Map.EsriBasemapLayer(){basemap_id = "ArcGIS:Imagery:Standard"},
                                        new Map.EsriBasemapLayer(){basemap_id = "ArcGIS:Imagery:Labels"}
                                    }
                                }
                            }
                        }
                }
            }
        };
    };

![Esri Basemaps](https://user-images.githubusercontent.com/8348463/224008704-316fb063-202f-4350-96f1-a1acb209a0de.gif)

[Esri Basemap - GitHub example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Esri%20Leaflet%20plugins%20Basemap)


### Extending the Leaflet API with Esri Geocoding Search plugin ###

First of all, you will need an _Esri API Key code_. Generating an Esri API Key code is free, but you need an Esri developer account.

 [Here you will find a guide for generating an _Esri API Key code_](https://developers.arcgis.com/esri-leaflet/get-started/)

#### Add in your Blazor Page:

    <Map
        width="800px"
        height="800px"
        Plugins="@plugins"
    ></Map>

#### Blazor code block:

    Map.PluginsConfig plugins = new Map.PluginsConfig()
    {
        display_all = true,
        plugins = new List<Map.Plugin>() { 
                new Map.Plugin()
                {
                    name = "Esri",
                    config =  new Map.EsriPlugin()
                    {
                        apiKey = "[your Esri API Key code]",
                        esri_plugins_config = new List<object>()
                        {

                            new Map.EsriGeocodingSearchParameters()
                            {
                                enable = true,
                                placeholder = "Your address",
                                position = "topleft",
                                nearby = new Map.EsriNearby(){lat = 0,lng = 0}
                            }
                        }
                    }
                }
            }
    };

![GeocodingSearch](https://user-images.githubusercontent.com/8348463/224486025-eb7d3eb2-907f-48e1-ad97-6a57f734c9e6.gif)


[Esri Geocoding Search - GitHub example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Esri%20Leaflet%20plugins%20Geocoding%20Search)

### Extending the Leaflet API with Esri Reverse Geocoding plugin ###

First of all, you will need an _Esri API Key code_. Generating an Esri API Key code is free, but you need an Esri developer account.

 [Here you will find a guide for generating an _Esri API Key code_](https://developers.arcgis.com/esri-leaflet/get-started/)

#### Add in your Blazor Page:

    <Map
        width="800px"
        height="800px"
        Plugins="@plugins"
    ></Map>

#### Blazor code block:

       Map.PluginsConfig plugins = new Map.PluginsConfig()
       {
            display_all = true,
            plugins = new List<Map.Plugin>() 
            {
                new Map.Plugin()
                {
                    name = "Esri",
                    config =  new Map.EsriPlugin()
                    {
                        apiKey = "[your Esri API Key code]",
                        esri_plugins_config = new List<object>()
                        {
                            new Map.EsriReverseGeocodingParameters()
                            {
                                enable = true,
                                remove_last_result = true
                            }
                        }
                    }
                }
            
            }
        };

![ReverseGeoconding](https://user-images.githubusercontent.com/8348463/224543709-034fbb0e-8a2d-4875-9a17-a240342f518f.gif)

[Reverse Geocoding - GitHub example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Esri%20Leaflet%20plugins%20ReverseGeocoding)

O-L I

Thank you for choosing this package!

Laurentiu Ichim
