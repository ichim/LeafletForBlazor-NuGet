namespace FromObjectsSwitch.data
{
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Text.Json.Serialization;






    public class LayerPayloadSimple
    {
        [JsonPropertyName("data")]
        public List<FeatureSimple> Data { get; set; }

        [JsonPropertyName("appearance")]
        public AppearanceConfigSimple Appearance { get; set; }
    }

    public class FeatureSimple
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("geometry")]
        public GeometrySimple Geometry { get; set; }

        [JsonPropertyName("properties")]
        public FeaturePropertiesSimple Properties { get; set; }
    }

    public class GeometrySimple
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("coordinates")]
        public List<double> Coordinates { get; set; }
    }

    public class FeaturePropertiesSimple
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class AppearanceConfigSimple
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("iconUrl")]
        public string IconUrl { get; set; }

        [JsonPropertyName("shadowUrl")]
        public string ShadowUrl { get; set; }

        [JsonPropertyName("iconSize")]
        public List<int> IconSize { get; set; }

        [JsonPropertyName("shadowSize")]
        public List<int> ShadowSize { get; set; }

        [JsonPropertyName("iconAnchor")]
        public List<int> IconAnchor { get; set; }

        [JsonPropertyName("shadowAnchor")]
        public List<int> ShadowAnchor { get; set; }

        [JsonPropertyName("popupAnchor")]
        public List<int> PopupAnchor { get; set; }

        [JsonPropertyName("rotation")]
        public double Rotation { get; set; }
    }

    public class InputData
    {
        LayerPayloadSimple? payload;
        public InputData()
        {
            string json = @"{""data"":[{""type"":""Feature"",""geometry"":{""type"":""Point"",""coordinates"":[26.098369,44.4448446]},""properties"":{""name"":""BeautifulMemoriesStore""}},{""type"":""Feature"",""geometry"":{""type"":""Point"",""coordinates"":[26.0968,44.444648]},""properties"":{""name"":""AmzeiMarket""}}],""appearance"":{""title"":""Retails&Market"",""iconUrl"":""http://localhost:5224/icons/shopping-cart.png"",""shadowUrl"":""http://localhost:5224/icons/shopping-cart.png"",""iconSize"":[16,16],""shadowSize"":[16,16],""iconAnchor"":[16,16],""shadowAnchor"":[16,16],""popupAnchor"":[0,0],""rotation"":90}}";
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            payload = JsonSerializer.Deserialize<LayerPayloadSimple>(json, options)!;
        }



        public LayerPayloadSimple Get
        {
            get { return payload; }

        }


    }

}
