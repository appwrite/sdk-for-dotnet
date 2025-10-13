
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Row
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$sequence")]
        public long Sequence { get; private set; }

        [JsonPropertyName("$tableId")]
        public string TableId { get; private set; }

        [JsonPropertyName("$databaseId")]
        public string DatabaseId { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("$permissions")]
        public List<string> Permissions { get; private set; }

        public Dictionary<string, object> Data { get; private set; }

        public Row(
            string id,
            long sequence,
            string tableId,
            string databaseId,
            string createdAt,
            string updatedAt,
            List<string> permissions,
            Dictionary<string, object> data
        ) {
            Id = id;
            Sequence = sequence;
            TableId = tableId;
            DatabaseId = databaseId;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Permissions = permissions;
            Data = data;
        }

        public static Row From(Dictionary<string, object> map) => new Row(
            id: map["$id"].ToString(),
            sequence: Convert.ToInt64(map["$sequence"]),
            tableId: map["$tableId"].ToString(),
            databaseId: map["$databaseId"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            permissions: map["$permissions"].ConvertToList<string>(),
            data: map.TryGetValue("data", out var dataValue) ? (Dictionary<string, object>)dataValue : map
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$sequence", Sequence },
            { "$tableId", TableId },
            { "$databaseId", DatabaseId },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "$permissions", Permissions },
            { "data", Data }
        };

        public T ConvertTo<T>(Func<Dictionary<string, object>, T> fromJson) =>
            fromJson.Invoke(Data);
    }
}
