# 🧭 Map configuration


The loadParameter parameter of the Map component allows you to configure the map at initialization. The initialization parameters are:

 - 📍 ``Location`` of the center of the displayed map (View of Map):
	
        location = new Location()
        {
            latitude = 45.2831589721668,
            longitude = 27.98740645063448
        },

- 🔍 ``Zoom Level``

					
		zoomLevel = 12,

- 🎛️ Configuring ``map controls``

        mapControls = new MapControls()
        {
            layerList = new LayerList() { position = Position.topRight },
            scaleBar = new ScaleBar()
            {
                position = Position.bottomRight,
                unitOfScaleBar = UnitOfScaleBar.metric
            },

- Attribution. Management of map attributes:

      LoadParameters loadParameters = new LoadParameters()
      {
          showAttribution = false,    //true implicit. if set to false, attributionControl will not be displayed
      }

