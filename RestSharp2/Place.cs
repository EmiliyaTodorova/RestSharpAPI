using System.Text.Json.Serialization;

namespace RestSharp2
{
    public class Place
    {
        [JsonPropertyName ("place name")]
        public string PlaceName { get; set; }

        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }
        public string State { get; set; }
        public string StateAbbreviation { get; set; }
        public string Latitude { get; set; }


    }
}