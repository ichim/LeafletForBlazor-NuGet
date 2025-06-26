# Connectors


With DisplayPolylinesFormArray you can add connectors. A connector is a polyline that can have:
- a single direction in the direction of the polyline or in the opposite direction -> one way connector
- two directions -> two ways connector


## One way connector




await args.sender.Geometric.DisplayPolylinesFromArray.addConnector(polyline,start:1, symbol: new RealTimeMap.PolylineSymbol() { color = "blue", weight = 2 });
