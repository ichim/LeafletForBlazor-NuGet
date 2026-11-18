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
            ...
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
