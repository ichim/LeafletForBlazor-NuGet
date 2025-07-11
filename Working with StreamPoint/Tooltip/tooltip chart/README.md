# Configuring chart on tooltip

Appearance from StreamPoint collection allow configuring tooltips. Starting with version 2.2.2.8, LeafletForBlazor allows configuring charts. 

To add a chart to the tooltip, you need to add (on RealTimeMap.PointTooltip()) the custom html element (LeafletForBlazor):

    content = "<chart/>"

> It is absolutely necessary that the items of the map (point, polygon or line) be uniquely identified by an attribute (property):

    content = "<chart id = ${uid}/>"

where: 

_uid is a property (field) of GeoJSON items._

Provided by https://cdn.jsdelivr.net/npm/chart.js

        var realTimeMap = args.sender as RealTimeMap;
        realTimeMap.Geometric.Points.Appearance(item => item.type != "asked for help").pattern = new RealTimeMap.PointTooltip()
            {
                content = "<chart id=${guid} data = ${value.values} render = ${value.render} labels=${value.labels} type = 'pie' style='width:180px; height:180px; background-color:#ececed' options = '{\"plugins\":{\"legend\": {\"display\": true,\"labels\": {\"color\": \"gray\"},\"position\":\"bottom\"}}}'></chart>"
            };
        await realTimeMap.Geometric.Points.upload(new streamPieChart.data.InputData().input);
