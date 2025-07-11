
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class HealthAntivirus
    {
        [JsonPropertyName("version")]
        public string Version { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        public HealthAntivirus(
            string version,
            string status
        ) {
            Version = version;
            Status = status;
        }

        public static HealthAntivirus From(Dictionary<string, object> map) => new HealthAntivirus(
            version: map["version"].ToString(),
            status: map["status"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "version", Version },
            { "status", Status }
        };
    }
}
