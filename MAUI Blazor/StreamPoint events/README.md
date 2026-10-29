# StreamPoint Collection events
The OnClick event is triggered whenever the user clicks (left button) on the map. If there are points from the StreamPoint collection in the vicinity of the clicked point, they will be returned in the StreamPointEventArgs argument.
```C#
  map.Geometric.Points.OnClick +=  (object? sender, StreamPointEventArgs args) =>
   {
       System.Diagnostics.Debug.WriteLine($"    Clicked point with count {args.points.Count()}");
   };
```
