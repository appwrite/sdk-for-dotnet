
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Variable
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("key")]
        public string Key { get; private set; }

        [JsonProperty("value")]
        public string Value { get; private set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; private set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; private set; }

        public Variable(
            string id,
            string createdAt,
            string updatedAt,
            string key,
            string xvalue,
            string resourceType,
            string resourceId
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Key = key;
            Value = xvalue;
            ResourceType = resourceType;
            ResourceId = resourceId;
        }

        public static Variable From(Dictionary<string, object> map) => new Variable(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            key: map["key"].ToString(),
            xvalue: map["value"].ToString(),
            resourceType: map["resourceType"].ToString(),
            resourceId: map["resourceId"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "key", Key },
            { "value", Value },
            { "resourceType", ResourceType },
            { "resourceId", ResourceId }
        };
    }
}