# 🧭 Map configuration


The loadParameter parameter of the Map component allows you to configure the map at initialization. The initialization parameters are:

 - 📍 ``Location`` of the center of the displayed map (View of Map):

```C#
      	LoadParameters loadParameters = new LoadParameters()
	    {
	        location = new Location() // Center of the Map View
	        {
	            latitude = 44.4435381,
	            longitude = 26.0945783,
	        },
	    };
```
- 🔍 ``Zoom Level``
```C#
	   LoadParameters loadParameters = new LoadParameters()
	   {
	       location = new Location() // Center of the Map View
	       {
	           latitude = 44.4435381,
	           longitude = 26.0945783,
	       },
	       zoomLevel = 14, //zoom level
	   };
```
- 🎛️ Configuring ``map controls``
```C#
	  LoadParameters loadParameters = new LoadParameters()
	  {
		    mapControls = new MapControls()
			{
				layerList = new LayerList() { position = Position.topRight },
				scaleBar = new ScaleBar()
				{
					position = Position.bottomRight,
					unitOfScaleBar = UnitOfScaleBar.metric
				},
	  		}
	  };
```    

- ℹ️ `Attribution`. Management of map attributes:
```C#
      LoadParameters loadParameters = new LoadParameters()
      {
          showAttribution = false,    //true implicit. if set to false, attributionControl will not be displayed
      }
```
[more about Attribution](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Basic/Attribution#%E2%84%B9%EF%B8%8F-attribution)

- Settings `Basemap` Layers

[more about Basemap Layers](https://github.com/ichim/LeafletForBlazor-NuGet/tree/main/WASM/Basic/Basemaps#basemap-layers)
