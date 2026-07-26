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
