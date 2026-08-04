# 📍 StreamPoint collection

`StreamPoint` provides a robust, intentionally-designed foundation for Blazor GIS applications. Its carefully crafted attributes support essential mapping functionality while maintaining extensibility for domain-specific requirements. The architecture enables efficient caching, spatial operations, and real-time updates—critical capabilities for modern geographic applications.

On another note, the `StreamPoint` collection maintains live synchronization between your data objects and their map representation:

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

### StreamPoint: a Flexible, Extensible Map Point Definition

StreamPoint is a foundational data model designed for geographic information systems (GIS) in Blazor applications. It provides a standardized, yet extensible structure for representing dynamic map points with real-time synchronization capabilities.

#### Core Architecture

    public class StreamPoint : IStreamPoint, IStreamType
    {
        public Guid guid { get; set; }                    // Unique identifier for point tracking
        public Coordinates coordinates { get; set; }      // WGS84 geographic coordinates
        public object value { get; set; }                 // Extensible property for domain-specific data
        public DateTime timestamp { get; set; }           // Temporal indexing and cache management
        public string? type { get; set; }                 // Classification for layered visualization
    }

Where:

1. `guid` - Identity Management

   Purpose: Uniquely identifies each point across the application lifecycle
   
   Use Case: Tracking, updates, and synchronization operations
   
   Implementation: Standard Guid for distributed system compatibility
   
1. `coordinates` - Geographic Positioning

   Purpose: Defines the spatial location using WGS84 standard

    Use Case: Map rendering, spatial queries, and distance calculations

    Implementation: Coordinates class encapsulating latitude/longitude logic

1. `type` - Classification & Layering

    Purpose: Categorizes points for visual organization and filtering

    Use Case:    Layer-based map display (e.g., "Industrial", "Residential", "Commercial"), Style application based on classification, Dynamic filtering in UI components

1. `timestamp` - Temporal Context & Caching

   Purpose: Provides temporal dimension for time-series analysis

   Use Case: MemoryCache integration for performance optimization, Time-based filtering and aggregation, Historical data tracking and versioning

1. `value` - Extensible Domain Model

   Purpose: Enables type-safe extension for domain-specific attributes

    Use Case: Custom data attachment without modifying core structure

    Design Pattern: Open/Closed Principle implementation

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

#### Extension Example: Vehicle Tracking System

The value property enables seamless integration of domain-specific models:

        public class VehicleTracking
        {
            public double? speed { get; set; }        // Velocity in km/h
            public double? battery { get; set; }      // Charge level percentage
            public int wifiLevel { get; set; }        // Signal strength (0-5)
            public double? fuel { get; set; }         // Fuel remaining in liters
            public double? altitude { get; set; }     // Elevation in meters
            public double timeSpent { get; set; }     // Duration at location
        }
        
        // Usage: Domain-specific point creation
        StreamPoint vehiclePoint = new StreamPoint()
        {
            coordinates = new Coordinates() 
            { 
                xy = new double[2] { 50.860847591747186, 4.227255449993002 } 
            },
            guid = Guid.NewGuid(),
            type = "Vehicle",
            timestamp = DateTime.UtcNow,
            value = new VehicleTracking()
            {
                speed = 20,
                battery = 85.5,
                wifiLevel = 4,
                fuel = 30,
                altitude = 120,
                timeSpent = 45.5
            }
        };

#### Integration Benefits

1. Map Visualization
 - Automatic layer assignment based on type property
 - Dynamic styling through classification
 - Real-time position updates via coordinates
2. Cache Optimization
 - timestamp enables efficient MemoryCache strategies
 - Time-based invalidation and refresh policies
 - Historical data retention and retrieval
3. Domain Flexibility
 - Zero-modification extension via value property
 - Type-safe domain model integration
 - Hierarchical data structure support
4. Spatial Operations
 - Native support for geographic calculations
 - Integration with spatial databases
 - Distance-based querying and clustering


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


