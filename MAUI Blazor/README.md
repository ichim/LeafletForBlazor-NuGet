# .NET MAUI Blazor Hybrid App

Adding to _Imports.razor

    @using LeafletForBlazor
    @using static LeafletForBlazor.Map
    @using static LeafletForBlazor.techs.maps.Leaflet


Adding the Map component:

    <Map
         height="calc(100vh - 2rem)"
         width="calc(100vw - 2rem)"
         />


Default configuration parameters:


    @code {
            LoadParameters loadParameters = new LoadParameters()
            {
                location = new Location()                                               //Center of the Map View
                {
                    latitude = 45.2852939016828,
                    longitude = 27.972121962159605
                },
                zoomLevel = 14,
                mapControls = new MapControls()
                {
                    layerList = new LayerList()                                         //LayersList control
                    {
                        position = Position.topRight
                    },
                    scaleBar = new ScaleBar()                                           //Map Scale Bar
                    {
                        position = Position.bottomRight,
                        unitOfScaleBar = UnitOfScaleBar.metric
                    },
                }
            };
         }

Settings Map parameters:


    <Map loadParameters="@loadParameters"
         height="calc(100vh - 4rem)"
         width="calc(100vw - 2rem)" />

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
