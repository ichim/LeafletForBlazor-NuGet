
# 🔌 Map plugins

The Map component provides the MapPlugins slot (Plugin Framework), allowing you to extend LeafletForBlazor with additional Leaflet functionality. It enables the development of features in JavaScript and grants you access to the map (the Leaflet map instance) and the L object.

By writing simple wrapper code, the MapPlugins framework allows LeafletForBlazor to be extended with already developed Leaflet.js add-ons.


        <Map>
            <MapPlugins>
                        <Fullscreen            
                            Map="@context.map" 
                            L="context.LeafletCore"
                            url="https://unpkg.com/leaflet.fullscreen/dist/Control.FullScreen.umd.js"
                            href="https://unpkg.com/leaflet.fullscreen/dist/Control.FullScreen.css" />
                        <Leaflet.Geodesic.Plugins.LeafletGeodesic 
                                Map="@context.map" 
                                L="context.LeafletCore" 
                                url="https://cdn.jsdelivr.net/npm/leaflet.geodesic" 
                                Start="new Leaflet.Geodesic.Plugins.LeafletGeodesic.Coordinates(52.5, 13.35)" 
                                End="new Leaflet.Geodesic.Plugins.LeafletGeodesic.Coordinates(33.82, -118.38)" />
            </MapPlugins>
        </Map>

The MapPlugins context has two parameters: `map` and `L`.
Parameters `map` and `L` are passed to the customized component via the MapPlugins context:

           <MapPlugins>
                <CustomScript Map="@context.map" L="@context.L" />
           </MapPlugins>


## Hello Plugin

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

Using the component in the host Blazor page:

        <Map>
           <MapPlugins>
                <HelloPlugin Map="@context.map" Name="writeConsole" />
           </MapPlugins>
        </Map>

## Leaflet.Geodesic

