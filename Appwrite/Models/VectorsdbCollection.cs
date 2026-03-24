
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
            bool enabled,
            bool documentSecurity,
            List<object> attributes,
            List<Index> indexes,
            long bytesMax,
            long bytesUsed,
            long dimension
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
            BytesMax = bytesMax;
            BytesUsed = bytesUsed;
            Dimension = dimension;
        }

        public static VectorsdbCollection From(Dictionary<string, object> map) => new VectorsdbCollection(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            permissions: map["$permissions"].ConvertToList<string>(),
            databaseId: map["databaseId"].ToString(),
            name: map["name"].ToString(),
            enabled: (bool)map["enabled"],
            documentSecurity: (bool)map["documentSecurity"],
            attributes: map["attributes"].ConvertToList<object>(),
            indexes: map["indexes"].ConvertToList<Dictionary<string, object>>().Select(it => Index.From(map: it)).ToList(),
            bytesMax: Convert.ToInt64(map["bytesMax"]),
            bytesUsed: Convert.ToInt64(map["bytesUsed"]),
            dimension: Convert.ToInt64(map["dimension"])
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
            { "indexes", Indexes.Select(it => it.ToMap()) },
            { "bytesMax", BytesMax },
            { "bytesUsed", BytesUsed },
            { "dimension", Dimension }
        };
    }
}
