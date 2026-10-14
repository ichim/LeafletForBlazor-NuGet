# LoadParameters class

Default configurations are available: the center of the current map view, zoom level, visibility of the attribution control, base map layers, and map controls, such as the scale control.

**Center of the current map view**

    LoadParameters loadParameters = new()
    {
        location = new Location()                                               //Default center of the Map View
        {
            latitude = 50.83112274500208,
            longitude = 4.407353347319803
        },
    };

**Zoom Level**

    LoadParameters loadParameters = new()
    {
        zoomLevel = 10                                                          //Default zoom level
    };

## Map Controls

You can configure map controls (Leaflet.js) such as: the layer list and scale bar:

        LoadParameters loadParameters = new LoadParameters()
        {
            mapControls = new MapControls()
            {
                layerList = new LayerList() { position = Position.topRight },       //Layer List Control
                scaleBar = new ScaleBar()                                           //Map Scale Bar
                {
                    position = Position.bottomRight,
                    unitOfScaleBar = UnitOfScaleBar.metric
                },
            }
        };

## Basemap Layers

Gets or sets the collection of basemap tile layers. Each layer is defined by a display title and a tile URL template containing {z}/{x}/{y} placeholders. Multiple layers enable runtime switching via the map's layer control.

[more about Basemap Layers](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Basic/Basemaps#basemap-layers)
