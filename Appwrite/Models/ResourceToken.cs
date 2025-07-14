
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class ResourceToken
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("resourceId")]
        public string ResourceId { get; private set; }

        [JsonPropertyName("resourceType")]
        public string ResourceType { get; private set; }

        [JsonPropertyName("expire")]
        public string Expire { get; private set; }

        [JsonPropertyName("secret")]
        public string Secret { get; private set; }

        [JsonPropertyName("accessedAt")]
        public string AccessedAt { get; private set; }

        public ResourceToken(
            string id,
            string createdAt,
            string resourceId,
            string resourceType,
            string expire,
            string secret,
            string accessedAt
        ) {
            Id = id;
            CreatedAt = createdAt;
            ResourceId = resourceId;
            ResourceType = resourceType;
            Expire = expire;
            Secret = secret;
            AccessedAt = accessedAt;
        }

        public static ResourceToken From(Dictionary<string, object> map) => new ResourceToken(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            resourceId: map["resourceId"].ToString(),
            resourceType: map["resourceType"].ToString(),
            expire: map["expire"].ToString(),
            secret: map["secret"].ToString(),
            accessedAt: map["accessedAt"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "resourceId", ResourceId },
            { "resourceType", ResourceType },
            { "expire", Expire },
            { "secret", Secret },
            { "accessedAt", AccessedAt }
        };
    }
}
