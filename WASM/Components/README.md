
# Legend

The <Legend/> component displays a legend on the map, allowing users to quickly understand the meaning of the symbols and colors applied to data layers. In the current version, the legend is only available for GeoJSON files (at this moment).

## How to use

The component is placed as a child element of the <Map> component:

    <Map height="calc(100vh - 1rem)" width="calc(100vw - 2rem)">
        <Legend left="12px" top="80px"/>
    </Map>

## Parameters

| Parameter | Type      | Default | Description                                                                                                 |
| --------- | -------- | -------- | --------------------------------------------------------------------------------------------------------- |
| `left`    | `string` | `"10px"` | The distance from the left edge of the map. Accepts any valid CSS value (`px`, `%`, `rem`, etc.).     |
| `top`     | `string` | `"10px"` | The distance from the top edge of the map. Accepts any valid CSS value (`px`, `%`, `rem`, etc.). |
| `right`    | `string` | `"10px"` | The distance from the right edge of the map. Accepts any valid CSS value (`px`, `%`, `rem`, etc.).     |
| `bottom`     | `string` | `"10px"` | The distance from the bottom edge of the map. Accepts any valid CSS value (`px`, `%`, `rem`, etc.). |

## Observations

 - The legend positioning is absolute relative to the map container, so the left and top values ​​must be chosen carefully to avoid overlapping with other controls (zoom, assignment, etc.).
 - If dynamic repositioning is desired (e.g. for mobile devices), the values ​​can be passed via C# variables or custom CSS properties.
