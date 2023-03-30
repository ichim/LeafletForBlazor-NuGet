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
