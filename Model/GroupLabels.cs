using System.Text.Json.Serialization;

namespace AlertmanagerWebhook.Model
{
    public partial class GroupLabels
    {
        [JsonPropertyName("alertname")]
        public string Alertname { get; set; }

        [JsonPropertyName("severity")]
        public string Severity { get; set; }
    }
}
