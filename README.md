# Leaflet Map for Blazor

 > You can quickly add a map to the blazor page. 
 > In addition, you can add GeoJSON data in the map, symbolize Map items, add tooltips to map items, working with basemap and overlay layers and others 

This package is under development, but I will keep the code compatible from one version to another.

You can find more information:

 - [LeafletForBlazor GitHub](https://github.com/ichim/LeafletForBlazor-NuGet)

 - [Youtube channel](https://www.youtube.com/@step-by-step-cs)

 - [Youtube LeafletForBlazor playlist](https://youtube.com/playlist?list=PLDpzfV5MtMji-wml7dm5S80hOc1Nzywtc)

 _____________

## What's New? ##

New Load Map boolean parmeter (anyway_overlay_layers_control), which forces the display of GeoJSON layers in the Layers Control.


		Map.LoadParameters parameters = new Map.LoadParameters()
        {
            anyway_overlay_layers_control = true
		}


![Overlay Layers](https://user-images.githubusercontent.com/8348463/222403645-808e878c-79d1-425f-a302-38ab09718f78.gif)

The names of the files will be displayed in the Layers Control, the overlay layers section.
 _____________

## Basic map configuration:

#### Add in __Imports.razor_ project file

	@using LeafletForBlazor

#### Add in your Blazor Page:

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

## Map events ##

LeafletForBlazor Map provide some events:
 - OnLoadMap();
 - OnMapClick();
 - OnZoomChange();

 #### Blazor page: ####

 	<Map 
		width="600px" 
		height="600px"
		onLoadMap="@OnLoadMap"
		onMapClick="@OnMapClick"
		onZoomChange="@OnZoomChange">
	</Map>

#### Blazor code block:

	@code {
		//Map events
		public void OnLoadMap(Map.OnLoadEventParameters event_args)
		{

		}
		public void OnZoomChange(int zoom_level)
		{
        
		}
		public void OnMapClick(Map.Location event_args)
		{
        
		}
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

[Leaflet GeoJSON page](https://geojson.org/)

[GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946)

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

_Is an leaflet format in which symbolization has been added_ to the leaflet data

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


O-L I




Thank you for choosing this package!

Laurentiu Ichim
