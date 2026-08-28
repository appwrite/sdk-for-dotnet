
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PostgresExtension
    {
        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("description")]
        public string Description { get; private set; }

        [JsonPropertyName("category")]
        public string Category { get; private set; }

        public PostgresExtension(
            string key,
            string name,
            string description,
            string category
        )
        {
            Key = key;
            Name = name;
            Description = description;
            Category = category;
        }

        public static PostgresExtension From(Dictionary<string, object> map) => new PostgresExtension(
            key: map["key"].ToString(),
            name: map["name"].ToString(),
            description: map["description"].ToString(),
            category: map["category"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "name", Name },
            { "description", Description },
            { "category", Category }
        };
    }
}
