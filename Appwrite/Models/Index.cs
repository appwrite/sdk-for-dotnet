
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
        public List<object> Attributes { get; private set; }

        [JsonProperty("orders")]
        public List<object>? Orders { get; private set; }

        public Index(
            string key,
            string type,
            string status,
            string error,
            List<object> attributes,
            List<object>? orders
        ) {
            Key = key;
            Type = type;
            Status = status;
            Error = error;
            Attributes = attributes;
            Orders = orders;
        }

        public static Index From(Dictionary<string, object> map) => new Index(
            key: map["key"].ToString(),
            type: map["type"].ToString(),
            status: map["status"].ToString(),
            error: map["error"].ToString(),
            attributes: ((JArray)map["attributes"]).ToObject<List<object>>(),
            orders: ((JArray)map["orders"]).ToObject<List<object>>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "type", Type },
            { "status", Status },
            { "error", Error },
            { "attributes", Attributes },
            { "orders", Orders }
        };
    }
}