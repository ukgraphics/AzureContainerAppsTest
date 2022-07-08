using System.Text.Json.Serialization;

namespace BlazorServerApp1.Data
{
    public class Album
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("artist")]
        public string? Artist { get; set; }

        [JsonPropertyName("price")]
        public double Price { get; set; }

        [JsonPropertyName("image_url")]
        public string? Image_url { get; set; }

    }
}
