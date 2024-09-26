# Appearance icons (marker) based on switch/cases

You can create distinct _symbolization classes_ based on the properties of GeoJSON file items.
How appearance can be customized by defining distinct classes?

It can be done using a JSON switch object of *appearance* item:

    {
        switch: {
          "fieldName": "name",  //field name of item properties 
          "cases": []           //value: {}
          "default": {}         //symbol
    }

What is the structure of a _cases_ array item based on _icon marker_?

    "<property value>": {
                           "iconUrl": "http://localhost:5292/icons/location2.png",  //icon url - transparency png
                           "iconSize": [ 48, 48 ],                                  //icon size - pixels
                           "iconAnchor": [ 24, 24 ]                                 //icon anchor based on bottom-left corner - pixels
                        }

This appearance symbol(icon) can be for point shapes.

#### Example code

        {
          "name": "Streets",
          "data": [
                     {
                       "type": "Feature",
                       "geometry": {
                         "type": "Point",
                         "coordinates": [ 44.44930129064185, 26.10272426811774 ]
                       },
                       "properties": {
                         "name": "market"
                       }
                   }
                  ],
          "appearance": {
            "switch": {
              "fieldName": "name",
              "cases": [
                         {
                          "market": {
                            "iconUrl": "http://localhost:5292/icons/market.png",
                            "iconSize": [ 48, 48 ],
                            "iconAnchor": [ 24, 24 ]
                          }
                        }
              ],
              "default": {
                "color": "gray",
                "opacity": 0.6,
                "weight": 8
              }
            },
            "visibilityZoomLevels": {
                                        "minZoomLevel": 12,
                                        "maxZoomLevel": 16
                                    }
          }
        }

## Shapes Appearance icon(s) properties

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
