
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

# **DataFromGeoJSON** class

You can add GeoJSON specification data [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946) from files:

RealTimeMap OnAfterMapLoaded event:

    private void onAfterMapLoad(RealTimeMap.MapEventArgs args)
    {
        var realTimeMap = args.sender as RealTimeMap;
        realTimeMap.Geometric.DataFromGeoJSON.addFromFiles(new string[3]
        {
            $"{path}/geojson/points.json",
            $"{path}/geojson/polylines.json",
            $"{path}/geojson/polygons.json"
        });
    }

## Configuring Appearance from files

[more about upload data from GeoJSON files](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON/working%20with%20Files/GeoJSON%20from%20file)

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
 

### GeoJSON format - basic specifications

The GeoJSON data in the files must comply with [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946). This format is an array of JSON items. Also, RealTimeMap supports a format that allows customizing the appearance of the map items. This format is based on: [GeoJSON specification (RFC 7946)](https://www.rfc-editor.org/rfc/rfc7946)

Example RFC 7946 format:
		
  		[
		    {
		      "type": "Feature",
		      "geometry": {
		        "type": "Point",
		        "coordinates": [ 44.44695351120105, 26.096702416100246 ]
		      },
		      "properties": {
		        "name": "Piata Romana"
		      }
		    }
		]

In addition, RealTimeMap supports a JSON format that allows customizing the appearance of the map items. This format is based on RFC 7946. This format complies with the following template:

		{
			"name": "Name of Group Layer",
		 	"data": [], //RFC 7946 array
		  	"appearance": {} //appearance of RealTimeMap items
		}

#### About appearance 

Appearance can contain Leaflet specifications regarding marker icon, circleMarker symbol, polyline symbol, polygon symbol etc (Leaflet documentation). to which visibility can be added:

		    "visibilityZoomLevels": {
		      "minZoomLevel": 12,
		      "maxZoomLevel": 16
		    }

Leaflet documantation specifications:

1. for graphic (circleMarker) symbol:

| Property | Type | Descriotion |
|----|----|----|
| radius | int | circle radius |
| fillColor | string | fill color of circle |
| fillOpacity | double | fill opacity of circle |
| color | string | margin (line) color of cricle |
| opacity | double | margin (line) opacity |
| weight | int | margin (line) weight |


_similar with leaflet documentation_


2. for icon symbol:

| Property | Type | Descriotion |
|---|---|---|
| iconUrl | string | url of image icon |
| iconSize | int[2] | screen pixels of icon dimension |
| iconAnchor | int[2] | screen pixels of icon anchor |
| popupAnchor| int[2] | screen pixels of popup anchor |
| shadowUrl| string | screen pixels of shadow icon anchor |
| shadowSize| int[2] | screen pixels of shadow icon dimension |
| shadowAnchor| int[2] | url of shadow icon |

_similar with leaflet documentation_


3. symbol for polygon shape:


| Property | Type | Descriotion |
|----|----|----|
| fillColor | string | fill color of circle |
| fillOpacity | double | fill opacity of circle |
| color | string | margin (line) color of cricle |
| opacity | double | margin (line) opacity |
| weight | int | margin (line) weight |


_similar with leaflet documentation_

### JSON example for point(s)

Example of JSON format:

		{
		  "name": "Points of Interes",
		  "data": [
		    {
		      "type": "Feature",
		      "geometry": {
		        "type": "Point",
		        "coordinates": [ 44.44695351120105, 26.096702416100246 ]
		      },
		      "properties": {
		        "name": "Piata Romana"
		      }
		    }
		  ],
		  "appearance": {
		    "iconUrl": "http://localhost:5236/favicon.png",
		    "iconSize": [ 20, 20 ],
		    "iconAnchor": [ 10, 10 ],
		    "visibilityZoomLevels": {
		      "minZoomLevel": 12,
		      "maxZoomLevel": 16
		    }
		  }
		}


### JSON example for polygon(s)

Example of JSON format:

		{
		  "name": "Rezidential",
		  "data": [
		    {
		      "type": "Feature",
		      "geometry": {
		        "type": "Polygon",
		        "coordinates": [
		          [
		            [ 44.4432512, 26.0931846 ],
		            [ 44.4435381, 26.0945783 ],
		            [ 44.4438006, 26.0959206 ],
		            [ 44.4439288, 26.0965448 ],
		            [ 44.4444598, 26.0979042 ],
		            [ 44.4439044, 26.0981265 ],
		            [ 44.4436419, 26.0976905 ],
		            [ 44.4431657, 26.0972459 ],
		            [ 44.4427384, 26.0963396 ],
		            [ 44.4420181, 26.0941508 ]
		          ]
		        ]
		      },
		      "properties": {
		        "name": "commercial",
		        "population": 542
		
		      }
		    }
		  ],
		  "appearance": {
		    "color": "orange",
		    "opacity": 0.6,
		    "weight": 2,
		    "visibilityZoomLevels": {
		      "minZoomLevel": 14,
		      "maxZoomLevel": 18
		    }
		  }
		}

[example loading and config. from files](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON/config%20tooltip%20from%20file)

![GeoJSON@appearance20](https://github.com/ichim/LeafletForBlazor-NuGet/assets/8348463/81f4ea40-55b5-4dd5-9270-c2643aa47dd6)





