
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class HealthAntivirus
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }


        public HealthAntivirus(
            string version,
            string status
        ) {
            Version = version;
            Status = status;
        }

        public static HealthAntivirus From(Dictionary<string, object> map) => new HealthAntivirus(
            version: (string)map["version"],
            status: (string)map["status"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "version", Version },
            { "status", Status }
        };
    }
}