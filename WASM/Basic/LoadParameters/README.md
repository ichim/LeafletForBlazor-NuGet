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

