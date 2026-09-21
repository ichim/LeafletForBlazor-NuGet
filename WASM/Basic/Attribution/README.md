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

## Add

Allows adding an attribution element to the map's attributionControl:

            private async Task addAttribution()
            {
                if (map != null)
                {
                    await map.Attribution.Add("MyMap");
                }
            }

## RemovePrefix

This method allows for the removal of the attribute referencing the map technology (Leaflet). Although this attribute can be removed, it is nonetheless recommended to acknowledge the developer's contribution to the Leaflet.js technology.

            private async Task removePrefix()
            {
                if (map != null)
                {
                    await map.Attribution.RemovePrefix();
                }
            }

