
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
        public string Id { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("type")]
        public DatabaseType Type { get; private set; }

        public Database(
            string id,
            string name,
            string createdAt,
            string updatedAt,
            bool enabled,
            DatabaseType type
        ) {
            Id = id;
            Name = name;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Enabled = enabled;
            Type = type;
        }

        public static Database From(Dictionary<string, object> map) => new Database(
            id: map["$id"].ToString(),
            name: map["name"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            enabled: (bool)map["enabled"],
            type: new DatabaseType(map["type"].ToString()!)
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "name", Name },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "enabled", Enabled },
            { "type", Type.Value }
        };
    }
}
