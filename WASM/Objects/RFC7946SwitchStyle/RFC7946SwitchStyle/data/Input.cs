namespace FromObjectsSwitch.data
{
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Text.Json.Serialization;



    public class LayerPayload
    {
        [JsonPropertyName("data")]
        public List<Feature> Data { get; set; } = new();

        [JsonPropertyName("appearance")]
        public AppearanceConfig Appearance { get; set; } = new();
    }

    public class Feature
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("geometry")]
        public Geometry Geometry { get; set; } = new();

        [JsonPropertyName("properties")]
        public Dictionary<string, object?>? Properties { get; set; }
    }

    public class Geometry
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        // Polygon: inel exterior → perechi [lng, lat]
        // MultiPolygon ar necesita un nivel în plus; pentru cazul tău actual e suficient
        [JsonPropertyName("coordinates")]
        public List<List<List<double>>> Coordinates { get; set; } = new();
    }

    public class AppearanceConfig
    {
        [JsonPropertyName("switch")]
        public SwitchAppearance Switch { get; set; } = new();
    }

    public class SwitchAppearance
    {
        [JsonPropertyName("fieldName")]
        public string FieldName { get; set; } = string.Empty;

        [JsonPropertyName("classes")]
        public List<ClassEntry> Classes { get; set; } = new();

        [JsonPropertyName("default")]
        public LegendStyle Default { get; set; } = new();
    }

    public class ClassEntry
    {
        [JsonPropertyName("fieldValue")]
        public string FieldValue { get; set; } = string.Empty;

        [JsonPropertyName("style")]
        public LegendStyle Style { get; set; } = new();
    }

    public class LegendStyle
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("color")]
        public string? Color { get; set; }

        [JsonPropertyName("fillColor")]
        public string? FillColor { get; set; }

        [JsonPropertyName("weight")]
        public double Weight { get; set; }

        [JsonPropertyName("opacity")]
        public double Opacity { get; set; }
    }

    public class InputData
    {
        LayerPayload? payload;
        public InputData()
        {
            string json = @"{""data"":[{""type"":""Feature"",""geometry"":{""type"":""Polygon"",""coordinates"":[[[26.0931846,44.4432512],[26.0945783,44.4435381],[26.0959206,44.4438006],[26.0965448,44.4439288],[26.0979042,44.4444598],[26.0981265,44.4439044],[26.0976905,44.4436419],[26.0972459,44.4431657],[26.0963396,44.4427384],[26.0941508,44.4420181],[26.0931846,44.4432512]]]},""properties"":{""name"":""commercial""}},{""type"":""Feature"",""geometry"":{""type"":""Polygon"",""coordinates"":[[[26.097235848029676,44.44316478725016],[26.09633208661628,44.44271975813515],[26.09423069670424,44.441993162649126],[26.095637317464323,44.44091584999522],[26.096423785019127,44.44126092612807],[26.09733129728055,44.44214588472592],[26.097285844005754,44.443051214900585],[26.097235848029676,44.44316478725016]]]},""properties"":{""name"":""residential""}}],""appearance"":{""switch"":{""fieldName"":""name"",""classes"":[{""fieldValue"":""commercial"",""style"":{""title"":""Markets"",""color"":""indigo"",""fillColor"":""orange"",""weight"":2,""opacity"":0.8}},{""fieldValue"":""residential"",""style"":{""title"":""Residential"",""color"":""green"",""fillColor"":""yellow"",""weight"":4,""opacity"":1}}],""default"":{""title"":""Other"",""color"":""gray"",""weight"":2,""opacity"":0.8}}}}";
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            payload = JsonSerializer.Deserialize<LayerPayload>(json, options)!;
        }



        public LayerPayload Get
        {
            get { return payload; }

        }


    }



}
