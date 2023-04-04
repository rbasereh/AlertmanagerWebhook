using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace AlertmanagerWebhook.Model
{
    public partial class AlertManagerModel
    {
        [JsonPropertyName("receiver")]
        public string Receiver { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("alerts")]
        public Alert[] Alerts { get; set; }

        [JsonPropertyName("groupLabels")]
        public GroupLabels GroupLabels { get; set; }

        [JsonPropertyName("commonLabels")]
        public Labels CommonLabels { get; set; }

        [JsonPropertyName("commonAnnotations")]
        public Annotations CommonAnnotations { get; set; }

        [JsonPropertyName("externalURL")]
        public Uri ExternalUrl { get; set; }

        [JsonPropertyName("version")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public string Version { get; set; }

        [JsonPropertyName("groupKey")]
        public string GroupKey { get; set; }

        [JsonPropertyName("truncatedAlerts")]
        public long TruncatedAlerts { get; set; }
    }
}