This plugin is a wrapper for the [Leaflet.Geodesic](https://github.com/henrythasler/Leaflet.Geodesic) add-on developed by [Henry Thasler](https://github.com/henrythasler) for Leaflet.js.

<img width="799" height="300" alt="image" src="https://github.com/user-attachments/assets/a82ddf86-a98b-4ae5-8b5e-236c1e1b3e4e" />


### About Wrapper

1. The component assumes the external plugin defines L.Geodesic and follows the Leaflet layer convention (constructor accepting a coordinate array, exposing .addTo(map)).
1. Static fields are used so the [JSInvokable] method can access per-instance state. This pattern is viable when only one instance of the component is active at a time. For multi-instance scenarios, consider passing a unique identifier or using instance-bound invocable methods via DotNetObjectReference.
1. The script URL is loaded once per component lifecycle; subsequent renders do not re-inject the script.

### Parameters

| Parameter | Type                  | Description                                    |
| --------- | --------------------- | ---------------------------------------------- |
| `Map`     | `IJSObjectReference?` | Reference to the Leaflet map object (JS side). |
| `L`       | `IJSObjectReference?` | Reference to the Leaflet factory (`L`).        |
| `url`     | `string?`             | URL of the external plugin script to load.     |
| `Start`   | `Coordinates?`        | Starting point of the geodesic line.           |
| `End`     | `Coordinates?`        | Ending point of the geodesic line.             |

### Creating wrapper functions

1. On first render, the component captures the JS runtime, map, and coordinate references into static fields — making them available to the static [JSInvokable] callback that follows.

            protected override async Task OnAfterRenderAsync(bool firstRender)
            {
                if (firstRender)
                {
                    _js = JS;
                    _map = Map;
                    _L = L;
                    _start = Start!;
                    _end = End!;
                    string? namespaceName = typeof(Program).Assembly.GetName().Name;
                    await JS.InvokeVoidAsync("eval", $@"
                                            const script = document.createElement('script');
                                            script.src = '{url}';
                                            script.onload = () => DotNet.invokeMethodAsync('{namespaceName}', 'OnScriptLoaded');
                                            document.body.appendChild(script);
                                           ");
                }
            }

1. Script injection — A <script> tag is created and appended to the DOM, pointing to the plugin URL. The onload handler fires a .NET static method invocation via DotNet.invokeMethodAsync, using the assembly name resolved at runtime from typeof(Program).Assembly.GetName().Name.

1. OnScriptLoaded (static, JSInvokable) — Once the external script is ready:
 - It defines window._drawGeodesic, a function that wraps new L.Geodesic([pointA, pointB]).addTo(map).
 - It immediately invokes that function, passing the stored _map, _L, and anonymous objects representing the start and end coordinates ({ lat, lng }).

            [JSInvokable]
            public static async Task OnScriptLoaded()
            {
                await _js!.InvokeVoidAsync("eval", @"
                                                    window._drawGeodesic = function(map, L, pointA, pointB) {
                                                        new L.Geodesic([pointA, pointB]).addTo(map);
                                                    };
                                                    ");
                await _js!.InvokeVoidAsync("_drawGeodesic",
                                                         _map,
                                                         _L,
                                                         new { lat = _start!.Latitude, lng = _start!.Longitude },
                                                         new { lat = _end!.Latitude, lng = _end!.Longitude }
                                                       );
            }


## Leaflet.Fullscreen

This plugin is a wrapper for the [Leaflet.Fullscreen](https://github.com/brunob/leaflet.fullscreen) plugin developed by [brunob](https://github.com/brunob) for Leaflet.js.

<img width="392" height="271" alt="image" src="https://github.com/user-attachments/assets/d35ad896-f369-4909-85cf-e278adb0a0a2" />

### Parameters

| Parameter | Type                  | Description                                    |
| --------- | --------------------- | ---------------------------------------------- |
| `Map`     | `IJSObjectReference?` | Reference to the Leaflet map object (JS side). |
| `L`       | `IJSObjectReference?` | Reference to the Leaflet factory (`L`).        |
| `url`     | `string?`             | URL of the external plugin script to load.     |
| `href`    | `string?`             | href to css file.                              |

### Creating wrapper functions

1. On first render, the component captures the JS runtime, map, and coordinate references into static fields — making them available to the static [JSInvokable] callback that follows.


            protected override async Task OnAfterRenderAsync(bool firstRender)
            {
                if (firstRender)
                {
                    _js = JS;
                    _map = Map;
                    _L = L;
         
                    string? namespaceName = typeof(Program).Assembly.GetName().Name;
        
                    await JS.InvokeVoidAsync("eval", $@"
                                            const script = document.createElement('script');
                                            script.src = '{url}';
                                            script.onload = () => DotNet.invokeMethodAsync('{namespaceName}', 'OnScriptLoaded');
                                            document.body.appendChild(script);
                                            const link = document.createElement('link');
                                            link.rel = 'stylesheet';
                                            link.href = '{href}';
                                            document.head.appendChild(link);
                                            ");
                }
            }

1. Script injection — A <script> tag is created and appended to the DOM, pointing to the plugin URL. The onload handler fires a .NET static method invocation via DotNet.invokeMethodAsync, using the assembly name resolved at runtime from typeof(Program).Assembly.GetName().Name.

1. OnScriptLoaded (static, JSInvokable) — Once the external script is ready:
 - It defines window._applyFullscreen, a function that wraps map.addControl(new L.Control.FullScreen()).
 - It immediately invokes that function, passing the stored _map, _L.

           [JSInvokable]
           public static async Task OnScriptLoaded()
           {
               await _js!.InvokeVoidAsync("eval", @"
                                                   window._applyFullscreen = function(map, L) {
                                                       map.addControl(new L.Control.FullScreen());
                                                                                           };
                                                   ");
                       await _js!.InvokeVoidAsync("_applyFullscreen",
                        _map,
                        _L
                    );
           }
