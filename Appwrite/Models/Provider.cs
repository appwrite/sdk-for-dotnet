
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class Provider
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("provider")]
        public string MessagingProvider { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("credentials")]
        public object Credentials { get; private set; }

        [JsonPropertyName("options")]
        public object? Options { get; private set; }

        public Provider(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            string provider,
            bool enabled,
            string type,
            object credentials,
            object? options
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            MessagingProvider = provider;
            Enabled = enabled;
            Type = type;
            Credentials = credentials;
            Options = options;
        }

        public static Provider From(Dictionary<string, object> map) => new Provider(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            name: map["name"].ToString(),
            provider: map["provider"].ToString(),
            enabled: (bool)map["enabled"],
            type: map["type"].ToString(),
            credentials: map["credentials"].ToString(),
            options: map.TryGetValue("options", out var options) ? options?.ToString() : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "provider", MessagingProvider },
            { "enabled", Enabled },
            { "type", Type },
            { "credentials", Credentials },
            { "options", Options }
        };
    }
}
