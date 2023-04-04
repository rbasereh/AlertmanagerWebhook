using System.Text.Json.Serialization;

namespace AlertmanagerWebhook.Model
{
    public partial class Annotations
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("summary")]
        public string Summary { get; set; }
    }
}
