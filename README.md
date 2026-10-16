# ![LeafletForBlazor](https://user-images.githubusercontent.com/8348463/224698821-8768d8af-46ea-462a-a603-a7adf9095594.png) Leaflet Map for Blazor

*Leaflet for Blazor* is a library that provides components for displaying maps in Blazor applications.  

**🔑 KEYWORDS**: [`Pure C#`](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/Fundamentals.md#core-concept) - *Write map logic entirely in .NET / no JavaScript interop boilerplate*, [`LINQ Integration`](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/Fundamentals.md#destructuring-and-structuring-linq) - *Destructuring/Structuring LINQ expression*, [`Fluent API`](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/Fundamentals.md#fluent-api) - *objects Hierarchical and Linguistic structure and Chain methods*, [`Plugins`](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Plugins#-map-plugins) Framework - allows you to extend LeafletForBlazor, [`Zero JavaScript Config`](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/Fundamentals.md#core-concept) for standard use - *no script references and no css links etc*   

![NuGet Version](https://img.shields.io/nuget/v/LeafletForBlazor?cacheSeconds=3600) ![NuGet Downloads](https://img.shields.io/nuget/dt/LeafletForBlazor?cacheSeconds=3600)![GitHub stars](https://img.shields.io/github/stars/ichim/LeafletForBlazor-nuget?cacheSeconds=3600) ![GitHub last commit](https://img.shields.io/github/last-commit/ichim/LeafletForBlazor-nuget?cacheSeconds=3600)[![License: MIT](https://img.shields.io/badge/license-MIT-blue)](https://github.com/ichim/LeafletForBlazor-nuget/blob/main/LICENSE?cacheSeconds=3600)

🧩 Version 4.0 ♻️[rehydrates the Map control](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/Fundamentals.md#rehydratates). The new control will inherit the minimalism of the Map control and the optimizations of the RealTimeMap control.

# ⚙️ Core Concepts


1. ``No JavaScript or HTML specific configurations required``, no API script configurations, no CSS references, no HTML items etc.
1. ``Optimized code`` through various solutions
   	- minimizing the number of calls to JavaScript;
   	- collection searches by [`destructuring and structuring LINQ expressions`](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/Fundamentals.md#destructuring-and-structuring-linq);
   	- [fluent API](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/Fundamentals.md#fluent-api), a design pattern that allows code to be written in a readable way, similar to an English sentence
	- reducing size of the JavaScript code by removing unused code.
	- Memory Cache
1. [`Plugins framework`](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Plugins) - By writing simple wrapper code, the MapPlugins framework allows LeafletForBlazor to be extended with already developed Leaflet.js plugins (add-ons) - [more about Leaflet.js Plugins](https://leafletjs.com/plugins.html).

[More about Core Concept](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/Fundamentals.md#core-concept)

# 🚀 Quick Start


## 🔧 Project setup

🔵 **Add the Map component to your project in just 3 steps:**

1. **Install the NuGet package**:

 - From VS interface: *Tools* -> *NuGet Package Manager* -> *Manage NuGet Packages for Solution...*
 
      > Search for "LeafletForBlazor" and add the package to the project or solution.


 - From Package Manager Console: *Tools* -> *NuGet Package Manager* -> *Package Manager Console*

       NuGet\Install-Package LeafletForBlazor
 
2. Add the required namespaces in `_Imports.razor`

To do this, add the following directives to the `_Imports.razor` file


        @using LeafletForBlazor                             //working with package classes
        @using static LeafletForBlazor.Map                  //working with Map class
        @using static LeafletForBlazor.techs.maps.Leaflet   //working with Leaflet API

3. Use the `Map` component

**Razor**

        <Map height="100vh" width="100vw"/>

## 🗺️ Map and Default Configuration

Use the `loadParameters` property to set the initial map view:

**Razor**

        <Map loadParameters="@loadParameters" height="100vh" width="100vw"/>

**C# - Default Map Configuration**

    LoadParameters loadParameters = new()
    {
        location = new Location()                                               //Default center of the Map View
        {
            latitude = 50.83112274500208,
            longitude = 4.407353347319803
        },
        zoomLevel = 10                                                          //Default zoom level
    };
    
 
Additional default configurations are available, including [attribution control visibility](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Basic/Attribution#%E2%84%B9%EF%B8%8F-attribution), map [basemap layers](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Basic/Basemaps#basemap-layers), and [map controls](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/WASM/Basic/LoadParameters/README.md#map-controls) such as the scale control.


[more about Map Configuration - Blazor WebAssembly Standalone App](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Basic#-map-configuration)

[more about Map Configuration - .NET MAUI Blazor Hybrid App](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/MAUI%20Blazor#net-maui-blazor-hybrid-app)

# 🗺️ More about Map component

### ⚡ Map Events

#### OnAfterMapLoaded

Fires after the Leaflet map instance has fully initialized on the client side. Use it to access the map's initial state or trigger post-load logic.

**Razor**

    <Map height="100vh" width="100vw" OnAfterMapLoaded="@OnAfterMapLoaded" />

**C# - Handler signature**

The event method returns a set of parameters useful for configuring the initial state of the map: Map, centerOfView and other.


    private Task OnAfterMapLoaded(MapEventArgs args)
    {
        var map = args.sender as Map;
        
        Console.WriteLine($"Map loaded. Dimensions are - Height: {map!.height}, Map Width: {map!.width}");
        //other post-load logic can be added here, such as setting the map center or zoom level, adding points, updating files or others.
        Console.WriteLine($"lat: {args.centerOfView.latitude} long: {args.centerOfView.longitude}");
        
        return Task.CompletedTask;
    }

>It is important to note that ``args.sender`` represents the Map class (the map functionality).

[more about Map Events - Blazor WebAssembly Standalone App](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Basic/MapLoadEvent#map-events)

[more about Map Events - .NET MAUI Blazor Hybrid App](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/MAUI%20Blazor#-map-events)

### 👁️ View class

`View` is the class that allows you to control the visible area of ​​the map.

For example, you can use the `View` class to get the map's center:

**Razor**

```Razor 
 <Map height="100vh" width="100vw" OnAfterMapLoaded="@OnAfterMapLoaded" />
 ```

 **C#**

```C#
    private async Task OnAfterMapLoaded(MapEventArgs args)
    {
        var map = args.sender as Map;
        var center = await map!.View.getCenterAsync();
    }
```

...setting the map center - **C#**:

```C#
    private async Task OnAfterMapLoaded(MapEventArgs args)
    {
        var map = args.sender as Map;
        map!.View.SetCenter(40.24, 5.48);
    }
```

[more about View class](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Basic/View#view)


### ℹ️ Attribution class

The `Attribution` class provides the methods needed to interact with the map's `attributionControl`:

![attribtion control](https://raw.githubusercontent.com/ichim/LeafletForBlazor-nuget/main/docs/images/attributionControl.png)

For example, you can completely remove the attributionControl:

**Razor**

```Razor 
 <Map height="100vh" width="100vw" OnAfterMapLoaded="@OnAfterMapLoaded" />
 ```
**C#**

```C#
    private async Task OnAfterMapLoaded(MapEventArgs args)
    {
        var map = args.sender as Map;
        await map!.Attribution.Remove();  
        //strongly discouraged from an ethical standpoint (Leaflet.js BSD 2 license)
    }
```


[more about Attribution class](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Basic/Attribution#%E2%84%B9%EF%B8%8F-attribution)

### 📐 Geometric class

The `Geometric` class contains classes that operate on geometries obtained from various sources.


#### 📍 StreamPoint collection

`StreamPoint` collection provides *real-time map synchronization* - any property change (coordinates, appearance, timestamp) instantly updates the map visualization. Objects are cached for performance but remain fully dynamic.


The ``StreamPoint`` collection is hosted by `map.Geometric.Points` and provides you methods for handling predefined but hierarchically extensible root data structure:
1. [Add()](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/StreamPoint#add), [Remove()](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/StreamPoint#remove), [Update()](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/StreamPoint#update) for collection handling; 
1. [Appearance()](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/StreamPoint/Appearance#-appearance) for point the aspect in the map;
1. StreamPoint collection [events](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/WASM/StreamPoint/OnClickEvent/README.md#-streampoint-collection-events);

**Razor**
```Razor 
 <Map height="100vh" width="100vw" OnAfterMapLoaded="@OnAfterMapLoaded" />
 ```
**C# - Example of adding a StreamPoint to the collection**
```C#
    private async Task OnAfterMapLoaded(MapEventArgs args)
    {
        var map = args.sender as Map;
        var streamPoints = new List<StreamPoint>()
        {
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.86,  4.22 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000001"),
                    type = "Industrial",
                },
        }
        await map!.Geometric.Points.Add(streamPoint);
    }
```

[more about StreamCollection - Blazor WebAssembly Standalone App](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/StreamPoint#-streampoint-collection)

[more about StreamCollection - .NET MAUI Blazor Hybrid App](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/MAUI%20Blazor#-streampoint)


#### 📁 Working with Files

The ``map.Geometric.From.Files`` class allows you to load data from files stored on a web service host (_https://..._). Full `RFC 7946` Feature Support.

[more about working with files](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Files#files)


# 📊 Dashboard

``StreamPoint`` collection can be used to monitor moving targets: vehicles, boats, aircraft, even fleets of vehicles, drones and so one. Both the map and the StreamPoint collection can be configured to create a Map Dashboard.

![SigmaDrone](https://raw.githubusercontent.com/ichim/LeafletForBlazor-nuget/main/docs/images/SigmaDrone%20Description.png)

[more about Map Dashboard](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Dashboard#-working-with-map-dashboard)

# 🔌 Map plugins

However, extending the NuGet package can only be implemented by adding JavaScript code.

The Map component provides the MapPlugins slot (Plugin Framework), allowing you to extend LeafletForBlazor with additional Leaflet functionality. It enables the development of features in JavaScript and grants you access to the map (the Leaflet map instance) and the L object.

        <Map>
            <MapPlugins>
                        @* Custom Blazor Component - Leaflet.js Fullscreen plugin  *@
                        <Fullscreen            
                            Map="@context.map" 
                            L="context.LeafletCore"
                            url="https://unpkg.com/leaflet.fullscreen/dist/Control.FullScreen.umd.js"
                            href="https://unpkg.com/leaflet.fullscreen/dist/Control.FullScreen.css" />
						@*   other plugins or custom functionality  *@
            </MapPlugins>
        </Map>

By writing simple wrapper code, the MapPlugins framework allows LeafletForBlazor to be extended with already developed Leaflet.js add-ons.

[more about MapPlugins and WASM](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Plugins#-map-plugins)

[more about MapPlugins and MAUI](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/MAUI%20Blazor/Plugins#-map-plugins)

# 📦 Map Components

The Map component provides the MapComponents slot, allowing you to extend the LeafletForBlazor map with graphical interface elements.

        <Map>
            <MapComponents>
                <Toolbar/>
				@*   other MapComponents or html elements  *@
            </MapComponents>
        </Map>



| Description | Image |
|-----------|-------|
| The component displays a [Legend](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Components#legend) on the map, allowing users to quickly understand the meaning of the symbols and colors applied to data layers. In the current version, the legend is only available for GeoJSON files and StreamPoint Collection. Legend can also be used in [.NET MAUI projects](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/MAUI%20Blazor/Components/Legend#legend).| ![Legend](https://raw.githubusercontent.com/ichim/LeafletForBlazor-nuget/main/docs/images/Legend.png) |
| Contextual display driven by data source with [MapPopup](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/WASM/Components/MapPopup/README.md#mappopup) | ![MapPopup](https://raw.githubusercontent.com/ichim/LeafletForBlazor-nuget/main/docs/images/MapPopupOliveTable.png) |
| The [Toolbar](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Components/Toolbar#toolbar) it is a map component that allows for expansion with various buttons and even tools.  | ![Toolbar](https://raw.githubusercontent.com/ichim/LeafletForBlazor-nuget/main/docs/images/Toolbar.png) |
| A [Toggle](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/WASM/Components/Toolbar/ToolbarItems/README.md#toggle) is a check/uncheck component that can be hosted in a toolbar.  | ![Toggle](https://raw.githubusercontent.com/ichim/LeafletForBlazor-nuget/main/docs/images/ToolbarButtons.png) |


 _____________


O-L I - ᶜ⁴ˡᵘ⁷ᵘ⁵ᵘᶠˡᵉ⁷⁸ᵘⁿ 🐕

Thank you for choosing this package!

Laurentiu Ichim
