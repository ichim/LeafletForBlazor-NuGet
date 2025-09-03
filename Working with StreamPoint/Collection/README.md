# Upload or add to StreamPoint collection

A good choice is to load the data on the OnAfterMapLoaded event of the RealTimeMap component

Blazor page:

        <RealTimeMap height="calc(100vh - 6rem)" width="calc(100vw - 18rem)" OnAfterMapLoaded="@onAfterMapLoaded"></RealTimeMap>

Code block

        @code{
                 DataSource dataSource = new DataSource();//object with the data source
                 private async Task onAfterMapLoaded(RealTimeMap.MapEventArgs args)
                 {
                            
                 }
         }


## Upload data

Uploading a list of StreamPoint list:

        await args.sender.Geometric.Points.upload(dataSource.pointsStart, true);


where:

- dataSource is:

       DataSource dataSource = new DataSource();

- the last parameter is newCollection:
  
  if it's missing, it means it's _false_. That is, the previous collection is kept;

            if(realTimeMap !=null)
                await args.sender.Geometric.Points.upload(dataSource.pointsStart);

## Add data

Expanding the existing collection:

     foreach (var item in dataSource.pointsMore)
     {
         await args.sender.Geometric.Points.add(item);
     }


The complete example:

Blazor page:

        <RealTimeMap height="calc(100vh - 6rem)" width="calc(100vw - 18rem)" OnAfterMapLoaded="@onAfterMapLoaded"></RealTimeMap>

Code block:

        @code{
            DataSource dataSource = new DataSource();
            private async Task onAfterMapLoaded(RealTimeMap.MapEventArgs args)
            {
                // Initialize the data source with some points
                await args.sender.Geometric.Points.upload(dataSource.pointsStart);
                // Add more points to the map
                foreach (var item in dataSource.pointsMore)
                {
                    await args.sender.Geometric.Points.add(item);
                }
            }
        }

# Delete all 

To delete all points you can call the delete() method without any arguments.

Blazor page:

         <RealTimeMap @ref="realTimeMap" height="calc(100vh - 6rem)" width="calc(100vw - 18rem)" OnAfterMapLoaded="@onAfterMapLoaded"></RealTimeMap>

Code block:

        @code {
            RealTimeMap realTimeMap ;
                    private void onClick(){
                            realTimeMap.Geometric.Points.delete();
                    }
            }

Blazor page:

        <button class="btn btn-primary" @onclick="() => realTimeMap.Geometric.Points.delete()">Delete All Points</button>

# Delete some StreamPoints

You must specify an array of guids (string):

         if(realTimeMap!=null)
             await realTimeMap.Geometric.Points.delete(new string[2] { "18466d7f-0689-4b8e-a2ee-28e5cb27f86e", "28466d7f-0689-4b8e-a2ee-28e5cb28f86f" });

# Move To

A StreamPoint (or more) can be moved on the map by updating the coordinates. The method accepts a single StreamPoint or an array of StreamPoints:

1. Single point .Geometric.Points.moveTo(new StreamPoint(){});
2. Multiple points .Geometric.Points.moveTo(StreamPoint[]);



           List<RealTimeMap.StreamPoint> newPositions = new List<RealTimeMap.StreamPoint>()
           {
               new RealTimeMap.StreamPoint() { guid = Guid.Parse("18466d7f-0689-4b8e-a2ee-28e5cb27f86e"),                 // existing guid
                                                   latitude = 44.94315750985839,  longitude =  26.045736793436422 },      // new position
               new RealTimeMap.StreamPoint(){ guid = Guid.Parse("28466d7f-0689-4b8e-a2ee-28e5cb28f86f"),                  // existing guid               
                                                   latitude = 45.15302298583691, longitude = 26.829259910543875 },        // new position
           };
           if (realTimeMap != null)
               await realTimeMap.Geometric.Points.moveTo(newPositions.ToArray());

# Update

Update is a method that allows updating data related to type, datetime, value. Update does not allow updating coordinates. 

Blazor page:

        <RealTimeMap @ref="realTimeMap"></RealTimeMap>

Code block:

        await realTimeMap!.Geometric.Points.update(new StreamPoint(){
                guid = Guid.Parse("18466d7f-0689-4b8e-a2ee-28e5cb27f86e"), 
                type = "new type for this StreamPoint"});

To update coordinates you must use [moveTo](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/Working%20with%20StreamPoint/Collection/README.md#move-to).

## Update type and Appearance

Changing the type property of a StreamPoint will have the effect of changing its appearance.

The Appearance can be configured on the Load event of the RealTimeMap component.

Updating the type property, anywhere in the code, will have the effect of updating the Appearance in the Map.


[example code](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/Working%20with%20StreamPoint/Collection#update).


