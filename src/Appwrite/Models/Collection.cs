
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Collection
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("$permissions")]
        public List<object> Permissions { get; private set; }

        [JsonProperty("databaseId")]
        public string DatabaseId { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; private set; }

        [JsonProperty("documentSecurity")]
        public bool DocumentSecurity { get; private set; }

        [JsonProperty("attributes")]
        public List<object> Attributes { get; private set; }

        [JsonProperty("indexes")]
        public List<Index> Indexes { get; private set; }

        public Collection(
            string id,
            string createdAt,
            string updatedAt,
            List<object> permissions,
            string databaseId,
            string name,
            bool enabled,
            bool documentSecurity,
            List<object> attributes,
            List<Index> indexes
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Permissions = permissions;
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
            permissions: ((JArray)map["$permissions"]).ToObject<List<object>>(),
            databaseId: map["databaseId"].ToString(),
            name: map["name"].ToString(),
            enabled: (bool)map["enabled"],
            documentSecurity: (bool)map["documentSecurity"],
            attributes: ((JArray)map["attributes"]).ToObject<List<object>>(),
            indexes: ((JArray)map["indexes"]).ToObject<List<Dictionary<string, object>>>().Select(it => Index.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "$permissions", Permissions },
            { "databaseId", DatabaseId },
            { "name", Name },
            { "enabled", Enabled },
            { "documentSecurity", DocumentSecurity },
            { "attributes", Attributes },
            { "indexes", Indexes.Select(it => it.ToMap()) }
        };
    }
}