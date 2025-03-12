# Configuring chart on tooltip

Appearance from StreamPoint collection allow configuring tooltips. Starting with version 2.2.2.8, LeafletForBlazor allows configuring charts. 

To add a chart to the tooltip, you need to add (on RealTimeMap.PointTooltip()) the custom html element (LeafletForBlazor):

    content = "<chart/>"

> It is absolutely necessary that the items of the map (point, polygon or line) be uniquely identified by an attribute (property):

    content = "<chart id = ${uid}/>"

where: 

_uid is a property (field) of GeoJSON items._

Provided by https://cdn.jsdelivr.net/npm/chart.js
