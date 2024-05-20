
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Document
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$collectionId")]
        public string CollectionId { get; private set; }

        [JsonProperty("$databaseId")]
        public string DatabaseId { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("$permissions")]
        public List<object> Permissions { get; private set; }

        public Dictionary<string, object> Data { get; private set; }

        public Document(
            string id,
            string collectionId,
            string databaseId,
            string createdAt,
            string updatedAt,
            List<object> permissions,
            Dictionary<string, object> data
        ) {
            Id = id;
            CollectionId = collectionId;
            DatabaseId = databaseId;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Permissions = permissions;
            Data = data;
        }

        public static Document From(Dictionary<string, object> map) => new Document(
            id: map["$id"].ToString(),
            collectionId: map["$collectionId"].ToString(),
            databaseId: map["$databaseId"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            permissions: ((JArray)map["$permissions"]).ToObject<List<object>>(),
            data: map
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
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