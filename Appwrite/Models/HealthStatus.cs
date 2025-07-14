
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class HealthStatus
    {
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("ping")]
        public long Ping { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        public HealthStatus(
            string name,
            long ping,
            string status
        ) {
            Name = name;
            Ping = ping;
            Status = status;
        }

        public static HealthStatus From(Dictionary<string, object> map) => new HealthStatus(
            name: map["name"].ToString(),
            ping: Convert.ToInt64(map["ping"]),
            status: map["status"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "name", Name },
            { "ping", Ping },
            { "status", Status }
        };
    }
}
