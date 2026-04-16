
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Block
    {
        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("resourceType")]
        public string ResourceType { get; private set; }

        [JsonPropertyName("resourceId")]
        public string ResourceId { get; private set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; private set; }

        [JsonPropertyName("expiredAt")]
        public string? ExpiredAt { get; private set; }

        public Block(
            string createdAt,
            string resourceType,
            string resourceId,
            string? reason,
            string? expiredAt
        ) {
            CreatedAt = createdAt;
            ResourceType = resourceType;
            ResourceId = resourceId;
            Reason = reason;
            ExpiredAt = expiredAt;
        }

        public static Block From(Dictionary<string, object> map) => new Block(
            createdAt: map["$createdAt"].ToString(),
            resourceType: map["resourceType"].ToString(),
            resourceId: map["resourceId"].ToString(),
            reason: map.TryGetValue("reason", out var reason) ? reason?.ToString() : null,
            expiredAt: map.TryGetValue("expiredAt", out var expiredAt) ? expiredAt?.ToString() : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$createdAt", CreatedAt },
            { "resourceType", ResourceType },
            { "resourceId", ResourceId },
            { "reason", Reason },
            { "expiredAt", ExpiredAt }
        };
    }
}
