# 🎨 Appearance

Appearance is a method that accepts Expression<Func<T, bool>> predicates and allows filtering and applying different styles to the elements displayed in the map:

    await map.Geometric.Points.Appearance(e.type => e.type == "Market").SetStyle(...).SetLabel(...);


Appearance is a method that accepts Expression<Func<T, bool>> predicates and allows filtering and applying different styles to the elements displayed in the map:

    await map.Geometric.Points.Appearance(e.type => e.type == "Market").SetStyle(...).SetLabel(...);

Fluent API:

        Initial Context → Filtered Points → Styled Points → Labeled Points → Final Render
        
              ↑                ↑                ↑                ↑
              
           Map.Points      Appearance()     SetStyle()       SetLabel()

Performance with Fluency:

1. Lazy Evaluation

        // Chain builds configuration, execution happens once
        await map.Geometric.Points
            .Appearance(p => p.type == "Market")  // Builds filter
            .SetStyle(complexStyle)               // Adds to config
            .SetLabel(labelFunction);             // More configuration

1. Batch Operations

        // Multiple styles in single fluent chain
        await map.Geometric.Points
            .Appearance(p => p.type == "Market")
            .SetStyle(marketStyle)
            .SetLabel("Market");
            //Add
            .And(...)  // Chain continuation pattern
            //Again
            .Appearance(p => p.type == "Vehicle")
            .SetStyle(vehicleStyle)
            .SetLabel("Vehicle");

