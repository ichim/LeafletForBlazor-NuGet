# Files

The `@map.Geometric.From.Files` class allows you to load data from files stored on a web service host (https://...).

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
