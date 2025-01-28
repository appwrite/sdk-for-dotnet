
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Index
    {
        [JsonProperty("key")]
        public string Key { get; private set; }

        [JsonProperty("type")]
        public string Type { get; private set; }

        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("error")]
        public string Error { get; private set; }

        [JsonProperty("attributes")]
        public List<string> Attributes { get; private set; }

        [JsonProperty("orders")]
        public List<string>? Orders { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        public Index(
            string key,
            string type,
            string status,
            string error,
            List<string> attributes,
            List<string>? orders,
            string createdAt,
            string updatedAt
        ) {
            Key = key;
            Type = type;
            Status = status;
            Error = error;
            Attributes = attributes;
            Orders = orders;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public static Index From(Dictionary<string, object> map) => new Index(
            key: map["key"].ToString(),
            type: map["type"].ToString(),
            status: map["status"].ToString(),
            error: map["error"].ToString(),
            attributes:                        ((JArray)map["attributes"]).ToObject<List<string>>()
,
            orders:                        ((JArray)map["orders"]).ToObject<List<string>>()
,
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "type", Type },
            { "status", Status },
            { "error", Error },
            { "attributes", Attributes },
            { "orders", Orders },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt }
        };
    }
}