
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Index
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("status")]
        public IndexStatus Status { get; private set; }

        [JsonPropertyName("error")]
        public string Error { get; private set; }

        [JsonPropertyName("attributes")]
        public List<string> Attributes { get; private set; }

        [JsonPropertyName("lengths")]
        public List<long> Lengths { get; private set; }

        [JsonPropertyName("orders")]
        public List<string>? Orders { get; private set; }

        public Index(
            string id,
            string createdAt,
            string updatedAt,
            string key,
            string type,
            IndexStatus status,
            string error,
            List<string> attributes,
            List<long> lengths,
            List<string>? orders
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Key = key;
            Type = type;
            Status = status;
            Error = error;
            Attributes = attributes;
            Lengths = lengths;
            Orders = orders;
        }

        public static Index From(Dictionary<string, object> map) => new Index(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            key: map["key"].ToString(),
            type: map["type"].ToString(),
            status: new IndexStatus(map["status"].ToString()!),
            error: map["error"].ToString(),
            attributes: map["attributes"].ConvertToList<string>(),
            lengths: map["lengths"].ConvertToList<long>(),
            orders: map["orders"].ConvertToList<string>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "key", Key },
            { "type", Type },
            { "status", Status.Value },
            { "error", Error },
            { "attributes", Attributes },
            { "lengths", Lengths },
            { "orders", Orders }
        };
    }
}
