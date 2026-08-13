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

PoolingDelay is the parameter of the FetchAsync method that allows configuring the pooling mechanism. PoolingDelay is an enum:

        public enum PoolingDelay
        {
            None = 0,
            Short = 5000,
            Medium = 30000,
            Long = 60000,
            VeryLong = 120000
        }

  So:

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

``Please call StopPoolingAsync before doing a new FetchAsync!``

            await map.Geometric.From.Files.StopFetchingAsync();

## Clear content

Each file has a layer associated with it. The contents of all layers can be deleted with the command:

      await map.Geometric.From.Files.ClearAsync();

However, if you only want to delete the contents of a specific layer (corresponding to a file), then you can use the Where clause:

      await map.Geometric.From.Files.Where((file) => file.url == "http://...fileName.json").ClearAsync();

## Remove all Leaflet layers

     await map.Geometric.From.Files.RemoveAsync();

# Other data formats

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

