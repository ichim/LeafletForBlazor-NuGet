# Map Tooltip and Template Literals

The `content` parameter of the Tooltip element allows the use of Template Literals. The Template Literal definition, written in C# and passed via `Invoke` to the Leaflet.js functions, uses `"` instead of `` ` ``.

The tooltip content is defined in JSON and can bind to values from the properties member of each GeoJSON feature (point, line, or polygon).

Thus, we can take the following GeoJSON definition as an example:

**Polygon**
```JSON
    {
      "type": "Feature",
      "geometry": {
        "type": "Polygon",
        "coordinates": [
          [
            [ 26.0931846, 44.4432512 ],
            [ 26.0945783, 44.4435381 ],
            [ 26.0959206, 44.4438006 ],
           ...
          ]
        ]
      },
      "properties": {
        "name": "Commercial",
        "address": "123 Amzei Square St",
        "urlImage": "https://upload.wikimedia.org/wikipedia/commons/4/41/9_Strada_Biserica_Amzei%2C_Bucharest_%2801%29.jpg"
      }
    },
```
In this example, the fields available for binding to tooltip.content are:
 - "name": "Commercial",
 - "address": "123 Amzei Square St",
 - "urlImage": "https://upload.wikimedia.org/..."

For example, the content in the tooltip could be:

```JSON
    "content": "<h8>${name} Area</h8></br><img src=${urlImage} width='80' height='90' alt=${name} Image />"
```
