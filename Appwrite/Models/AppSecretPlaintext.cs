
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AppSecretPlaintext
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("appId")]
        public string AppId { get; private set; }

        [JsonPropertyName("secret")]
        public string Secret { get; private set; }

        [JsonPropertyName("hint")]
        public string Hint { get; private set; }

        [JsonPropertyName("createdById")]
        public string CreatedById { get; private set; }

        [JsonPropertyName("createdByName")]
        public string CreatedByName { get; private set; }

        [JsonPropertyName("lastAccessedAt")]
        public string? LastAccessedAt { get; private set; }

        public AppSecretPlaintext(
            string id,
            string createdAt,
            string updatedAt,
            string appId,
            string secret,
            string hint,
            string createdById,
            string createdByName,
            string? lastAccessedAt
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            AppId = appId;
            Secret = secret;
            Hint = hint;
            CreatedById = createdById;
            CreatedByName = createdByName;
            LastAccessedAt = lastAccessedAt;
        }

        public static AppSecretPlaintext From(Dictionary<string, object> map) => new AppSecretPlaintext(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            appId: map["appId"].ToString(),
            secret: map["secret"].ToString(),
            hint: map["hint"].ToString(),
            createdById: map["createdById"].ToString(),
            createdByName: map["createdByName"].ToString(),
            lastAccessedAt: map.TryGetValue("lastAccessedAt", out var lastAccessedAt) ? lastAccessedAt?.ToString() : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "appId", AppId },
            { "secret", Secret },
            { "hint", Hint },
            { "createdById", CreatedById },
            { "createdByName", CreatedByName },
            { "lastAccessedAt", LastAccessedAt }
        };
    }
}
