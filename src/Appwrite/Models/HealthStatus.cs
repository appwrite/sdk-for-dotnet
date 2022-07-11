
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class HealthStatus
    {
        [JsonProperty("ping")]
        public long Ping { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }


        public HealthStatus(
            long ping,
            string status
        ) {
            Ping = ping;
            Status = status;
        }

        public static HealthStatus From(Dictionary<string, object> map) => new HealthStatus(
            ping: Convert.ToInt64(map["ping"]),
            status: (string)map["status"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "ping", Ping },
            { "status", Status }
        };
    }
}