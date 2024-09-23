# Appearance based on switch/cases

You can create distinct _symbolization classes_ based on the properties of GeoJSON file items.
How appearance can be customized by defining distinct classes?

It can be done using a JSON switch object of *appearance* item:

    {
        switch: {
          "fieldName": "name",  //field name of item properties 
          "cases": []           //value: {}
          "default": {}         //symbol
    }

What is the structure of a _cases_ array item?

    "<property value>": {
                        "color": "green",    //appearance symbol property
                        "opacity": 0.6,      //appearance symbol property
                        "weight": 8          //appearance symbol property
                      }

This appearance symbol can be for: points, polylines or polygons in accordance with the geometry of the geojson items (geometry.type).

#### Example code

        {
          "name": "Streets",
          "data": [
            {
              "type": "Feature",
              "geometry": {
                "type": "Polyline",
                "coordinates": [
                  [
                    [ 44.44586931032441, 26.097146294088674 ],
                    [ 44.44567571771458, 26.096377445586192 ],
                    [ 44.44557322665131, 26.096160510467932 ],
                    [ 44.44542518267126, 26.09578087503316 ]
                  ]
                ]
              },
              "properties": {
                "name": "Biserica Amzei"
              }
            }
          ],
          "appearance": {
            "switch": {
              "fieldName": "name",
              "cases": [
                {
                  "Biserica Amzei": {
                    "color": "green",
                    "opacity": 0.6,
                    "weight": 8
                  }
                }
              ],
              "default": {
                "color": "gray",
                "opacity": 0.6,
                "weight": 8
              }
            }
          }
        }

## Shapes Appearance symbols

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


# More about working with GeoJSON files

<table>
    <tr>
        <td> <b>Example</b> </td>
        <td><b>Description</b></td>
    </tr>
    <tr>
        <td><a href = "https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON/working%20with%20Files/Appearance%20switch%20case">Appearance and switch/cases symbology</a></td>
        <td><font size = "2px">switch/cases allows you to distinctly symbolize shapes based on properties</font></td>
    </tr>
    <tr>
        <td><a href = "https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/RTM%20and%20GeoJSON/working%20with%20Files/Appearance%20switch%20icons">Appearance switch/cases and icons</a></td>
        <td><font size = "2px">Working with switch/cases and png icons</font></td>
    </tr>
</table>
