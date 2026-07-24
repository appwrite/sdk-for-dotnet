
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DatabaseStatusReplica
    {
        [JsonPropertyName("index")]
        public long Index { get; private set; }

        [JsonPropertyName("role")]
        public string Role { get; private set; }

        [JsonPropertyName("healthy")]
        public bool Healthy { get; private set; }

        [JsonPropertyName("lagSeconds")]
        public double? LagSeconds { get; private set; }

        public DatabaseStatusReplica(
            long index,
            string role,
            bool healthy,
            double? lagSeconds
        )
        {
            Index = index;
            Role = role;
            Healthy = healthy;
            LagSeconds = lagSeconds;
        }

        public static DatabaseStatusReplica From(Dictionary<string, object> map) => new DatabaseStatusReplica(
            index: Convert.ToInt64(map["index"]),
            role: map["role"].ToString(),
            healthy: (bool)map["healthy"],
            lagSeconds: map.TryGetValue("lagSeconds", out var numberRaw4) && numberRaw4 != null
                                    ? Convert.ToDouble(numberRaw4)
                                    : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "index", Index },
            { "role", Role },
            { "healthy", Healthy },
            { "lagSeconds", LagSeconds }
        };
    }
}
