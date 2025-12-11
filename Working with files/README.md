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
      "name": "Points of Interes",     //List Control
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


[RFC 7946 and unique symbol example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20files/RFC%207946%20single%20Symbol)

## RFC 7946 format and switch symbol(s) statement

Is an RFC 7946 format supplemented with switch symbols statement.

[RFC 7946 and switch symbol(s) statement example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20files/RFC%207946%20Switch%20Symbol)

