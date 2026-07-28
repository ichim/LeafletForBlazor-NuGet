# .NET MAUI Blazor Hybrid App

Adding the Map component:

    <Map
         height="calc(100vh - 2rem)"
         width="calc(100vw - 2rem)"
         />


Default configuration parameters:


    @code {
            LoadParameters loadParameters = new LoadParameters()
            {
                location = new Location()                                               //Center of the Map View
                {
                    latitude = 45.2852939016828,
                    longitude = 27.972121962159605
                },
                zoomLevel = 14,
                mapControls = new MapControls()
                {
                    layerList = new LayerList()                                         //LayersList control
                    {
                        position = Position.topRight
                    },
                    scaleBar = new ScaleBar()                                           //Map Scale Bar
                    {
                        position = Position.bottomRight,
                        unitOfScaleBar = UnitOfScaleBar.metric
                    },
                }
            };
         }
