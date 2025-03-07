# Map Tooltip and Chart

GeoJSON files allow configuring tooltips. Starting with version 2.2.2.4, LeafletForBlazor allows configuring charts. To add a chart to the tooltip, you need to add the custom html element (LeafletForBlazor):

     <chart/>

> It is absolutely necessary that the items of the map (point, polygon or line) be uniquely identified by an attribute (property):

     <chart id = ${uid}/>

where: 

uid is a property (field) of GeoJSON items.

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
| type | is a string that defines the chart type | pie, bar, line, doughnut etc | is mandatory |
| style | the particularization of the appearance and is similar to that of the div | not mandatory |
| [options](#options-settings) | in accordance with https://www.chartjs.org/docs/latest/ | not mandatory |

## Options settings

These are settings according to the documentation: https://www.chartjs.org/docs/latest/

     "<chart id = ${uid} data = ${values} type = 'pie' options = '{\"plugins\":{\"legend\": {\"display\": true,\"position\":\"bottom\"}}}'></chart>"

where:

| Parameter | Description | Significant |
| --- | --- | --- |
| [plugins](#plugins) | to customize or change the default behavior of a chart. Find more [Chart.js documentation](https://www.chartjs.org/docs/latest/developers/plugins.html) | not mandatory |

## Plugins

Provide you the possibility to customize the chart and its behavior:

| Parameter | Description | Significant |
| --- | --- | --- |
| [legend](#legend) | you can customize the display of the chart legend. Find more [Chart.js documentation](https://www.chartjs.org/docs/latest/configuration/legend.html) | not mandatory |

### Legend

| Parameter | Description | Significant |
| --- | --- | --- |
| display | boolean/and can have the values: true or false | not mandatory |
| position | string/and can have the values: 'top', 'bottom', 'left', 'right', 'chartArea' | not mandatory |

