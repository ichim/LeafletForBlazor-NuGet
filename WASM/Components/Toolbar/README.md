
# Toolbar
The Toolbar it is a map component that allows for expansion with various buttons and even tools.
 
    <Map height="calc(100vh)" width="calc(100vw)">
        <Toolbar  left="48px" top="12px">
        </Toolbar>
    </Map>

   Inside ``Map``, a ``Toolbar`` is placed as an absolute-positioned overlay at **left** and **top** relative to the map container.

## Toolbar parameters

| Parameter | Description |
|----|----|
| left | distance from the right edge of the map |
| top | distance from the top edge of the map |
| height | button dimensions (height/width) in pixels |

## Configuring the toolbar

Adding a button to the toolbar:

    <Map height="calc(100vh)" width="calc(100vw)">
        <Toolbar  left="48px" top="12px">
           <button @onclick="ZoomIn" title="Zoom in">＋</button>
        </Toolbar>
    </Map>
    @code {
        private async Task ZoomIn()
        {
        }
    }
# Toolbar Items

These are components that can be hosted by the Toolbar alongside HTML components.

[more about Toolbar items](https://github.com/ichim/LeafletForBlazor-NuGet/blob/main/WASM/Components/Toolbar/ToolbarItems/README.md#toolbar-items)
