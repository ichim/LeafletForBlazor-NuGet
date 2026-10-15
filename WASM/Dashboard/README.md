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
| title | string | "without title" | Chart title displayed above the pie. |
| dimension | int | — | Chart size. When `scaling = 100`, treated as a percentage. |
| scaling | int | 100 | Scale factor applied to `dimension`. |
| opacity | double | 1 | Chart opacity, from `0` (transparent) to `1` (opaque). |
| fontSize | int | 6 | Font size for slice labels. |
| expandedIndex | int | -1 | Zero-based index of the exploded (offset) slice. `-1` means none. |
| increaseScaleFactorOnMouseover | double | 0 | Scale multiplier applied on hover. `0` disables the effect. |
| visibilityZoomLevels | VisibilityZoomLevels | unrestricted | Min/max zoom range where the chart is visible. |
| styles | PieStyle? | null | Per-slice style overrides. `null` uses default styles. |
| paramOrValues | object` | new double[0] | Slice values — literal `double[]` or `${field}` binding. |
| paramOrLabels | object | new string[0] | Slice labels — literal `string[]` or `${field}` binding. |
| paramOrColors | object | new string[0] | Slice colors — literal `string[]` or `${field}` binding. |



### Data Binding

The `${propertyName}` syntax binds slice data to fields inside the `StreamPoint.value` object. At render time, each placeholder is resolved per-point:

| Placeholder | Resolves to |
| :--- | :--- |
| ${production} | StreamPoint.value → IndustrialValues.production (`double[]`) |
| ${texts} | StreamPoint.value → IndustrialValues.texts (`string[]`) |
| ${classes} | StreamPoint.value → IndustrialValues.classes (`string[]`) |

Where:

    public class IndustrialValues
    {
        public double[]? production { get; set; }
        public string[]? texts { get; set; }
        public string[]? classes { get; set; }
    }


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



## GaugeChart Class

This class renders a simple Gauge Chart on the map at the coordinates of a `StreamPoint`. The gauge consists of a circular crown with a configurable indicator, supporting value binding from stream data.

---

### Properties

| Property | Type | Default | Description |
| :--- | :--- | :--- | :--- |
| title | string | "without title" | Title of the gauge chart, displayed as a label or tooltip. |
| visibilityZoomLevels | VisibilityZoomLevels | new VisibilityZoomLevels() | Defines the zoom level range at which the gauge is visible on the map. |
| increaseScaleFactorOnMouseover | double | 0 | Factor by which the gauge size increases on mouse hover. Set to 0 for no scaling effect. |
| dimension | int | 28 | Size of the gauge chart, expressed as a percentage relative to the map viewport. |
| paramOrValueStart | object | null | The starting value of the gauge scale. Accepts static numeric values or `${...}` binding placeholders. |
| paramOrValueStop | object | null | The ending value of the gauge scale. Accepts static values or binding placeholders. |
| paramOrValue | object | null | The current value indicated by the gauge needle. Accepts static values or binding placeholders. |
| label | string | null | Text label displayed alongside or inside the gauge chart. |
| colorStart | string | "white" | Background color of the start (lower bound) segment of the circular crown. Accepts CSS color values. |
| colorStop | string | "white" | Background color of the stop (upper bound) segment of the circular crown. Accepts CSS color values. |
| opacity | double | 1 | Opacity of the entire gauge chart, from 0 (fully transparent) to 1 (fully opaque). |
| heightCircularCrown | int | 14 | Thickness (height) of the circular crown arc, in pixels. |
| urlIndicator | string | null | URL pointing to a custom image used as the gauge indicator/needle. If not set, the default built-in indicator is used. |
| fontColorStart | string | "black" | Font color for the text displayed at the start of the gauge scale. |
| fontColorMiddle | string | "black" | Font color for the text displayed at the middle of the gauge scale. |
| fontColorStop | string | "black" | Font color for the text displayed at the stop of the gauge scale. |
| fontSize | int | 6 | Font size (in pixels) for all text labels on the gauge chart. |
| turnedAround | bool | false | When true, the gauge arc is rendered in the opposite direction (mirrored orientation). |

---

### Data Binding

The `paramOrValueStart`, `paramOrValueStop`, and `paramOrValue` properties support dynamic binding to `StreamPoint` data fields using the `${placeholder}` syntax. This allows the gauge to reflect real-time stream values without hardcoding static numbers.

**Example:**

```csharp
gauge.paramOrValueStart = "${IndustrialValues.MinValue}";
gauge.paramOrValueStop  = "${IndustrialValues.MaxValue}";
gauge.paramOrValue      = "${IndustrialValues.CurrentValue}";
```

At runtime, the map engine resolves each placeholder against the corresponding `StreamPoint` property and updates the gauge accordingly.

---

### Implementation Example

```csharp
map.Geometric.Points.Appearance(
    points: myStreamPoints,
    appearance: point => new GaugeChart
    {
        title = "Temperature",
        dimension = 32,
        paramOrValueStart = 0,
        paramOrValueStop = 100,
        paramOrValue = "${IndustrialValues.Temperature}",
        label = "°C",
        colorStart = "#00ff00",
        colorStop = "#ff0000",
        heightCircularCrown = 18,
        fontSize = 8,
        fontColorStart = "white",
        fontColorMiddle = "white",
        fontColorStop = "white",
        opacity = 0.9,
        increaseScaleFactorOnMouseover = 0.15
    }
);
```

---

### Expected StreamPoint Structure

The `StreamPoint` object bound to the gauge should include the relevant data fields referenced by the placeholders:

```csharp
public class IndustrialValues
{
    public double Temperature { get; set; }
    public double MinValue { get; set; }
    public double MaxValue { get; set; }
}

public class StreamPoint
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public IndustrialValues IndustrialValues { get; set; }
}
```

---

### Remarks

- If `paramOrValueStart`, `paramOrValueStop`, or `paramOrValue` are left as `null`, the gauge may not render correctly — ensure all three are set.
- The `visibilityZoomLevels` property controls at which zoom levels the gauge appears, preventing visual clutter at inappropriate scales.
- A custom indicator image set via `urlIndicator` should be a small, web-accessible graphic (PNG or SVG recommended). If omitted, the default needle indicator is used.

