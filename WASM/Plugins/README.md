
# 🔌 Map plugins

The Map component provides the MapPlugins slot (Plugin Framework), allowing you to extend LeafletForBlazor with additional Leaflet functionality. It enables the development of features in JavaScript and grants you access to the map (the Leaflet map instance) and the L object.

        <Map>
            <MapPlugins>
            </MapPlugins>
        </Map>

The MapPlagins context has two parameters: `map` and `L`.
Parameters `map` and `L` are passed to the customized component via the MapPlugins context:

           <MapPlugins>
                <CustomScript Map="@context.map" L="@context.L" />
           </MapPlugins>


# Hello Plugin

A MapPlugins-type component requires the following minimal structure:

    [Parameter] public object? Map { get; set; }
    [Parameter] public object? L { get; set; }

The Blazor component must declare the mandatory Map and L parameters. These parameters provide access to the map instance and the Leaflet object required to implement plugin functionality.

Plugin functionality should be executed only after the component has finished rendering. At that point, the `map` and `L` objects are available for use.

        @inject IJSRuntime JS
        @code {
            [Parameter] public object? Map { get; set; }
            [Parameter] public object? L { get; set; }
            [Parameter] public string? Name { get; set; }
        
            protected override async Task OnAfterRenderAsync(bool firstRender)
            {
                if (firstRender)
                {
                    await JS.InvokeVoidAsync("console.log", Map);
                }
            }
        }

In the Hello Plugin example, the plugin functionality is intentionally minimal: it writes the Map object to the browser console after the component has rendered for the first time.
