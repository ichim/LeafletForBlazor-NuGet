# 📍 StreamPoint collection

The `StreamPoint` collection maintains live synchronization between your data objects and their map representation:

| Property Change | Map Effect | Performance Feature |
|----|----|----|
| Coordinates | Point moves instantly | Cached for smooth animation |
| Appearance | Style updates immediately | Smart re-rendering |
| Timestamp | Time-based filtering | Temporal indexing |

Key characteristics:

✅ Real-time updates - Any property change triggers immediate map refresh

✅ Automatic positioning - Coordinate updates = map marker/svg/chart movement

✅ Visual consistency - Appearance changes = style updates

✅ Cached performance - Objects served from cache with live synchronization


The `StreamPoint` collection is hosted by @map.Geometric.Points and provides operating functionalities with a predefined but hierarchically extensible root data structure.

What does root data structure mean?

``StreamPoint`` has a predefined, mandatory structure without which these points cannot function correctly.

    public class StreamPoint : IStreamPoint, IStreamType
    {
        public Guid guid { get; set; }                                            //unique identifier
        public Coordinates coordinates { get; set; } = new Coordinates();         //WGS coordinates
        public object value { get; set; }                                         //this property allows hierarchical expansion with other attributes
        public DateTime timestamp { get; set; }                                   //data time, are often used in the MemoryCache mechanism
        public string? type { get; set; }                                         //allows for a classification of data. Often used for map appearance
    }

## Extending the StreamPoint class

To extend the StreamPoint class you need to create a new custom class:

        public class VehicleTracking
        {
                public double? speed { get; set; } = 0;
                public double? battery { get; set; } = 0;
                public int wifiLevel { get; set; } = 0;
                public double? fuel { get; set; } = 0;
                public double? altitude { get; set; } = 0;
                public double timeSpent { get; set; } = 0;
        }

This class is used to extend StreamPoint:

        StreamPoint point = new StreamPoint(){
                           coordinates = new Coordinates()
                           {
                               xy = new double[2] { 50.860847591747186,  4.227255449993002 }
                           },
                           guid = new Guid("00000000-0000-0000-0000-000000000001"),
                           type = "Industrial",
                           value = new VehicleTracking()
                           {
                              speed = 20,
                              battery = 4,
                              wifiLevel = 2,
                              fuel = 30, 
                              altitude = 120,
                           }
        
        };

## Add

The Add() method on @map.Geometric.Points is async:

     await map.Geometric.Points.Add(new List<StreamPoint>(){});

## Remove

The Remove() method on @map.Geometric.Points is async:

    await map.Geometric.Points.Remove();

## Update

The Update() method on @map.Geometric.Points is async:

    await map.Geometric.Points.Update(new List<StreamPoint>(){});

Example code:

         await map.Geometric.Points.Update(new List<StreamPoint>()
                     {

                             new StreamPoint()
                             {
                                 guid = point.guid,                //existing guide
                                 type = point.type,                //type can be changed
                                 timestamp = DateTime.Now,         //useful for the MemoryCache mechanism
                                 coordinates = new Coordinates()
                                 {
                                     xy = new double[2] { state.Position.Latitude, state.Position.Longitude }
                                 },
                                 value = new DroneTrak()
                                 {
                                     speed = state.Speed * 1000/(60*60),
                                     fuel = fuelClass( state.Fuel),
                                   altitude =Math.Abs( state.Altitude),
                                   battery = batteryLevel,
                                   wifiLevel =rand.Next(0,4)
            
                                 }
                             }

                        });
# 🎨 Appearance

Appearance is a method that accepts Expression<Func<T, bool>> predicates and allows filtering and applying different styles to the elements displayed in the map:

    await map.Geometric.Points.Appearance(e.type => e.type == "Market").SetStyle(...).SetLabel(...);


[more about Appearance](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/WASM/StreamPoint/Appearance/README.md#-appearance)


