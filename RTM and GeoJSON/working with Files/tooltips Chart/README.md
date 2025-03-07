# Map Tooltip and Chart

GeoJSON files allow configuring tooltips. Starting with version 2.2.2.4, LeafletForBlazor allows configuring charts. To add a chart to the tooltip, you need to add the "<chart/>" element.

     "tooltip": {
       "content": "<chart id=${uid} data = ${graphic.values} render = ${graphic.render} labels=${graphic.labels} type = 'pie'></chart>",
       "opacity": 0.8,
       "permanent": false,
       "visibilityZoomLevels": {
         "minZoomLevel": 10,
         "maxZoomLevel": 20
       }
     }
