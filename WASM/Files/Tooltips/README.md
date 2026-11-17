# Workking with tooltips

Configure Leaflet tooltip behavior in the JSON  style -> tooltip GeoJSON file. Set content to the HTML or text displayed in the tooltip, then use properties to pass Leaflet tooltip options: 
1. **direction** controls its placement;
2. **offset** adjusts its position;
3. **permanent** keeps it visible;
4. **sticky** makes it follow the cursor.

Set interactive to allow pointer interaction with the tooltip, and className to apply a custom CSS class. The surrounding style properties configure the feature’s appearance, while style.tooltip defines the tooltip.

Place the JSON item **tooltip** directly in the style:
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
Additionally, the tooltip content allows for the configuration of `template literals` (JavaScript syntax, but without the "`" characters).

For example:

```JSON
          "style": {
            "title": "Area",
            "color": "green",
            "fillColor": "yellow",
            "weight": 4,
            "opacity": 1,
            "tooltip": {
              "content": "<h8>${name} Area</h8></br><img src=${urlImage} width='80' height='90' alt=${name} Image />",
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
Where name and urlImage are values ​​from properties:
```JSON
    {
      "type": "Feature",
      "geometry": {
        "type": "Polygon",
        "coordinates": [
          [
            [26.09835836189222,  44.443920495124345 ],
            ...
          ]
        ]
      },
      "properties": {
        "name": "Commercial",
        "address": "28 Arthur Verona St",
        "urlImage": "https://upload.wikimedia.org/wikipedia/commons/6/6b/Bucuresti%2C_Romania%2C_Piata_Romana_nr._6_%28ASE%29_%28detaliu_5%29%3B_B-II-m-B-19579.JPG"
      }
    },
```

<img width="3795" height="2059" alt="image" src="https://github.com/user-attachments/assets/a44b54a9-b164-4639-8ed8-dcd00ad90e7b" />
