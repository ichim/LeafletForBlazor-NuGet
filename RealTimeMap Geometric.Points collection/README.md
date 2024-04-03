# Working with Geometric.Points collection

The Geometric.Points collection allows update operations:
- upload - Loading an array of StreamPoint;
- add - Adding a StreamPoint or an array of StreamPoints
- delete - Deletes one or more StreamPoints from the Geometric.Points collection
- moveTo - Move a point or several points on the map (only coordinates are changed)
- update - Only the StreamPoint attributes are changed (type, timestamp and value properties)

## Input data source

The project has a list of StreamPoint items.

       public List<RealTimeMap.StreamPoint> points = new List<RealTimeMap.StreamPoint> {
          new RealTimeMap.StreamPoint()
            {
                guid = Guid.NewGuid(),
                type = "Ambulance",
                value = "with a doctor",
                latitude = 44.45028925827577,
                longitude =  26.10629452317551
            }
        };
