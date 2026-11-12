namespace FromObjectsSwitch.data
{
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class FeatureCollectionRFC7946 : List<FeatureRFC7946>
    {
    }

    public class FeatureRFC7946
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("geometry")]
        public GeometryRFC7946 Geometry { get; set; }

        [JsonPropertyName("properties")]
        public Dictionary<string, JsonElement>? Properties { get; set; }
    }

    public class GeometryRFC7946
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Structura coordonatelor variază în funcție de <see cref="Type"/>:
        /// <list type="bullet">
        ///   <item><b>Point</b>: [lon, lat]</item>
        ///   <item><b>LineString</b>: [[lon, lat], [lon, lat], ...]</item>
        ///   <item><b>Polygon</b>: [[[lon, lat], ...], ...]</item>
        ///   <item><b>MultiPoint</b>: [[lon, lat], ...]</item>
        ///   <item><b>MultiLineString</b>: [[[lon, lat], ...], ...]</item>
        ///   <item><b>MultiPolygon</b>: [[[[lon, lat], ...], ...], ...]</item>
        /// </list>
        /// </summary>
        [JsonPropertyName("coordinates")]
        public JsonElement Coordinates { get; set; }
    }

    public class InputRFC7946
    {
        FeatureCollectionRFC7946? collection;
        public InputRFC7946()
        {
            string jsonString = @"[{""type"":""Feature"",""geometry"":{""type"":""LineString"",""coordinates"":[[26.095369,44.444444],[26.097369,44.444644]]},""properties"":{""name"":""ConnectionInput4""}},{""type"":""Feature"",""geometry"":{""type"":""Polygon"",""coordinates"":[[[26.0931846,44.4432524],[26.0945783,44.4435381],[26.0959206,44.4438006],[26.0965448,44.4439288],[26.0979042,44.4444598],[26.0981265,44.4439044],[26.0976905,44.4436419],[26.0972459,44.4431657],[26.0963396,44.4427384],[26.0941508,44.4420181],[26.0931846,44.4432524]]]},""properties"":{""name"":""PoligonInput4""}}]";
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };


            var features = JsonSerializer.Deserialize<List<FeatureRFC7946>>(jsonString, options);


            collection = new FeatureCollectionRFC7946();
            if (features != null)
            {
                collection.AddRange(features);
            }
        }

        public FeatureCollectionRFC7946 Get
        {
            get { return collection ?? new FeatureCollectionRFC7946(); }
        }
    }

}
