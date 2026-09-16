
# Toolbar Items

## Toggle

A toggle is a check/uncheck component that can be hosted in a toolbar.


    <Map height="calc(100vh)" width="calc(100vw)">
        <Toolbar left="48px" top="12px">
            <Toggle className="toggle-cheerful" Toggled="!isToggled" ToggledChanged="OnToggleChanged" />
        </Toolbar>
    </Map>
    @code {
        private bool isToggled;
        private void OnToggleChanged(bool value)
        {
            isToggled = value;
        }  
    }
