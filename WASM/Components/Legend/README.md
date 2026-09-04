
# Legend

<img width="2284" height="1484" alt="image" src="https://github.com/user-attachments/assets/f8fac79e-2642-4785-8604-6f8bdc5b0bf8" />

## Adding the Legend

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

## How to use Legend

### Simple Legend

    <Map height="calc(100vh - 1rem)" width="calc(100vw - 2rem)">
        <Legend left="12px" top="80px"/>
    </Map>

### Configurable legend

    <Map @ref="map" height="calc(100vh - 2rem)" width="calc(100vw - 2rem)">
        <Legend left="12px" top="80px">
            <HeaderContent>
                <h2>Legend</h2>  //title
            </HeaderContent>
            <FooterContent>
                <label style="font-size:8px;font-style:italic;font-weight:100">You can add explanations.</label> //notes
            </FooterContent>
        </Legend>
     </Map>

