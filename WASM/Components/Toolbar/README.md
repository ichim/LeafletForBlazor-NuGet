
# Toolbar
The Toolbar it is a map component that allows for expansion with various buttons and even tools.
 
    <Map height="calc(100vh)" width="calc(100vw)">
        <Toolbar  left="48px" top="12px">
        </Toolbar>
    </Map>

   Inside ``Map``, a ``Toolbar`` is placed as an absolute-positioned overlay at **left** and **top** relative to the map container.

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
