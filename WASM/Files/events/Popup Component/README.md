# File and MapPopup Component

```JSON
﻿{
  "data": [
    {
      "type": "Feature",
      "geometry": {
        "type": "Polygon",
        "coordinates": [
          [
            [ 26.0931846, 44.4432512 ],
            [ 26.0945783, 44.4435381 ],
            [ 26.0959206, 44.4438006 ],
            [ 26.0965448, 44.4439288 ],
            [ 26.0979042, 44.4444598 ],
            [ 26.0981265, 44.4439044 ],
            [ 26.0976905, 44.4436419 ],
            [ 26.0972459, 44.4431657 ],
            [ 26.0963396, 44.4427384 ],
            [ 26.0941508, 44.4420181 ],
            [ 26.0931846, 44.4432512 ]
          ]
        ]
      },
      "properties": {
        "name": "commercial"
      }
    }
  ],
  "appearance": {
    "switch": {
      "fieldName": "name",
      "classes": [
        {
          "fieldValue": "commercial",
          "style": {
            "title": "Comercial Area",
            "color": "indigo",
            "fillColor": "orange",
            "weight": 2,
            "opacity": 0.8,
            "tooltip": {
              "content": "<label>Commercial</label>",
              "properties": {
                "direction": "top",
                "offset": [ 0, -10 ],
                "permanent": true,
                "sticky": false,
                "interactive": true,
                "className": "info-tooltip"
              }
            }
          }
        },
        {
          "fieldValue": "residential",
          "style": {
            "title": "Residential Area",
            "color": "green",
            "fillColor": "yellow",
            "weight": 4,
            "opacity": 1,
            "tooltip": {
              "content": "<label>Residential</label>",
              "properties": {
                "direction": "top",
                "offset": [ 0, -10 ],
                "permanent": true,
                "sticky": false,
                "interactive": true,
                "className": "info-tooltip"
              }
            }
          }
        }
      ],
      "default": {
        "title": "Other Area",
        "color": "gray",
        "weight": 2,
        "opacity": 0.8
      }
    }
  }
}
```
