# Connectors


With DisplayPolylinesFormArray you can add connectors. A connector is a polyline that can have:
- a single direction in the direction of the polyline or in the opposite direction -> one way connector
- two directions -> two ways connector


## One way connector

addConnector() method adds a polyline provided by an array of coordinates and a configurable arrow:

      double[,] polyline = new double[12, 2] {{ 44.44586931032441, 26.097146294088674 }, { 44.44567571771458, 26.096377445586192 }, { 44.44557322665131, 26.096160510467932 }, { 44.44542518267126, 26.09578087503316 }, { 44.44530219217061, 26.09554799080396 }, { 44.445135928272926, 26.095378912700124 }, { 44.44502660288366, 26.095200263212803 }, { 44.44493095375493, 26.094874850544517 }, { 44.44486034694202, 26.09453030700582 }, { 44.44465286263079, 26.093572916893123 }, { 44.44440775850324, 26.092709245635653 }, { 44.44427754378361, 26.09215134979953 }};
      await args.sender.Geometric.DisplayPolylinesFromArray.addConnector(
                                                                          polyline,start:1, //direction is a same of polyline
                                                                          symbol: new RealTimeMap.PolylineSymbol() { color = "blue", weight = 2 }
                                                                          );

The start parameter allows you to configure the arrow position:

>  start: 1 // this means that the arrow direction is a same of polyline
>
>  start: 0 // this means that the arrow direction is opposite of polyline

![image](https://github.com/user-attachments/assets/4eb3a1d6-a075-433e-8ded-ec96babbdb36)


## Two ways connector

addConnector() method adds a polyline provided by an array of coordinates and a configurable arrow:


      double[,] polyline = new double[12, 2] {{ 44.44586931032441, 26.097146294088674 }, { 44.44567571771458, 26.096377445586192 }, { 44.44557322665131, 26.096160510467932 }, { 44.44542518267126, 26.09578087503316 }, { 44.44530219217061, 26.09554799080396 }, { 44.445135928272926, 26.095378912700124 }, { 44.44502660288366, 26.095200263212803 }, { 44.44493095375493, 26.094874850544517 }, { 44.44486034694202, 26.09453030700582 }, { 44.44465286263079, 26.093572916893123 }, { 44.44440775850324, 26.092709245635653 }, { 44.44427754378361, 26.09215134979953 }};
      await args.sender.Geometric.DisplayPolylinesFromArray.addConnector(
                                                                          polyline,start:2, 
                                                                          symbol: new RealTimeMap.PolylineSymbol() { color = "blue", weight = 2 }
                                                                          );



>  start: 2 // this means that the connector will be bidirectional (in both directions)

![image](https://github.com/user-attachments/assets/4e9796c6-5645-4511-b757-711d0663cbf1)

## Configurable connector arrow

The addConnector() method allows you to customize the arrow through two parameters: the angle of inclination and the length of the lines that form the arrow.

> length - the length of the lines that make up the arrow, given in meters;
> 
> radianAngle - the angle of inclination that makes up the arrow, given in radians

      double[,] polyline = new double[12, 2] {{ 44.44586931032441, 26.097146294088674 }, { 44.44567571771458, 26.096377445586192 }, { 44.44557322665131, 26.096160510467932 }, { 44.44542518267126, 26.09578087503316 }, { 44.44530219217061, 26.09554799080396 }, { 44.445135928272926, 26.095378912700124 }, { 44.44502660288366, 26.095200263212803 }, { 44.44493095375493, 26.094874850544517 }, { 44.44486034694202, 26.09453030700582 }, { 44.44465286263079, 26.093572916893123 }, { 44.44440775850324, 26.092709245635653 }, { 44.44427754378361, 26.09215134979953 }};
      await args.sender.Geometric.DisplayPolylinesFromArray.addConnector(
                                                                        polyline, 
                                                                        start: 1, 
                                                                        length:42,        //meters
                                                                        radianAngle:0.22, //radians
                                                                        symbol: new RealTimeMap.PolylineSymbol() { color = "red", weight = 2 }
                                                                        );

![image](https://github.com/user-attachments/assets/f332ef07-771b-4989-8a39-f9023eaab9c8)

