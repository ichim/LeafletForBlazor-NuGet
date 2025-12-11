# Working with files

> All formats used in the code examples are based on the format RFC 7946.
> 


|Geometry|Structure|Format|
|----|----|----|
|Point| {"type": "Feature","geometry": {"type": "Point","coordinates": [, ]}}|[RFC 7946](https://datatracker.ietf.org/doc/html/rfc7946)|
|Polyline|{"type": "Feature","geometry": {"type": "Polyline","coordinates": [[[, ]]]}|[RFC 7946](https://datatracker.ietf.org/doc/html/rfc7946)|
|Polygon| {"type": "Feature","geometry": {"type": "Polygon","coordinates": [[[, ]]]}}|[RFC 7946](https://datatracker.ietf.org/doc/html/rfc7946)|
|Circle| {"type": "Feature","geometry": {"type": "Circle","coordinates": [, ], "radius":2}}|[RFC 7946](https://datatracker.ietf.org/doc/html/rfc7946)|


[Pure RFC 7946 format example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20files/RFC%207946%20formats)

## RFC 7946 format and unique symbol

Is an RFC 7946 format supplemented with the definition of a unique symbol.

    {
      "name": "Points of Interes",     //An item will appear in the List Control
      "data": [RFC 7946],              //RFC 7946 compliant data format
      "appearance": {                  //unique symbol definition
        "color": "Red",
        "radius": 8,
        "opacity": 0.6,
        "weight": 2,
        "visibilityZoomLevels": {
          "minZoomLevel": 12,
          "maxZoomLevel": 16
        }
      }
    }


Example code:

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
        "color": "Red",
        "radius": 8,
        "opacity": 0.6,
        "weight": 2,
        "visibilityZoomLevels": {
          "minZoomLevel": 12,
          "maxZoomLevel": 16
        }
      }
    }


[RFC 7946 and unique symbol example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20files/RFC%207946%20single%20Symbol)

## RFC 7946 format and switch symbol(s) statement

Is an RFC 7946 format supplemented with switch symbols statement.

    {
      "name": "Area",                        //An item will appear in the List Control
      "data": [RFC 7946],                    //RFC 7946 compliant data formatRFC 7946 compliant data format
      "appearance": {                        //appearance and switch (statement) symbols JSON definition
        "switch": {
          "fieldName": "name",
          "cases": [
            {
              "commercial": {
                "color": "green",
                "opacity": 0.6,
                "weight": 1
              }
            }
          ],
          "default": {
            "color": "black",
            "opacity": 0.8,
            "fillColor": "gray",
            "fillOpacity": 0.6,
            "weight": 1
          }
        }
      }
    }


Example code:

    {
      "name": "Area",
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
        "switch": {
          "fieldName": "name",
          "cases": [
            {
              "commercial": {
                "color": "green",
                "opacity": 0.6,
                "weight": 1
              }
            },
            {
              "residential": {
                "color": "magenta",
                "opacity": 0.8,
                "weight": 1
              }
            },
            {
              "cultural": {
                "color": "yellow",
                "opacity": 0.8,
                "weight": 1
              }
            }
          ],
          "default": {
            "color": "black",
            "opacity": 0.8,
            "fillColor": "gray",
            "fillOpacity": 0.6,
            "weight": 1
          }
        }
      }
    }

[RFC 7946 and switch symbol(s) statement example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20files/RFC%207946%20Switch%20Symbol)

