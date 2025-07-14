
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class Target
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("userId")]
        public string UserId { get; private set; }

        [JsonPropertyName("providerId")]
        public string? ProviderId { get; private set; }

        [JsonPropertyName("providerType")]
        public string ProviderType { get; private set; }

        [JsonPropertyName("identifier")]
        public string Identifier { get; private set; }

        [JsonPropertyName("expired")]
        public bool Expired { get; private set; }

        public Target(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            string userId,
            string? providerId,
            string providerType,
            string identifier,
            bool expired
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            UserId = userId;
            ProviderId = providerId;
            ProviderType = providerType;
            Identifier = identifier;
            Expired = expired;
        }

        public static Target From(Dictionary<string, object> map) => new Target(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            name: map["name"].ToString(),
            userId: map["userId"].ToString(),
            providerId: map.TryGetValue("providerId", out var providerId) ? providerId?.ToString() : null,
            providerType: map["providerType"].ToString(),
            identifier: map["identifier"].ToString(),
            expired: (bool)map["expired"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "userId", UserId },
            { "providerId", ProviderId },
            { "providerType", ProviderType },
            { "identifier", Identifier },
            { "expired", Expired }
        };
    }
}
