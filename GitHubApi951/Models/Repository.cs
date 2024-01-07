using System.Text.Json.Serialization;

namespace GitHubApi951.Models
{
    public class Repository
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

    }
}
