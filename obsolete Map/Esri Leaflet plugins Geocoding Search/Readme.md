### Extending the Leaflet API with Esri Geocoding Search plugin ###

First of all, you will need an _Esri API Key code_. Generating an Esri API Key code is free, but you need an Esri developer account:

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
