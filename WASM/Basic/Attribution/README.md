# ℹ️ Attribution

The Attribution class provides the methods needed to interact with the map's attributionControl.

## Remove

The Remove method has two forms:

1. Remove(), which allows the attributionControl to be completely removed.

        private async Task removeAttribution()
        {
            if (map != null)
            {
                await map.Attribution.Remove();
            }
        }

2. Remove(string attribution), which allows the removal of a specific existing element (attribution) from the attributionControl.

        private async Task removeAttributionItem()
        {
            if (map != null)
            {
                await map.Attribution.Remove("MyMap");
            }
        }
