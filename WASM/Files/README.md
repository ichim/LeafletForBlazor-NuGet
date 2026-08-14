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

## Basic Usage (No Pooling)

    private async Task OnAfterMapLoaded(MapEventArgs args)
    {
        var map = args.sender as Map;
        await map.Geometric.From.Files.FetchAsync(
            new List<string> { "http://example.com/data.json" }
        );
    }

## Pooling (Auto-Refresh)

Use PoolingDelay to periodically re-fetch the data. Available intervals:
| Value  | Interval  |
|----|----|
| None | Disabled |
| Short |	5 seconds |
| Medium |	30 seconds |
| Long |	60 seconds |
| VeryLong |	120 seconds |

    private async Task OnAfterMapLoaded(MapEventArgs args)
    {
        var map = args.sender as Map;
        await map.Geometric.From.Files.FetchAsync(
            new List<string> { "http://example.com/data.json" },
            PoolingDelay.Short
        );
    }

## Cache Bypass

To ensure fresh data on every fetch, cache is disabled by default:

    DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue
    {
        NoCache = true,
        NoStore = true,
        MustRevalidate = true
    };

For some browsers, you may also need to force-ignore cached reads:

    map.Geometric.From.Files.forceCacheIgnore = true;

## Events
Listen for fetch completions (fired after each pooling cycle):

    map.Geometric.From.Files.OnAfterFetchAsync += (sender, args) =>
    {
        Console.WriteLine($"Files loaded: {args.layerId}");
    };

## Stopping Pooling

``*Important:* Always call`` StopFetchingAsync before starting a new `FetchAsync`.

    await map.Geometric.From.Files.StopFetchingAsync();

## Clearing Content

Each file maps to its own layer. You can clear all layers at once:

    await map.Geometric.From.Files.ClearAsync();

Or target a specific file/layer:

    await map.Geometric.From.Files
        .Where(file => file.Url == "http://example.com/data.json")
        .ClearAsync();

## Removing All Layers

To completely remove all Leaflet layers from the map:

    await map.Geometric.From.Files.RemoveAsync();

## Suggestions

 - Consider adding a small "Common Gotchas" section: calling FetchAsync without stopping previous pooling can lead to duplicate requests and `the threads may work improperly`.
 - If **forceCacheIgnore** is browser-specific, listing which browsers are affected would help developers troubleshoot faster.
 - A note on thread safety (e.g., should these calls always happen on the UI thread?) could be useful for Blazor users.


# Other data formats

Leaflet For Blazor can also work with other formats based on ... but to which ``appearance`` properties are added.

## JSON Object

JSON object based on the `RFC 7946` format:

    {
      "data": [
        {
          "type": "Feature",
          "geometry": {
            "type": "Point",
            "coordinates": [ 26.097369, 44.4448446 ]
          },
          "properties": {
            "name": "Beautiful Memories Store"
          }
        }
      ]
    }

## JSON Object and Appearance

    {
      "data": [
        {
          "type": "Feature",
          "geometry": {
            "type": "Point",
            "coordinates": [ 26.097369, 44.4448446 ]
          },
          "properties": {
            "name": "Beautiful Memories Store"
          }
        },
        {
          "type": "Feature",
          "geometry": {
            "type": "Point",
            "coordinates": [ 26.095369, 44.444648 ]
          },
          "properties": {
            "name": "Amzei Market"
          }
        }
      ],
      "appearance": { "radius" : 10, "fillColor": "#ff0000", "color": "#000000", "weight": 2, "opacity": 0.8, "fillOpacity": 0.6 }
    }

