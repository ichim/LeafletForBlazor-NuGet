# Esri Reverse Geocode Task

It is an [Esri](https://www.esri.com/en-us/home) task with which you can find the address of a location. In order to use this professional task, you must create a developer account on [ArcGIS.com](https://www.arcgis.com/index.html).

Reverse geocoding is the process of converting a location to an address or place. Esri Leaflet provides a geocoder to access the geocoding service.

## Configuring Esri API Key Code in the application

Blazor page:

    <RealTimeMap Parameters="parameters" height="calc(100vh - 6rem)" width="calc(100vw - 18rem)"></RealTimeMap>

Code block parameters:

    @code{
    RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()
        {
            apiKeys = new RealTimeMap.APIKeys()
            {
                EsriAPIKey = "--Your Esri API Key Code--"
            },
        }
    }
