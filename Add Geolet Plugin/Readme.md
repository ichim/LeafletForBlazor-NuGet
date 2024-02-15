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

