using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class Collection
    {
        [JsonPropertyName("$id")]
        public string id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string createdAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string updatedAt { get; private set; }

        [JsonPropertyName("$permissions")]
        public List&lt;string&gt; permissions { get; private set; }

        [JsonPropertyName("databaseId")]
        public string DatabaseId { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("documentSecurity")]
        public bool DocumentSecurity { get; private set; }

        [JsonPropertyName("attributes")]
        public List&lt;object&gt; Attributes { get; private set; }

        [JsonPropertyName("indexes")]
        public List&lt;Index&gt; Indexes { get; private set; }

        public Collection(
            string id,
            string createdAt,
            string updatedAt,
            List&lt;string&gt; permissions,
            string databaseId,
            string name,
            bool enabled,
            bool documentSecurity,
            List&lt;object&gt; attributes,
            List&lt;Index&gt; indexes
        ) {
            id = id;
            createdAt = createdAt;
            updatedAt = updatedAt;
            permissions = permissions;
            DatabaseId = databaseId;
            Name = name;
            Enabled = enabled;
            DocumentSecurity = documentSecurity;
            Attributes = attributes;
            Indexes = indexes;
        }

        public static Collection From(Dictionary<string, object> map) => new Collection(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            permissions: map["$permissions"] is JsonElement jsonArrayProp4 ? jsonArrayProp4.Deserialize<List<string>>()! : (List<string>)map["$permissions"],
            databaseId: map["databaseId"].ToString(),
            name: map["name"].ToString(),
            enabled: (bool)map["enabled"],
            documentSecurity: (bool)map["documentSecurity"],
            attributes: map["attributes"] is JsonElement jsonArrayProp9 ? jsonArrayProp9.Deserialize<List<object>>()! : (List<object>)map["attributes"],
            indexes: map["indexes"] is JsonElement jsonArray10 ? jsonArray10.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Index.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["indexes"]).Select(it => Index.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", id },
            { "$createdAt", createdAt },
            { "$updatedAt", updatedAt },
            { "$permissions", permissions },
            { "databaseId", DatabaseId },
            { "name", Name },
            { "enabled", Enabled },
            { "documentSecurity", DocumentSecurity },
            { "attributes", Attributes },
            { "indexes", Indexes.Select(it => it.ToMap()) }
        };
    }
}
