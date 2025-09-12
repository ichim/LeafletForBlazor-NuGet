# Clustering

You can choose to have the StreamPoint collection clustered in the map. To do this, you must set the property to true:

    realTimeMap.Geometric.Points.clusteringAfterCollectionUpdate = true;

![clustering20](https://github.com/user-attachments/assets/724efa08-9a5c-4f60-a756-efb93406712b)


This property must be set before updating the StreamPoint collection (add, upload).

# Configuration parameters
You can configure the display/allocation of clusters using several parameters

1. Show coverage on hover

| Parameter | Type |
| ---- | ---- |
| showCoverageOnHover | boolean |

2. Spiderfy markers when zoomed in

| Parameter | Type |
| ---- | ---- |
| spiderfyOnMaxZoom | boolean |

3. Zoom to bounds when clicking on a cluster

| Parameter | Type |
| ---- | ---- |
| zoomToBoundsOnClick | boolean |

4. Maximum radius of a cluster when it is not zoomed in px

| Parameter | Type |
| ---- | ---- |
| maxClusterRadius | integer / pixels |


Example code:

Blazor page:

    <RealTimeMap height="calc(100vh - 6rem)" width="calc(100vw - 18rem)" OnAfterMapLoaded="@onAfterMapLoaded"></RealTimeMap>

Code block:

     private async Task onAfterMapLoaded(RealTimeMap.MapEventArgs args)
     {
         // This method can be used to perform actions after the map has loaded
         args.sender.Geometric.Points.clusteringAfterCollectionUpdate = true;
         args.sender.Geometric.Points.clusteringConfiguration = new ClusteringConfiguration()
             {
                 showCoverageOnHover = true,     // Show coverage on hover
                 spiderfyOnMaxZoom = true,       // Spiderfy markers when zoomed in
                 zoomToBoundsOnClick = false,    // Zoom to bounds when clicking on a cluster
                 maxClusterRadius = 120,         // Maximum radius of a cluster when it is not zoomed in px
             }
     }


# Working with Cluster Click Event

The .Geometric.Points class provides the OnClusterClick event.

Add new Event method:

    args.sender.Geometric.Points.OnClusterClick += onClusterClick;

 Event method definition:

    public void onClusterClick(object? sender, ClusteringEventArgs args)
    {
        // Handle the cluster click event
        //you receive bounds of the cluster, location of mouse click and guids
        
    }

# Clustering and moveTo method

The moveTo method allows changing the position of a StreamPoint in the map. Once the position of a StreamPoint is updated and the clustering is updated.

Working with StreamPoint/Clustering/clustering & moveTo

