# ![LealletForBlazor32](https://user-images.githubusercontent.com/8348463/224698821-8768d8af-46ea-462a-a603-a7adf9095594.png) Leaflet Map for Blazor

*Leaflet for Blazor* is a library that provides components for displaying map in Blazor applications. Allows developers to easily integrate interactive maps, `without any JavaScript settings`, into their Blazor projects. 


**🔑 KEYWORDS**: Minimizing Invoke callers to JavaScript, `No JavaScript specific settings`, no script references, no css links, readability, intuitive, immutability through `fluent API`.

![NuGet Version](https://img.shields.io/nuget/v/LeafletForBlazor?cacheSeconds=3600) ![NuGet Downloads](https://img.shields.io/nuget/dt/LeafletForBlazor?cacheSeconds=3600)![GitHub stars](https://img.shields.io/github/stars/ichim/LeafletForBlazor-nuget?cacheSeconds=3600) ![GitHub last commit](https://img.shields.io/github/last-commit/ichim/LeafletForBlazor-nuget?cacheSeconds=3600)[![License: MIT](https://img.shields.io/badge/license-MIT-blue)](https://github.com/ichim/LeafletForBlazor-nuget/blob/main/LICENSE?cacheSeconds=3600)

🧩 Version 4.0 [rehydrates the Map control](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/Fundamentals.md#rehydratates). The new control will inherit the minimalism of the Map control and the optimizations of the RealTimeMap control.

# ⚙️ Core Concepts


1. ``No JavaScript or HTML specific configurations required``, no API script configurations, no CSS references, no HTML items etc.
1. ``Optimized code`` through various solutions
   - minimizing the number of calls to JavaScript;
   - collection searches by destructuring and structuring LINQ expressions
	- redusing size of the JavaScript code by removing unused code.
	- Memory Cache

[More about Core Concept](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/Fundamentals.md#core-concept)

# 🚀 Quick Start


## 🔧 Basic configuration

🔵 **Add the Map component to your project in just 3 steps:**

1. add LeafletForBlazor NuGet package:

Using Visual Studio _interface_:

 - Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution...
 
 > Search for "LeafletForBlazor" and add the package to the project or solution.

 Or using Visual Studio _console_:

 - Tools -> NuGet Package Manager -> Package Manager Console

       NuGet\Install-Package LeafletForBlazor
 
2. add the LeafletForBlazor namespace to the project, using the @using directive

To do this, add the following directives to the **_Imports.razor** file

		@using LeafletForBlazor
		@using static LeafletForBlazor.Map


3. Configuring the Blazor page (which will host the Map control):

The `@using` directive allows selecting the API for generating the map:

	@using static LeafletForBlazor.techs.maps.Leaflet



## 🗺️ Add Map

Adding the map to the blazor page:

	<Map height="calc(100vh - 1rem)" width="calc(100vw - 2rem)"/>





[More information](https://ichim.github.io/MapsForBlazor/)


## 🧭 Map configuration

The loadParameter parameter of the Map component allows you to configure the map at initialization. The initialization parameters are:

 - 📍 ``Location`` of the center of the displayed map (View of Map):
	
        location = new Location()
        {
            latitude = 45.2831589721668,
            longitude = 27.98740645063448
        },

- 🔍 ``Zoom Level``

					
		zoomLevel = 12,

- 🎛️ Configuring ``map controls``

        mapControls = new MapControls()
        {
            layerList = new LayerList() { position = Position.topRight },
            scaleBar = new ScaleBar()
            {
                position = Position.bottomRight,
                unitOfScaleBar = UnitOfScaleBar.metric
            },

[more about Map Configuration - Blazor WebAssembly Standalone App](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Basic#-map-configuration)

[more about Map Configuration - .NET MAUI Blazor Hybrid App](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/MAUI%20Blazor#net-maui-blazor-hybrid-app)


## 📍 StreamPoint collection

`StreamPoint` collection provides *real-time map synchronization* - any property change (coordinates, appearance, timestamp) instantly updates the map visualization. Objects are cached for performance but remain fully dynamic.

The ``StreamPoint`` collection is hosted by `@map.Geometric.Points` and provides operating functionalities with a predefined but hierarchically extensible root data structure.

[more about StreamCollection - Blazor WebAssembly Standalone App](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/StreamPoint#-streampoint-collection)

[more about StreamCollection - .NET MAUI Blazor Hybrid App](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/MAUI%20Blazor/Appearance#streampoint-collection-and-appearance)

### 🎨 Appearance

Appearance is a method that accepts Expression<Func<T, bool>> predicates and allows filtering and applying different styles to the elements displayed in the map:

    await map.Geometric.Points.Appearance(e.type => e.type == "Market").SetStyle(...).SetLabel(...);

[more about Appearance - Blazor WebAssembly Standalone App](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/StreamPoint/Appearance#-appearance)

[more about Appearance - .NET MAUI Blazor Hybrid App](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/MAUI%20Blazor/Appearance/README.md#-appearance)

### 🛠️ Settings

Here you can configure how the collection of points displayed on the map behaves.

    map.Geometric.Points.settings = new LeafletForBlazor.techs.core.Geometry.Points.Settings(){};

### ⚡ Events

StreamPoint Collection Events.

[more about events](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/WASM/StreamPoint/OnClickEvent/README.md#-streampoint-collection-events)

## 📊 Dashboard

``StreamPoint`` collection can be used to monitor moving targets: vehicles, boats, aircraft, even fleets of vehicles, drones and so one.

[more about Map Dashboard](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Dashboard#-working-with-map-dashboard)

 _____________


O-L I - ᶜ⁴ˡᵘ⁷ᵘ⁵ᵘᶠˡᵉ⁷⁸ᵘⁿ 🐕

Thank you for choosing this package!

Laurentiu Ichim
