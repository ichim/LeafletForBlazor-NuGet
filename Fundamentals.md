# Rehydratates

🧩 Version 4.0 rehydrates the Map control. The new control will inherit the minimalism of the Map control and the optimizations of the RealTimeMap control.

 - It inherits the minimalism of the old Map control – meaning it will remain simple, easy to use, with a clean interface.
 - It inherits optimizations from the RealTimeMap control – it will include performance improvements for displaying real-time data (e.g., live updates, fast rendering, efficient resource consumption).

# Core Concept


1. ``No JavaScript or HTML specific configurations required``, no API script configurations, no CSS references, no HTML items etc.

The code you write will be simple, pure Blazor, clear and easy to manage.


2. ``Optimized code`` through various solutions
   - minimizing the number of calls to JavaScript;
   - collection searches by destructuring and structuring LINQ expressions
	- redusing size of the JavaScript code by removing unused code.
	- Memory Cache

Following specific development iterations, invokes were eliminated, LINQ structuring/destructuring procedures were added, JavaScript code was reduced. Also, Memory Cache mechanisms were implemented in both C# and JavaScript.
