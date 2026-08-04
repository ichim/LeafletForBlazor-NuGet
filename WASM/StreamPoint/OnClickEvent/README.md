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
