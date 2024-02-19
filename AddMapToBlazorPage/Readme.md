## Basic Map configuration ##

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

[Basic Map configuration - GitHub example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Map%20with%20LeafletForBlazor%20NuGet)
