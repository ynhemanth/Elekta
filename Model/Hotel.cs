using System.Text.Json.Serialization;

namespace Elekta.Model
{
    public class Hotel
    {
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("rating")]
        public int Rating { get; set; }
    }
}
