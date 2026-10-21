# Basemap Layers

Gets or sets the collection of basemap tile layers. Each layer is defined by a display title and a tile URL template containing {z}/{x}/{y} placeholders. Multiple layers enable runtime switching via the map's layer control.
```C#
    LoadParameters loadParameters = new LoadParameters()
    {
        location = new Location()                                               
        {
            latitude = 50.83112274500208,
            longitude = 4.407353347319803
        },
        zoomLevel = 10,
        /* Default Basemap Layers */
        basemapLayers = new List<BasemapLayer>()
        {
              new BasemapLayer()
              {
                  title = "Topo",
                  url = "https://{s}.tile.opentopomap.org/{z}/{x}/{y}.png"
              },
              new BasemapLayer()
              {
                  title = "EsriImagery",
                  url = "https://server.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer/tile/{z}/{y}/{x}"
              },
              new BasemapLayer()
              {
                  title = "DarkMap",
                  url = "https://{s}.basemaps.cartocdn.com/dark_all/{z}/{x}/{y}{r}.png"
              },
          }
    };
```
