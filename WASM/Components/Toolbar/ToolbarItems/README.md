
# Toolbar Items

These are components that can be hosted by the Toolbar alongside HTML components.

![Toggle](https://raw.githubusercontent.com/ichim/LeafletForBlazor-nuget/main/docs/images/ToolbarButtons.png)

## Toggle

A toggle is a check/uncheck component that can be hosted in a toolbar.


    <Map height="calc(100vh)" width="calc(100vw)">
        <MapComponents>
            <Toolbar left="48px" top="12px">
                <Toggle className="toggle-cheerful" Toggled="!isToggled" ToggledChanged="OnToggleChanged" />
            </Toolbar>
        </MapComponents>
    </Map>
    @code {
        private bool isToggled;
        private void OnToggleChanged(bool value)
        {
            isToggled = value;
        }  
    }

A different kind of implementation:

    <Map height="calc(100vh)" width="calc(100vw)">
        <MapComponents>
            <Toolbar left="48px" top="12px">
                <Toggle @bind-Toggled="isToggled" />
            </Toolbar>
        </MapComponents>
    </Map>
    @code {
      
        private bool isToggled;
    }
