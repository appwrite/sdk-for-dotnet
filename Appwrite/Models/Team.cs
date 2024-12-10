
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Team
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("prefs")]
        public Preferences Prefs { get; private set; }

        public Team(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            long total,
            Preferences prefs
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
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
            prefs: Preferences.From(map: ((JObject)map["prefs"]).ToObject<Dictionary<string, object>>()!)
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "total", Total },
            { "prefs", Prefs.ToMap() }
        };
    }
}