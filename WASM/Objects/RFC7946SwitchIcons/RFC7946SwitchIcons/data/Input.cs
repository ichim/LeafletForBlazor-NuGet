namespace FromObjectsSwitch.data
{
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Text.Json.Serialization;





    public class LayerPayloadÍcons
    {
        [JsonPropertyName("data")]
        public List<FeatureIcons> Data { get; set; } = new();

        [JsonPropertyName("appearance")]
        public AppearanceConfigIcons Appearance { get; set; } = new();
    }

    public class FeatureIcons
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("geometry")]
        public GeometryIcons Geometry { get; set; } = new();

        [JsonPropertyName("properties")]
        public Dictionary<string, object?>? Properties { get; set; }
    }

    public class GeometryIcons
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        // Point: [longitudine, latitudine]
        [JsonPropertyName("coordinates")]
        public List<double> Coordinates { get; set; } = new();
    }

    public class AppearanceConfigIcons
    {
        [JsonPropertyName("switch")]
        public SwitchAppearanceIcons Switch { get; set; } = new();
    }

    public class SwitchAppearanceIcons
    {
        [JsonPropertyName("fieldName")]
        public string FieldName { get; set; } = string.Empty;

        [JsonPropertyName("classes")]
        public List<ClassEntryIcons> Classes { get; set; } = new();

        [JsonPropertyName("default")]
        public PointStyleIcons? Default { get; set; }
    }

    public class ClassEntryIcons
    {
        [JsonPropertyName("fieldValue")]
        public string FieldValue { get; set; } = string.Empty;

        [JsonPropertyName("style")]
        public PointStyleIcons Style { get; set; } = new();
    }

    public class PointStyleIcons
    {
        // Etichetă legendă
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        // --- CircleMarker style ---
        [JsonPropertyName("color")]
        public string? Color { get; set; }

        [JsonPropertyName("fillColor")]
        public string? FillColor { get; set; }

        [JsonPropertyName("weight")]
        public double? Weight { get; set; }

        [JsonPropertyName("opacity")]
        public double? Opacity { get; set; }

        [JsonPropertyName("radius")]
        public double? Radius { get; set; }

        // --- Icon style ---
        [JsonPropertyName("iconUrl")]
        public string? IconUrl { get; set; }

        [JsonPropertyName("iconSize")]
        public List<int>? IconSize { get; set; }

        [JsonPropertyName("shadowSize")]
        public List<int>? ShadowSize { get; set; }

        [JsonPropertyName("iconAnchor")]
        public List<int>? IconAnchor { get; set; }

        [JsonPropertyName("shadowAnchor")]
        public List<int>? ShadowAnchor { get; set; }

        [JsonPropertyName("popupAnchor")]
        public List<int>? PopupAnchor { get; set; }

        [JsonPropertyName("rotation")]
        public double? Rotation { get; set; }
    }





    public class InputData
    {
        LayerPayloadÍcons? payload;
        public InputData()
        {
            string json = @"{""data"":[{""type"":""Feature"",""geometry"":{""type"":""Point"",""coordinates"":[26.097369,44.4448446]},""properties"":{""type"":""Market""}},{""type"":""Feature"",""geometry"":{""type"":""Point"",""coordinates"":[26.095369,44.444648]},""properties"":{""type"":""Museum""}},{""type"":""Feature"",""geometry"":{""type"":""Point"",""coordinates"":[26.096369,44.442648]},""properties"":{""type"":""Unknown""}}],""appearance"":{""switch"":{""fieldName"":""type"",""classes"":[{""fieldValue"":""Market"",""style"":{""title"":""Markets"",""iconUrl"":""http://localhost:5234/icons/shopping-cart.png"",""iconSize"":[16,16],""shadowSize"":[16,16],""iconAnchor"":[16,16],""shadowAnchor"":[16,16],""popupAnchor"":[0,0],""rotation"":0}},{""fieldValue"":""Museum"",""style"":{""title"":""Museums"",""iconUrl"":""http://localhost:5234/icons/museum.png"",""iconSize"":[16,16],""shadowSize"":[16,16],""iconAnchor"":[16,16],""shadowAnchor"":[16,16],""popupAnchor"":[0,0],""rotation"":0}},{""fieldValue"":""Unknown"",""style"":{""title"":""Unknown"",""color"":""indigo"",""fillColor"":""green"",""weight"":2,""opacity"":0.8,""radius"":10}}]}}}";
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            payload = JsonSerializer.Deserialize<LayerPayloadÍcons>(json, options)!;
        }



        public LayerPayloadÍcons Get
        {
            get { return payload; }

        }


    }





}
