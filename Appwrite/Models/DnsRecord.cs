
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DnsRecord
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("value")]
        public string Value { get; private set; }

        [JsonPropertyName("ttl")]
        public long Ttl { get; private set; }

        [JsonPropertyName("priority")]
        public long Priority { get; private set; }

        [JsonPropertyName("lock")]
        public bool Lock { get; private set; }

        [JsonPropertyName("weight")]
        public long Weight { get; private set; }

        [JsonPropertyName("port")]
        public long Port { get; private set; }

        [JsonPropertyName("comment")]
        public string Comment { get; private set; }

        public DnsRecord(
            string id,
            string createdAt,
            string updatedAt,
            string type,
            string name,
            string @value,
            long ttl,
            long priority,
            bool @lock,
            long weight,
            long port,
            string comment
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Type = type;
            Name = name;
            Value = @value;
            Ttl = ttl;
            Priority = priority;
            Lock = @lock;
            Weight = weight;
            Port = port;
            Comment = comment;
        }

        public static DnsRecord From(Dictionary<string, object> map) => new DnsRecord(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            type: map["type"].ToString(),
            name: map["name"].ToString(),
            @value: map["value"].ToString(),
            ttl: Convert.ToInt64(map["ttl"]),
            priority: Convert.ToInt64(map["priority"]),
            @lock: (bool)map["lock"],
            weight: Convert.ToInt64(map["weight"]),
            port: Convert.ToInt64(map["port"]),
            comment: map["comment"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "type", Type },
            { "name", Name },
            { "value", Value },
            { "ttl", Ttl },
            { "priority", Priority },
            { "lock", Lock },
            { "weight", Weight },
            { "port", Port },
            { "comment", Comment }
        };
    }
}
