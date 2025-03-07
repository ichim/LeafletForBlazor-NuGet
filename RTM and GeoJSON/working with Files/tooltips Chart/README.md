# Map Tooltip and Chart

GeoJSON files allow configuring tooltips. Starting with version 2.2.2.4, LeafletForBlazor allows configuring charts. To add a chart to the tooltip, you need to add the custom html element (LeafletForBlazor):

     <chart/>

Provided by https://cdn.jsdelivr.net/npm/chart.js

     "tooltip": {
       "content": "<chart id=${uid} data = ${graphic.values} render = ${graphic.render} labels=${graphic.labels} type = 'pie'></chart>",
       "opacity": 0.8,
       "permanent": false,
       "visibilityZoomLevels": {
         "minZoomLevel": 10,
         "maxZoomLevel": 20
       }
     }

## Setting up a chart

To configure a chart you must set the following parameters:

| Parameter | Description | Significant |
| --- | --- | --- |
| id | Unique identifier for the map element (point, polygon or line) | Setting is mandatory |
| data | Is an array of numeric values ​​that will be displayed in the chart | is mandatory |
