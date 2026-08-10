# Files

The `@map.Geometric.From.Files` class allows you to load data from files stored on a web service host (https://...).
## Native GeoJSON Support

Zero GeoJSON Parsing Code

## Full RFC 7946 Feature Support

 - Geometry Types: Point, LineString, Polygon, MultiPoint, MultiLineString, MultiPolygon, GeometryCollection
 - Feature Objects: Automatic property extraction
 - Coordinate Reference System: WGS84 (EPSG:4326) by default
 - Bounding Boxes: Automatic extent calculation

## Standards Compliance

Supported Rich data objects GeoJSON Elements:

    { "type": "Feature", "geometry": {...}, "properties": {...} }

## Usage example

Non Pooling:

    private async Task OnAfterMapLoaded(MapEventArgs args)
    {
        var map = args.sender as Map;
            await map.Geometric.From.Files.FetchAsync(new List<string> { "http://....json"});
        }
    }

Pooling:

    private async Task OnAfterMapLoaded(MapEventArgs args)
    {
        var map = args.sender as Map;
            await map.Geometric.From.Files.FetchAsync(new List<string> { "http://....json"}, PoolingDelay.Short);
        }
    }

## Files events

The event is triggered whenever pooling is done on files:


            map.Geometric.From.Files.OnAfterFetchAsync += (sender, args) =>
            {
                Console.WriteLine($"Files loaded: {args.layerId}");
            };

## Stop pooling

            await map.Geometric.From.Files.StopFetchingAsync();

## Clear content

Each file has a layer associated with it. The contents of all layers can be deleted with the command:

      await map.Geometric.From.Files.ClearAsync();

However, if you only want to delete the contents of a specific layer (corresponding to a file), then you can use the Where clause:

      await map.Geometric.From.Files.Where((file) => file.url == "http://localhost:5057/data/input4.json").ClearAsync();
