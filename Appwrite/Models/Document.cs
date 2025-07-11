
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class Document
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$sequence")]
        public long Sequence { get; private set; }

        [JsonPropertyName("$collectionId")]
        public string CollectionId { get; private set; }

        [JsonPropertyName("$databaseId")]
        public string DatabaseId { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("$permissions")]
        public List<string> Permissions { get; private set; }

        public Dictionary<string, object> Data { get; private set; }

        public Document(
            string id,
            long sequence,
            string collectionId,
            string databaseId,
            string createdAt,
            string updatedAt,
            List<string> permissions,
            Dictionary<string, object> data
        ) {
            Id = id;
            Sequence = sequence;
            CollectionId = collectionId;
            DatabaseId = databaseId;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Permissions = permissions;
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
            data: map
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$sequence", Sequence },
            { "$collectionId", CollectionId },
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
