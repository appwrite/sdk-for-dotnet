
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PlatformApple
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("type")]
        public PlatformType Type { get; private set; }

        [JsonPropertyName("bundleIdentifier")]
        public string BundleIdentifier { get; private set; }

        public PlatformApple(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            PlatformType type,
            string bundleIdentifier
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Type = type;
            BundleIdentifier = bundleIdentifier;
        }

        public static PlatformApple From(Dictionary<string, object> map) => new PlatformApple(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            name: map["name"].ToString(),
            type: new PlatformType(map["type"].ToString()!),
            bundleIdentifier: map["bundleIdentifier"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "type", Type.Value },
            { "bundleIdentifier", BundleIdentifier }
        };
    }
}
