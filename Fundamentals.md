# Rehydratates

🧩 Version 4.0 rehydrates the Map control. The new control will inherit the minimalism of the Map control and the optimizations of the RealTimeMap control.

 - It inherits the minimalism of the old Map control – meaning it will remain simple, easy to use, with a clean interface.
 - It inherits optimizations from the RealTimeMap control – it will include performance improvements for displaying real-time data (e.g., live updates, fast rendering, efficient resource consumption).

# Core Concept

1. ``No JavaScript or HTML specific configurations required``, no API script configurations, no CSS references, no HTML items etc. Zero-Configuration Integration: Pure C# Mapping

❌ What You Don't Need:
 - No JavaScript Configuration
 - No API Key Management
 - No CSS/Link Tags
 - No HTML Template Setup

✅ What You Do Instead:
 - Pure C# Initialization
 - Type-Safe Configuration
 - Dynamic Property Binding

The code you write will be simple, pure Blazor, clear and easy to manage.


2. ``Optimized code`` through various solutions
   - minimizing the number of calls to JavaScript;
   - collection searches by destructuring and structuring LINQ expressions
	- redusing size of the JavaScript code by removing unused code.
	- Memory Cache

Following specific development iterations, invokes were eliminated, LINQ structuring/destructuring procedures were added, JavaScript code was reduced. Also, Memory Cache mechanisms were implemented in both C# and JavaScript.

⭐ Advantages:

 - ``Only C# code``, easy to manage. You focus only on functionality
 - ``Out-of-the-box`` integration;
 - ``Server-side configuration``: all settings can be made from C#/config, without html page, css etc
 - ``Security``: reduces the risk of introducing XSS (cross-site scripting) errors through controlled generation of markup/JS (ex. destructuring and structuring LINQ expressions).
 - ``Complete abstraction``

# Fluent API

A design pattern that allows code to be written in a readable way, similar to an English sentence. 

## Access to map classes

It is designed through a chain of already instantiated classes (objects) with a hierarchical and linguistic structure:

For example, access to the map's point collection:


	@map.Geometric.Points (.Add, .Remove, .Appearance etc)

## Access to point/point properties

Here method chaining is used: SetStyle, SetLabel etc:

	@map.Geometric.Points.Appearance(e.type => e.type == "Market").SetStyle(...).SetLabel(...).SetPopup(...);

## Points behavior

	@map.Geometric.Points.isFitExtentEnabled = true;

# Destructuring and Structuring LINQ

To optimize data flow and improve package performance, data filtering is done separately: Both in C# and in JavaScript. This LINQ Destructuring/Structure mechanism avoids the repeated transmission of data collections, the transmission of large data collections.

Advantages of LINQ Destructuring/Restructuring:

✅ Minimal data transfer (only the expression)

✅ Fast re-filtering in JS (data is already there)

✅ Maximum flexibility: Client can re-apply filters

✅ For the future: Offline-capable after first load





