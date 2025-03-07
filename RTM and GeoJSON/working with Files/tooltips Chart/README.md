# Map Tooltip and Chart

GeoJSON files allow configuring tooltips. Starting with version 2.2.2.4, LeafletForBlazor allows configuring charts. To add a chart to the tooltip, you need to add the custom html element (LeafletForBlazor):

     <chart/>

Provided by https://cdn.jsdelivr.net/npm/chart.js
          
          {
               "name": "Name of layer",
               "data": [],               //GeoJSON data specification / RFC 7946 - https://www.rfc-editor.org/rfc/rfc7946
               "appearance": {
               ...
                    "tooltip": {
                      "content": "<chart id=${uid} data = ${graphic.values} render = ${graphic.render} labels=${graphic.labels} type = 'pie'></chart>",
                      "opacity": 0.8,
                      "permanent": false,
                      "visibilityZoomLevels": {
                        "minZoomLevel": 10,
                        "maxZoomLevel": 20
                      }
                    }
               }
          }

## Basic settings

To configure a chart you must set the following parameters:

| Parameter | Description | Significant |
| --- | --- | --- |
| id | Unique identifier for the map element (point, polygon or line) | Setting is mandatory |
| data | Is an array of numeric values ​​that will be displayed in the chart | is mandatory |
| render | is an array of strings representing display colors | not mandatory |
| labels | is an array of strings representing legend labels | not mandatory |
| type | is a string that defines the chart type | pie, bar, line, doughnut etc |
| [options](#options-settings) | in accordance with https://www.chartjs.org/docs/latest/ | not mandatory |

## Options settings

These are settings according to the documentation: https://www.chartjs.org/docs/latest/




