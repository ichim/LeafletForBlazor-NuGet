# 📊 Working with Map Dashboard

``StreamPoint`` collection can be used to monitor moving targets: vehicles, boats, aircraft, even fleets of vehicles, drones and so one.

Dashboard configuration is done by:
1. using a point (location) display style appropriate to the type of tracking (Appearance method);
2. setting the point collection according to the tracking needs

## `PieChart` class

A point-rendering style that displays a pie chart at each matching `StreamPoint` coordinate.

### Properties

| Property | Type | Default | Description |
| :--- | :--- | :--- | :--- |
| `title` | `string` | `"without title"` | Chart title displayed above the pie. |
| `dimension` | `int` | — | Chart size. When `scaling = 100`, treated as a percentage. |
| `scaling` | `int` | `100` | Scale factor applied to `dimension`. |
| `opacity` | `double` | `1` | Chart opacity, from `0` (transparent) to `1` (opaque). |
| `fontSize` | `int` | `6` | Font size for slice labels. |
| `expandedIndex` | `int` | `-1` | Zero-based index of the exploded (offset) slice. `-1` means none. |
| `increaseScaleFactorOnMouseover` | `double` | `0` | Scale multiplier applied on hover. `0` disables the effect. |
| `visibilityZoomLevels` | `VisibilityZoomLevels` | unrestricted | Min/max zoom range where the chart is visible. |
| `styles` | `PieStyle?` | `null` | Per-slice style overrides. `null` uses default styles. |
| `paramOrValues` | `object` | `new double[0]` | Slice values — literal `double[]` or `${field}` binding. |
| `paramOrLabels` | `object` | `new string[0]` | Slice labels — literal `string[]` or `${field}` binding. |
| `paramOrColors` | `object` | `new string[0]` | Slice colors — literal `string[]` or `${field}` binding. |



### Data Binding

The `${propertyName}` syntax binds slice data to fields inside the `StreamPoint.value` object. At render time, each placeholder is resolved per-point:

| Placeholder | Resolves to |
| :--- | :--- |
| `${production}` | `StreamPoint.value` → `IndustrialValues.production` (`double[]`) |
| `${texts}` | `StreamPoint.value` → `IndustrialValues.texts` (`string[]`) |
| `${classes}` | `StreamPoint.value` → `IndustrialValues.classes` (`string[]`) |

### Usage

Apply the style to a filtered set of points via `Appearance()`:

```csharp
              await map.Geometric.Points
                  .Appearance(e => e.type == "Market")
                  .SetStyle(new PieChart
                  {
                      dimension = 28,
                      visibilityZoomLevels = new VisibilityZoomLevels
                      {
                          minZoomLevel = 4,
                          maxZoomLevel = 18
                      },
                      increaseScaleFactorOnMouseover = 2.2,
                      opacity = 0.8,
                      paramOrValues = "${production}",
                      paramOrLabels  = "${texts}",
                      paramOrColors  = "${classes}"
                  });
```
### Adding points to the map

     await map.Geometric.Points.Add(new StreamPoints().points); //List<StreamPoint>

### Data Example

        new StreamPoint
        {
            coordinates = new Coordinates
            {
                xy = new double[] { 50.8608, 4.2272 }
            },
            guid = new Guid("00000000-0000-0000-0000-000000000001"),
            type = "Market",
            value = new IndustrialValues
            {
                production = new double[] { 400, 200, 300, 50 },
                texts     = new string[] { "Low", "Medium", "High" },
                classes   = new string[] { "white", "yellow", "red", "gray" }
            }
        }
