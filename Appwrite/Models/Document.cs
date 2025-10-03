using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class Document
    {
        [JsonPropertyName("$id")]
        public string id { get; private set; }

        [JsonPropertyName("$sequence")]
        public long sequence { get; private set; }

        [JsonPropertyName("$collectionId")]
        public string collectionId { get; private set; }

        [JsonPropertyName("$databaseId")]
        public string databaseId { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string createdAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string updatedAt { get; private set; }

        [JsonPropertyName("$permissions")]
        public List&lt;string&gt; permissions { get; private set; }

        public Dictionary<string, object> Data { get; private set; }

        public Document(
            string id,
            long sequence,
            string collectionId,
            string databaseId,
            string createdAt,
            string updatedAt,
            List&lt;string&gt; permissions,
            Dictionary<string, object> data
        ) {
            id = id;
            sequence = sequence;
            collectionId = collectionId;
            databaseId = databaseId;
            createdAt = createdAt;
            updatedAt = updatedAt;
            permissions = permissions;
            Data = data;
        }

        public static Document From(Dictionary<string, object> map) => new Document(
            id: map["$id"].ToString(),
            sequence: Convert.ToInt64(map["$sequence"]),
            collectionId: map["$collectionId"].ToString(),
            databaseId: map["$databaseId"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            permissions: map["$permissions"] is JsonElement jsonArrayProp7 ? jsonArrayProp7.Deserialize<List<string>>()! : (List<string>)map["$permissions"],
            data: map.TryGetValue("data", out var dataValue) ? (Dictionary<string, object>)dataValue : map
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", id },
            { "$sequence", sequence },
            { "$collectionId", collectionId },
            { "$databaseId", databaseId },
            { "$createdAt", createdAt },
            { "$updatedAt", updatedAt },
            { "$permissions", permissions },
            { "data", Data }
        };

        public T ConvertTo<T>(Func<Dictionary<string, object>, T> fromJson) =>
            fromJson.Invoke(Data);
    }
}
