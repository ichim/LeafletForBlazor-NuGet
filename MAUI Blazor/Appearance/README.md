# 🎨 Appearance

Appearance is a method that accepts Expression<Func<T, bool>> predicates and allows filtering and applying different styles to the elements displayed in the map:

    await map.Geometric.Points.Appearance(e.type => e.type == "Market").SetStyle(...).SetLabel(...);
