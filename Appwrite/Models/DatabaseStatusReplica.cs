
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

        [JsonPropertyName("replicating")]
        public bool? Replicating { get; private set; }

        [JsonPropertyName("lagSeconds")]
        public double? LagSeconds { get; private set; }

        public DatabaseStatusReplica(
            long index,
            string role,
            bool healthy,
            bool? replicating,
            double? lagSeconds
        )
        {
            Index = index;
            Role = role;
            Healthy = healthy;
            Replicating = replicating;
            LagSeconds = lagSeconds;
        }

        public static DatabaseStatusReplica From(Dictionary<string, object> map) => new DatabaseStatusReplica(
            index: Convert.ToInt64(map["index"]),
            role: map["role"].ToString(),
            healthy: (bool)map["healthy"],
            replicating: map.TryGetValue("replicating", out var boolRaw4) && boolRaw4 != null
                                        ? (bool?)boolRaw4
                                        : null,
            lagSeconds: map.TryGetValue("lagSeconds", out var numberRaw5) && numberRaw5 != null
                                    ? Convert.ToDouble(numberRaw5)
                                    : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "index", Index },
            { "role", Role },
            { "healthy", Healthy },
            { "replicating", Replicating },
            { "lagSeconds", LagSeconds }
        };
    }
}
