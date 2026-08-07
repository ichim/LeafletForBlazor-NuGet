# Files

The `@map.Geometric.From.Files` class allows you to load data from files stored on a web service host (https://...).
## Native GeoJSON Support

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
            await map.Geometric.From.Files.Open("http://localhost:5057/data/points.json");
        }
    }

Pooling:

    private async Task OnAfterMapLoaded(MapEventArgs args)
    {
        var map = args.sender as Map;
            await map.Geometric.From.Files.Open("http://localhost:5057/data/points.json", PoolingDelay.Short);
        }
    }
