# Objects

The ``map.Geometric.From.Objects`` class allows you to load data from objects. Full `RFC 7946` Feature Support.

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
