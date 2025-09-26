using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class Team
    {
        [JsonPropertyName("$id")]
        public string id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string createdAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string updatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("prefs")]
        public Preferences Prefs { get; private set; }

        public Team(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            long total,
            Preferences prefs
        ) {
            id = id;
            createdAt = createdAt;
            updatedAt = updatedAt;
            Name = name;
            Total = total;
            Prefs = prefs;
        }

        public static Team From(Dictionary<string, object> map) => new Team(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            name: map["name"].ToString(),
            total: Convert.ToInt64(map["total"]),
            prefs: Preferences.From(map: map["prefs"] is JsonElement jsonObj6 ? jsonObj6.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["prefs"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", id },
            { "$createdAt", createdAt },
            { "$updatedAt", updatedAt },
            { "name", Name },
            { "total", Total },
            { "prefs", Prefs.ToMap() }
        };
    }
}
