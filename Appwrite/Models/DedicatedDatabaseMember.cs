
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseMember
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("role")]
        public string Role { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        [JsonPropertyName("lagSeconds")]
        public double? LagSeconds { get; private set; }

        public DedicatedDatabaseMember(
            string id,
            string role,
            string status,
            double? lagSeconds
        )
        {
            Id = id;
            Role = role;
            Status = status;
            LagSeconds = lagSeconds;
        }

        public static DedicatedDatabaseMember From(Dictionary<string, object> map) => new DedicatedDatabaseMember(
            id: map["$id"].ToString(),
            role: map["role"].ToString(),
            status: map["status"].ToString(),
            lagSeconds: map.TryGetValue("lagSeconds", out var numberRaw4) && numberRaw4 != null
                                    ? Convert.ToDouble(numberRaw4)
                                    : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "role", Role },
            { "status", Status },
            { "lagSeconds", LagSeconds }
        };
    }
}
