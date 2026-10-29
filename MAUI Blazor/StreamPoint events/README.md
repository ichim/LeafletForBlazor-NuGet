# StreamPoint Collection events
The OnClick event is triggered whenever the user clicks (left button) on the map. If there are points from the StreamPoint collection in the vicinity of the clicked point, they will be returned in the StreamPointEventArgs argument.
```C#
  map.Geometric.Points.OnClick +=  (object? sender, StreamPointEventArgs args) =>
   {
       System.Diagnostics.Debug.WriteLine($"    Clicked point with count {args.points.Count()}");
   };
```
## 🚀 Quick Setup

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
