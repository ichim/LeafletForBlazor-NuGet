# Esri basemaps

RealTimeMap can use basemaps provided by [Esri](https://www.esri.com/en-us/home). To use this professional basemap resource, you must create a developer account on [ArcGIS.com](https://www.arcgis.com/index.html).

Configuring Esri basemaps:

    RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()
        {
            basemap = new RealTimeMap.Basemap()
            {
                basemapLayers = new List<RealTimeMap.BasemapLayer>()
                {
                    new RealTimeMap.BasemapLayer()
                    {
                        title = "Esri streets",
                        url = "arcgis/streets",
                        attribution = "© Esri streets",
                    },
                 }
            },
            apiKeys = new RealTimeMap.APIKeys()
            {   // These are example API keys, replace with your own
                // ArcGIS API Key
                //Create API key credentials for free
                //https://developers.arcgis.com/documentation/security-and-authentication/api-key-authentication/api-key-credentials/
                EsriAPIKey = "-YOUR Esri API key credentials-"
            }
        };
