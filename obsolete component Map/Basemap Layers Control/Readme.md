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
