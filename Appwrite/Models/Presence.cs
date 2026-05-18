
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Presence
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("$permissions")]
        public List<string> Permissions { get; private set; }

        [JsonPropertyName("userId")]
        public string UserId { get; private set; }

        [JsonPropertyName("status")]
        public string? Status { get; private set; }

        [JsonPropertyName("source")]
        public string Source { get; private set; }

        [JsonPropertyName("expiresAt")]
        public string? ExpiresAt { get; private set; }

        public Dictionary<string, object> Metadata { get; private set; }

        public Presence(
            string id,
            string createdAt,
            string updatedAt,
            List<string> permissions,
            string userId,
            string? status,
            string source,
            string? expiresAt,
            Dictionary<string, object> metadata
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Permissions = permissions;
            UserId = userId;
            Status = status;
            Source = source;
            ExpiresAt = expiresAt;
            Metadata = metadata;
        }

        public static Presence From(Dictionary<string, object> map) => new Presence(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            permissions: map["$permissions"].ConvertToList<string>(),
            userId: map["userId"].ToString(),
            status: map.TryGetValue("status", out var status) ? status?.ToString() : null,
            source: map["source"].ToString(),
            expiresAt: map.TryGetValue("expiresAt", out var expiresAt) ? expiresAt?.ToString() : null,
            metadata: map.TryGetValue("metadata", out var additionalPropsValue)
                ? (Dictionary<string, object>)additionalPropsValue
                : map
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "$permissions", Permissions },
            { "userId", UserId },
            { "status", Status },
            { "source", Source },
            { "expiresAt", ExpiresAt },
            { "metadata", Metadata }
        };

        public T ConvertTo<T>(Func<Dictionary<string, object>, T> fromJson) =>
            fromJson.Invoke(Metadata);
    }
}
