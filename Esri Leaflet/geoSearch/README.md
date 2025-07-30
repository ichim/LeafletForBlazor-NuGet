# GeoSearch Esri Task

To be able to use Esri tasks, you need to generate an Esri API Key Code (for free).

[Create Esri API Key Code Tutorial](https://developers.arcgis.com/documentation/security-and-authentication/api-key-authentication/tutorials/create-an-api-key/)

## Configuring Esri API Key Code in the application

    <RealTimeMap Parameters="parameters" height="calc(100vh - 6rem)" width="calc(100vw - 18rem)"></RealTimeMap>



    @code{
    RealTimeMap.LoadParameters parameters = new RealTimeMap.LoadParameters()
        {
            apiKeys = new RealTimeMap.APIKeys()
            {
                EsriAPIKey = "--Your Esri API Key Code--"
            },
        }
    }
