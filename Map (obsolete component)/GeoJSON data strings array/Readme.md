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
