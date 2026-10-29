# ⚡ StreamPoint collection events

The OnClick event is triggered whenever the user clicks (left button) on the map. If there are points from the StreamPoint collection in the vicinity of the clicked point, they will be returned in the StreamPointEventArgs argument.


        map.Geometric.Points.OnClick += async (object? sender, StreamPointEventArgs args) =>
       {
           Console.WriteLine($"    Clicked point with count {args.points.Count()}");
       };

Where:

       public class StreamPointEventArgs : EventArgs
       {
           public List<StreamPoint> points { get; set; }
           public Coordinates geoid { get; set; }
           public Coordinates screen { get; set; }
        }

## Quick Setup

The `OnClick` event for the `StreamPoint` collection can only be initialized within the map's post-load logic (OnAfterMapLoaded Map event). Both the map and `L` must be initialized and functional.

### 1. OnAfterMapLoaded event
```Razor
    <Map height="100vh" width="100vw" OnAfterMapLoaded="@OnAfterMapLoaded" />
```
```C#
    private Task OnAfterMapLoaded(MapEventArgs args)
    {   
        return Task.CompletedTask;
    }
```
### 2. OnClick Event initialization
```C#
    private Task OnAfterMapLoaded(MapEventArgs args)
    {
         var map = args.sender as Map;
         map!.Geometric.Points.OnClick += async (object? sender, StreamPointEventArgs args) =>
         {
             Console.WriteLine($"    Clicked point with count {args.points.Count()}");
         };  
         return Task.CompletedTask;
    }
```

# ⚖️ ToleranceSlopeForClickSelection

Represents the slope of the relationship (slope * x + intercept) used to calculate the click search tolerance (degrees):

            map.Geometric.Points.ToleranceSlopeForClickSelection = 0.0001;

# 🧾 MapPopup component and OnClick event

You can use the MapPopup component to display data for a StreamPoint you have clicked on.

[more about MapPopup and OnClick event](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/WASM/Components/MapPopup/StreamPointPopup/README.md#-mappopup-component-and-onclick-event)

