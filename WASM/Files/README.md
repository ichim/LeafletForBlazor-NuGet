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

# Fetching data

The asynchronous `FetchAsync` method on the `@map.Geometric.From.Files` class allows you to retrieve data from files stored on a virtual folder of a web server.

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

OnClick event:

     map.Geometric.From.Files.OnClick += (sender, args) =>
     {
         
     };

## Stopping Pooling

``Important: Always call`` StopFetchingAsync before starting a new `FetchAsync`.

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

JSON object based on the `RFC 7946` format. `"data"`, from the JSON structure, contains an array in the format.

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

## JSON Object and Style

JSON object based on the `RFC 7946` format. `"data"`, from the JSON structure, contains an array in the format.

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

## JSON Object and Switch/Classes

JSON object based on the `RFC 7946` format. `"data"`, from the JSON structure, contains an array in the format.

    {
      "data": [],
      "appearance": {
        "switch": {
          "fieldName": "name",
          "classes": [
            {
              "fieldValue": "commercial",
              "style": {
                "color": "blue",
                "weight": 8,
                "opacity": 0
              }
            },
            {
              "fieldValue": "residential",
              "style": {
                "color": "green",
                "weight": 10,
                "opacity": 0
              }
            }
          ],
          "default": {
            "color": "gray",
            "weight": 2,
            "opacity": 0.8
          }
        }
      }
    }

**Structure Overview**

 - `data` — an array of valid GeoJSON features (points, lines, or polygons).
 - `appearance.switch` — a rule-based styling engine that maps feature property values to visual styles.
 - `fieldName` — the GeoJSON properties key to evaluate (e.g., "name").
 - `classes` — an ordered list of value-to-style mappings. Each entry matches when properties[fieldName] === fieldValue.
 - `fieldValue` — the exact value to match.
 - `style` — the visual attributes applied on match (color, weight, opacity).
 - `default` — a fallback style applied when no fieldValue in classes matches the feature's property.

**Key notes for devs:**

 - Matching is first-come, first-served: the first classes entry whose fieldValue matches wins.
 - The default style guarantees every feature gets rendered, even with unexpected or missing property values.
 - GeoJSON geometry types are honored as-is; additional geometry-type filtering would **require an optional appliesTo field (not yet implemented)**.
