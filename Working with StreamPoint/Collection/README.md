# Upload or add to StreamPoint collection

A good choice is to load the data on the OnAfterMapLoaded event of the RealTimeMap component


        <RealTimeMap height="calc(100vh - 6rem)" width="calc(100vw - 18rem)" OnAfterMapLoaded="@onAfterMapLoaded"></RealTimeMap>


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
