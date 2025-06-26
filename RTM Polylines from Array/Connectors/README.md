# Connectors


With DisplayPolylinesFormArray you can add connectors. A connector is a polyline that can have:
- a single direction in the direction of the polyline or in the opposite direction -> one way connector
- two directions -> two ways connector


## One way connector

addConnector() method adds a polyline provided by an array of coordinates and a configurable arrow.

      double[,] polyline = new double[12, 2] {{ 44.44586931032441, 26.097146294088674 }, { 44.44567571771458, 26.096377445586192 }, { 44.44557322665131, 26.096160510467932 }, { 44.44542518267126, 26.09578087503316 }, { 44.44530219217061, 26.09554799080396 }, { 44.445135928272926, 26.095378912700124 }, { 44.44502660288366, 26.095200263212803 }, { 44.44493095375493, 26.094874850544517 }, { 44.44486034694202, 26.09453030700582 }, { 44.44465286263079, 26.093572916893123 }, { 44.44440775850324, 26.092709245635653 }, { 44.44427754378361, 26.09215134979953 }};
      await args.sender.Geometric.DisplayPolylinesFromArray.addConnector(
                                                                          polyline,start:1, 
                                                                          symbol: new RealTimeMap.PolylineSymbol() { color = "blue", weight = 2 }
                                                                          );

The start parameter allows you to configure the arrow position:
>start: 1 // this means that the arrow direction is a same of polyline
>start: 0 // this means that the arrow direction is opposite of polyline
>start: 2 // this means that the connector will be bidirectional (in both directions)
