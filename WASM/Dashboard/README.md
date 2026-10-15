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

**Namespace:** `LeafletForBlazor.Geometric.Points.Appearance`  
**Interfaces:** `IGaugeChart`, `IChartPoint`  
**Category:** Appearance  
**Description:** Această clasă permite afișarea unui Gauge Chart simplu pe hartă, randat la coordonatele unui `StreamPoint`. Graficul este format dintr-o coroană circulară cu un indicator configurabil, suportând legarea (binding) valorilor din datele de flux.

---

### Properties

| Property | Type | Default | Description |
| :--- | :--- | :--- | :--- |
| title | string | "without title" | Titlul graficului gauge, afișat ca etichetă sau tooltip. |
| visibilityZoomLevels | VisibilityZoomLevels | new VisibilityZoomLevels() | Definește intervalul de niveluri de zoom la care gauge-ul este vizibil pe hartă. |
| increaseScaleFactorOnMouseover | double | 0 | Factorul cu care se mărește dimensiunea gauge-ului la hover. Setat la 0, nu există efect de scalare. |
| dimension | int | 28 | Dimensiunea graficului gauge, exprimată ca procent relativ la viewport-ul hărții. |
| paramOrValueStart | object | null | Valoarea de început a scalei gauge-ului. Acceptă valori numerice statice sau placeholder-uri de tip `${...}`. |
| paramOrValueStop | object | null | Valoarea de sfârșit a scalei gauge-ului. Acceptă valori statice sau placeholder-uri. |
| paramOrValue | object | null | Valoarea curentă indicată de acul gauge-ului. Acceptă valori statice sau placeholder-uri. |
| label | string | null | Etichetă text afișată lângă sau în interiorul graficului gauge. |
| colorStart | string | "white" | Culoarea de fundal a segmentului de început (limită inferioară) al coroanei circulare. Acceptă valori CSS. |
| colorStop | string | "white" | Culoarea de fundal a segmentului de sfârșit (limită superioară) al coroanei circulare. Acceptă valori CSS. |
| opacity | double | 1 | Opacitatea întregului grafic gauge, de la 0 (complet transparent) la 1 (complet opac). |
| heightCircularCrown | int | 14 | Grosimea (înălțimea) arcului coroanei circulare, în pixeli. |
| urlIndicator | string | null | URL către o imagine personalizată folosită ca indicator/ac al gauge-ului. Dacă nu este setat, se folosește indicatorul implicit. |
| fontColorStart | string | "black" | Culoarea fontului pentru textul afișat la începutul scalei. |
| fontColorMiddle | string | "black" | Culoarea fontului pentru textul afișat la mijlocul scalei. |
| fontColorStop | string | "black" | Culoarea fontului pentru textul afișat la sfârșitul scalei. |
| fontSize | int | 6 | Dimensiunea fontului (în pixeli) pentru toate etichetele text de pe graficul gauge. |
| turnedAround | bool | false | Când este true, arcul gauge-ului este randat în direcția opusă (orientare oglindită). |

---

### Data Binding

Proprietățile `paramOrValueStart`, `paramOrValueStop` și `paramOrValue` suportă legarea dinamică la câmpurile de date `StreamPoint` folosind sintaxa `${placeholder}`. Aceasta permite gauge-ului să reflecte valori în timp real fără a folosi numere statice.

**Exemplu:**

```csharp
gauge.paramOrValueStart = "${IndustrialValues.MinValue}";
gauge.paramOrValueStop  = "${IndustrialValues.MaxValue}";
gauge.paramOrValue      = "${IndustrialValues.CurrentValue}";
```

La runtime, motorul hărții rezolvă fiecare placeholder pe baza proprietății corespunzătoare din `StreamPoint` și actualizează gauge-ul.

---

### Implementation Example

```csharp
map.Geometric.Points.Appearance(
    points: myStreamPoints,
    appearance: point => new GaugeChart
    {
        title = "Temperatură",
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

Obiectul `StreamPoint` legat de gauge trebuie să includă câmpurile de date relevante referite prin placeholder-uri:

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

- Dacă `paramOrValueStart`, `paramOrValueStop` sau `paramOrValue` sunt lăsate `null`, gauge-ul poate să nu se randeze corect — asigurați-vă că toate trei sunt setate.
- Proprietatea `visibilityZoomLevels` controlează la ce niveluri de zoom apare gauge-ul, prevenind aglomerarea vizuală la scări nepotrivite.
- O imagine indicator personalizată setată prin `urlIndicator` trebuie să fie un fișier grafic mic, accesibil web (recomandat PNG sau SVG). Dacă este omisă, se folosește indicatorul ac implicit.

