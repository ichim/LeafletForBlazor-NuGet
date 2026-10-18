# Objects

The ``map.Geometric.From.Objects`` class allows you to work with data from objects. Full `RFC 7946` Feature Support.

##  Loading data

**Razor**
```Razor 
 <Map height="100vh" width="100vw" OnAfterMapLoaded="@OnAfterMapLoaded" />
 ```

  **C# - Example of loading data from Objects**
 ```
     private async Task OnAfterMapLoaded(MapEventArgs args)
    {
        int primaryKey = 0; 
        var objects = new List<object>
        {
            new Feature()           //RFC 7946 class structure
        };
        await map!.Geometric.From.Objects!.LoadAsync(objects).WithKey(primaryKey);
    }
```
where:

```
  public class Feature
  {
      public string type { get; set; } = "Feature";
      public Geometry geometry { get; set; } = new Geometry();
      public Properties properties { get; set; } = new Properties();
  }

  public class Geometry
  {
      public string type { get; set; } = "Point";
      public List<double> coordinates { get; set; } = new List<double> { 26.098368, 44.4468244 };
  }

  public class Properties
  {
      public string name { get; set; } = "Beautiful Memories Store";
  }
```
## Removing data
