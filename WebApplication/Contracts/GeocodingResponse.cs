using System.Collections.Generic;
using System.Text.Json.Serialization;
using Refit;

namespace TestApp.Contracts
{
    public class GeocodingResponse
    {
        public IEnumerable<string> Query { get; set; }
        public IEnumerable<Feature> Features { get; set; }
    }

    public class Feature
    {
        public string Id { get; set; }
        public string Type { get; set; }
        [JsonPropertyName("place_type")]
        public IEnumerable<string> PlaceType { get; set; }
        public float Relevance { get; set; }
        public string Text { get; set; }
        [JsonPropertyName("place_name")]
        public string PlaceName { get; set; }

    }
}