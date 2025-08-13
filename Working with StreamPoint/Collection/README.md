# Upload or add to StreamPoint collection

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
