# Workking with tooltips

Configure Leaflet tooltip behavior in the JSON  style -> tooltip GeoJSON file. Set content to the HTML or text displayed in the tooltip, then use properties to pass Leaflet tooltip options: 
1. **direction** controls its placement;
2. **offset** adjusts its position;
3. **permanent** keeps it visible;
4. **sticky** makes it follow the cursor.

Set interactive to allow pointer interaction with the tooltip, and className to apply a custom CSS class. The surrounding style properties configure the feature’s appearance, while style.tooltip defines the tooltip.

```JSON
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
```
