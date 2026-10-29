# StreamPoint Collection events

```C#
  map.Geometric.Points.OnClick +=  (object? sender, StreamPointEventArgs args) =>
   {
       System.Diagnostics.Debug.WriteLine($"    Clicked point with count {args.points.Count()}");
   };
```
