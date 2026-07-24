
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AppScope
    {
        [JsonPropertyName("value")]
        public string Value { get; private set; }

        [JsonPropertyName("description")]
        public string Description { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("category")]
        public string Category { get; private set; }

        [JsonPropertyName("deprecated")]
        public bool Deprecated { get; private set; }

        public AppScope(
            string @value,
            string description,
            string type,
            string category,
            bool deprecated
        )
        {
            Value = @value;
            Description = description;
            Type = type;
            Category = category;
            Deprecated = deprecated;
        }

        public static AppScope From(Dictionary<string, object> map) => new AppScope(
            @value: map["value"].ToString(),
            description: map["description"].ToString(),
            type: map["type"].ToString(),
            category: map["category"].ToString(),
            deprecated: (bool)map["deprecated"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "value", Value },
            { "description", Description },
            { "type", Type },
            { "category", Category },
            { "deprecated", Deprecated }
        };
    }
}
