
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Provider
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("provider")]
        public string Provider { get; private set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; private set; }

        [JsonProperty("type")]
        public string Type { get; private set; }

        [JsonProperty("credentials")]
        public object Credentials { get; private set; }

        [JsonProperty("options")]
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
            Provider = provider;
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
            options: map["options"]?.ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "provider", Provider },
            { "enabled", Enabled },
            { "type", Type },
            { "credentials", Credentials },
            { "options", Options }
        };
    }
}