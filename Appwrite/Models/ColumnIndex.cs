
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class ColumnIndex
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
        public string Status { get; private set; }

        [JsonPropertyName("error")]
        public string Error { get; private set; }

        [JsonPropertyName("columns")]
        public List<string> Columns { get; private set; }

        [JsonPropertyName("lengths")]
        public List<long> Lengths { get; private set; }

        [JsonPropertyName("orders")]
        public List<string>? Orders { get; private set; }

        public ColumnIndex(
            string id,
            string createdAt,
            string updatedAt,
            string key,
            string type,
            string status,
            string error,
            List<string> columns,
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
            Columns = columns;
            Lengths = lengths;
            Orders = orders;
        }

        public static ColumnIndex From(Dictionary<string, object> map) => new ColumnIndex(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            key: map["key"].ToString(),
            type: map["type"].ToString(),
            status: map["status"].ToString(),
            error: map["error"].ToString(),
            columns: map["columns"] is JsonElement jsonArrayProp8 ? jsonArrayProp8.Deserialize<List<string>>()! : (List<string>)map["columns"],
            lengths: map["lengths"] is JsonElement jsonArrayProp9 ? jsonArrayProp9.Deserialize<List<long>>()! : (List<long>)map["lengths"],
            orders: map["orders"] is JsonElement jsonArrayProp10 ? jsonArrayProp10.Deserialize<List<string>>()! : (List<string>)map["orders"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "key", Key },
            { "type", Type },
            { "status", Status },
            { "error", Error },
            { "columns", Columns },
            { "lengths", Lengths },
            { "orders", Orders }
        };
    }
}
