# Upload data from GeoJSON files

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

 ![GeoJSON@appearance20](https://github.com/ichim/LeafletForBlazor-NuGet/assets/8348463/81f4ea40-55b5-4dd5-9270-c2643aa47dd6)

## GeoJSON format - basic specifications

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

Also, the format also supports symbology (old format) instead of appearance.

		{
			"name": "Name of Group Layer",
		 	"data": [], //RFC 7946 array
		  	"symbology": {} //old format - appearance of RealTimeMap items
		}


### About appearance 

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

4. symbol for polyline shape:


| Property | Type | Descriotion |
|----|----|----|
| color | string | color of line |
| opacity | double | opacity of line |
| weight | int | weight of line |


_similar with leaflet documentation_


# JSON formats of data files

Below I will show you several examples of files that can be loaded by RealTimeMap.

## For geometric points

Example of JSON format for geometric points:

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


Points will be displayed using the default icon from a Blazor application. The display will only be between the scales level 12 and 16
