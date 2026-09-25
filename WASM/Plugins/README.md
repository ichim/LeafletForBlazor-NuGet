
# 🔌 Map plugins

The Map component provides the MapPlugins slot (Plugin Framework), allowing you to extend LeafletForBlazor with additional Leaflet functionality. It enables the development of features in JavaScript and grants you access to the map (the Leaflet map instance) and the L object.

        <Map>
            <MapPlugins>
            </MapPlugins>
        </Map>

# Hello Plugin

The minimal structure of a MapPlugins-type component is as follows:

    [Parameter] public object? Map { get; set; }
    [Parameter] public object? L { get; set; }

The Blazor component must have the mandatory parameters `Map` and `L` (to enable the implementation of functionality).
