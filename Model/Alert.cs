using System.Text.Json.Serialization;

namespace AlertmanagerWebhook.Model
{
    public partial class Alert
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("labels")]
        public Labels Labels { get; set; }

        [JsonPropertyName("annotations")]
        public Annotations Annotations { get; set; }

        [JsonPropertyName("startsAt")]
        public DateTimeOffset StartsAt { get; set; }

        [JsonPropertyName("endsAt")]
        public DateTimeOffset EndsAt { get; set; }

        [JsonPropertyName("generatorURL")]
        public Uri GeneratorUrl { get; set; }

        [JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }
    }
}
