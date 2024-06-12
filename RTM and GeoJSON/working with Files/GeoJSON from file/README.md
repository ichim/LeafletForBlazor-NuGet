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

### JSON example

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
