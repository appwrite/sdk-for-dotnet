using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class Database
    {
        [JsonPropertyName("$id")]
        public string id { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string createdAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string updatedAt { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        public Database(
            string id,
            string name,
            string createdAt,
            string updatedAt,
            bool enabled,
            string type
        ) {
            id = id;
            Name = name;
            createdAt = createdAt;
            updatedAt = updatedAt;
            Enabled = enabled;
            Type = type;
        }

        public static Database From(Dictionary<string, object> map) => new Database(
            id: map["$id"].ToString(),
            name: map["name"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            enabled: (bool)map["enabled"],
            type: map["type"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", id },
            { "name", Name },
            { "$createdAt", createdAt },
            { "$updatedAt", updatedAt },
            { "enabled", Enabled },
            { "type", Type }
        };
    }
}
