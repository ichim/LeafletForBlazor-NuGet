
> StreamPoint is a LeafletForBlazor class created to optimize the display and analysis of real-time data. StreamPoint has a predefined structure (unique identifier, date, type). The value property of the StreamPoint class is of type object and allows the extension of its attributes.

# Working with Geometric.Points collection

The Geometric.Points collection allows update operations:
- upload - Loading an array of StreamPoint;
- add - Adding a StreamPoint or an array of StreamPoints
- delete - Deletes one or more StreamPoints from the Geometric.Points collection
- moveTo - Move a point or several points on the map (only coordinates are changed)
- update - Only the StreamPoint attributes are changed (type, timestamp and value properties)

## Input data source

The project has a list of StreamPoint items.

       public List<RealTimeMap.StreamPoint> pointsStart = new List<RealTimeMap.StreamPoint> {
          new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                type = "Intervention crew",
                value = "5 seats",
                latitude = 44.45028925827577,
                longitude =  26.10629452317551
            }
        };


_**latitude** and **longitude** properties are Web Mercator coordinate values._

_In this previous, the **value** property is of string type. The **value** property also supports objects defined by custom classes, if we have customized attributes._

_If the **timestamp** is missing, LeafletForBlazor will assign the current date_

_This collection has a static behavior._

## Upload data

Uploading a list of StreamPoint list:

        if (realTimeMap != null)
            await realTimeMap.Geometric.Points.upload(dataSource.pointsStart, true);


where:

- dataSource is:

       DataSource dataSource = new DataSource();

- the last parameter is newCollection:
  
  if it's missing, it means it's _false_. That is, the previous collection is kept;

            if(realTimeMap !=null)
                await realTimeMap.Geometric.Points.upload(dataSource.pointsStart);

## Add data

Expanding the existing collection:

        if (realTimeMap != null)
            await realTimeMap.Geometric.Points.add(dataSource.pointsMore.ToArray());

## Delete some points


        string[] guids = new string[2] { "18466d7f-0689-4b8e-a2ee-28e5cb27f86e", "28466d7f-0689-4b8e-a2ee-28e5cb28f86f"};
        if (realTimeMap != null)
            await realTimeMap.Geometric.Points.delete(guids);
    
## Delete all points


        if (realTimeMap != null)
            await realTimeMap.Geometric.Points.delete();


# Configuring StreamPoint Tooltip

You can configure tooltips for map items.

[Configurng tooltip example](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20StreamPoint/Tooltip)

# Configuring tooltips for hierarchical attribute data

StreamPoint elements can work with hierarchical data. This hierarchical data of StreamPoints can be displayed on tooltips.

[Configuring tooltip for hierachical attribute example](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20StreamPoint/Tooltip/RTM%20tooltip%20hierarchical%20attr)

# Configuring charts on tooltiop

StreamPoint elements can work with hierarchical data. This hierarchical data of StreamPoints can be used in displaying charts on tooltips.

[Configuring charts example](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20StreamPoint/Tooltip/tooltip%20chart)

   
# Clustering

You can choose to have the StreamPoint collection clustered in the map.

[more about](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20StreamPoint/Clustering#clustering)
