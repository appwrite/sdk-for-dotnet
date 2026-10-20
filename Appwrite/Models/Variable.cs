
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Variable
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("description")]
        public string Description { get; private set; }

        [JsonPropertyName("value")]
        public string Value { get; private set; }

        [JsonPropertyName("secret")]
        public bool Secret { get; private set; }

        [JsonPropertyName("resourceType")]
        public string ResourceType { get; private set; }

        [JsonPropertyName("resourceId")]
        public string ResourceId { get; private set; }

        public Variable(
            string id,
            string createdAt,
            string updatedAt,
            string key,
            string description,
            string @value,
            bool secret,
            string resourceType,
            string resourceId
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Key = key;
            Description = description;
            Value = @value;
            Secret = secret;
            ResourceType = resourceType;
            ResourceId = resourceId;
        }

        public static Variable From(Dictionary<string, object> map) => new Variable(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            key: (map.ContainsKey("key") ? map["key"] : "").ToString(),
            description: (map.ContainsKey("description") ? map["description"] : "").ToString(),
            @value: (map.ContainsKey("value") ? map["value"] : "").ToString(),
            secret: (bool)(map.ContainsKey("secret") ? map["secret"] : false),
            resourceType: (map.ContainsKey("resourceType") ? map["resourceType"] : "").ToString(),
            resourceId: (map.ContainsKey("resourceId") ? map["resourceId"] : "").ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "key", Key },
            { "description", Description },
            { "value", Value },
            { "secret", Secret },
            { "resourceType", ResourceType },
            { "resourceId", ResourceId }
        };
    }
}
