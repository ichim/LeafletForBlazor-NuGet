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
