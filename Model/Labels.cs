using System.Text.Json.Serialization;

namespace AlertmanagerWebhook.Model
{
    public partial class Labels
    {
        [JsonPropertyName("alertname")]
        public string Alertname { get; set; }

        [JsonPropertyName("instance")]
        public string Instance { get; set; }

        [JsonPropertyName("job")]
        public string Job { get; set; }

        [JsonPropertyName("severity")]
        public string Severity { get; set; }
    }
}
