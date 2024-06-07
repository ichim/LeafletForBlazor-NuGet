
# **DataFromGeoJSON** class

It is a class hosted by the **Geometric** class. This class allows adding spatial data from **GeoJSON** formats.

Two formats are used, both complying with [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946):

1. The first format is an array that exactly respects the format [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946)

		<RealTimeMap OnAfterMapLoaded="@OnAfterMapLoaded" width="460px" height="462px" />
		@code{
			public async Task OnAfterMapLoaded(RealTimeMap.MapEventArgs args)
			 {
				await args.sender.Geometric.DataFromGeoJSON.addObject(geojsonArray);
			 }
		}

1. And another JSON format, which for the "data" property we have the same array [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946). In addition, this format accepts customization of symbolization, tooltips, etc 



		<RealTimeMap OnAfterMapLoaded="@OnAfterMapLoaded" width="460px" height="462px" />
		@code{
			public async Task OnAfterMapLoaded(RealTimeMap.MapEventArgs args)
			 {
				await args.sender.Geometric.DataFromGeoJSON.addObject(geojsonObject);
			 }
		}

## Working with array

The GeoJSON array format is the one in the documentation [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946)
In order to create a GeoJSON array, it is necessary to define the classes:

### GeoJSON custom properties

	   public class Properties
	   {
	       public string? name { get; set; }
	   }

### GeoJSON geometry

	    public class PointGeometry
	    {
	        public string? type { get; set; } = "Point";
	        public double[]? coordinates { get; set; }
	        public Properties? properties { get; set; }
	    }

### GeoJSON item

	public class GeoJSONItem
	{
		public string? type { get; set; }
		public PointGeometry? geometry { get; set; }   
	}

### Using GeoJSON array

   	List<GeoJSONItem> inputPointsList = new();
    	await args.sender.Geometric.DataFromGeoJSON.addObject(inputPointsList.ToArray());

[Working with GeoJSON Array example and documentation](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON/working%20with%20Array)


## Configuring Appearance from files

GeoJSON data can be loaded from files hosted on the Internet (https protocol). Once with loading data, the programmer can configure the appearance, the visibility scales and the content of the tools.

Blazor page:

		<RealTimeMap OnAfterMapLoaded="@OnAfterMapLoaded"  width="1000px" height="620px" />

Code block:

		@code {
		    string path = "http://localhost:5278/";
		    
		    public async Task OnAfterMapLoaded(RealTimeMap.MapEventArgs args)
		    {
		        await args.sender.Geometric.DataFromGeoJSON.addFromFiles(new string[2]
		            {
		                $"{path}sample-data/otherPolygonsAppearance.json",
		                 $"{path}sample-data/pointIconTooltip.json"
		            }
		        );
		
		    }
		}
 

[example loading and config. from files](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON/config%20tooltip%20from%20file)

![GeoJSON@appearance20](https://github.com/ichim/LeafletForBlazor-NuGet/assets/8348463/81f4ea40-55b5-4dd5-9270-c2643aa47dd6)





