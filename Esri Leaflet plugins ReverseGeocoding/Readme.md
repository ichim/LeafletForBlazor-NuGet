### Extending the Leaflet API with Esri Reverse Geocoding plugin ###

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

