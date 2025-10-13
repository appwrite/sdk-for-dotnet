
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class HealthAntivirus
    {
        [JsonPropertyName("version")]
        public string Version { get; private set; }

        [JsonPropertyName("status")]
        public HealthAntivirusStatus Status { get; private set; }

        public HealthAntivirus(
            string version,
            HealthAntivirusStatus status
        ) {
            Version = version;
            Status = status;
        }

        public static HealthAntivirus From(Dictionary<string, object> map) => new HealthAntivirus(
            version: map["version"].ToString(),
            status: new HealthAntivirusStatus(map["status"].ToString()!)
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "version", Version },
            { "status", Status.Value }
        };
    }
}
