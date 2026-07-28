# .NET MAUI Blazor Hybrid App

Adding to _Imports.razor

    @using LeafletForBlazor
    @using static LeafletForBlazor.Map
    @using static LeafletForBlazor.techs.maps.Leaflet


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

Settings Map parameters:


    <Map loadParameters="@loadParameters"
         height="calc(100vh - 4rem)"
         width="calc(100vw - 2rem)" />
