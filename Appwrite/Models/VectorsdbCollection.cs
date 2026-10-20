
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class VectorsdbCollection
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("$permissions")]
        public List<string> Permissions { get; private set; }

        [JsonPropertyName("databaseId")]
        public string DatabaseId { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("description")]
        public string Description { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("documentSecurity")]
        public bool DocumentSecurity { get; private set; }

        [JsonPropertyName("attributes")]
        public List<object> Attributes { get; private set; }

        [JsonPropertyName("indexes")]
        public List<Index> Indexes { get; private set; }

        [JsonPropertyName("bytesMax")]
        public long BytesMax { get; private set; }

        [JsonPropertyName("bytesUsed")]
        public long BytesUsed { get; private set; }

        [JsonPropertyName("dimension")]
        public long Dimension { get; private set; }

        public VectorsdbCollection(
            string id,
            string createdAt,
            string updatedAt,
            List<string> permissions,
            string databaseId,
            string name,
            string description,
            bool enabled,
            bool documentSecurity,
            List<object> attributes,
            List<Index> indexes,
            long bytesMax,
            long bytesUsed,
            long dimension
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Permissions = permissions;
            DatabaseId = databaseId;
            Name = name;
            Description = description;
            Enabled = enabled;
            DocumentSecurity = documentSecurity;
            Attributes = attributes;
            Indexes = indexes;
            BytesMax = bytesMax;
            BytesUsed = bytesUsed;
            Dimension = dimension;
        }

        public static VectorsdbCollection From(Dictionary<string, object> map) => new VectorsdbCollection(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            permissions: (map.ContainsKey("$permissions") ? map["$permissions"] : new List<object>()).ConvertToList<string>(),
            databaseId: (map.ContainsKey("databaseId") ? map["databaseId"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            description: (map.ContainsKey("description") ? map["description"] : "").ToString(),
            enabled: (bool)(map.ContainsKey("enabled") ? map["enabled"] : true),
            documentSecurity: (bool)(map.ContainsKey("documentSecurity") ? map["documentSecurity"] : false),
            attributes: (map.ContainsKey("attributes") ? map["attributes"] : new List<object>()).ConvertToList<object>(),
            indexes: (map.ContainsKey("indexes") ? map["indexes"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Index.From(map: it)).ToList(),
            bytesMax: Convert.ToInt64((map.ContainsKey("bytesMax") ? map["bytesMax"] : 0)),
            bytesUsed: Convert.ToInt64((map.ContainsKey("bytesUsed") ? map["bytesUsed"] : 0)),
            dimension: Convert.ToInt64((map.ContainsKey("dimension") ? map["dimension"] : 0))
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "$permissions", Permissions },
            { "databaseId", DatabaseId },
            { "name", Name },
            { "description", Description },
            { "enabled", Enabled },
            { "documentSecurity", DocumentSecurity },
            { "attributes", Attributes },
            { "indexes", Indexes?.Select(it => it.ToMap()).ToList() },
            { "bytesMax", BytesMax },
            { "bytesUsed", BytesUsed },
            { "dimension", Dimension }
        };
    }
}
