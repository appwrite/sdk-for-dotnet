
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Table
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

        [JsonPropertyName("rowSecurity")]
        public bool RowSecurity { get; private set; }

        [JsonPropertyName("columns")]
        public List<object> Columns { get; private set; }

        [JsonPropertyName("indexes")]
        public List<ColumnIndex> Indexes { get; private set; }

        [JsonPropertyName("bytesMax")]
        public long BytesMax { get; private set; }

        [JsonPropertyName("bytesUsed")]
        public long BytesUsed { get; private set; }

        public Table(
            string id,
            string createdAt,
            string updatedAt,
            List<string> permissions,
            string databaseId,
            string name,
            bool enabled,
            bool rowSecurity,
            List<object> columns,
            List<ColumnIndex> indexes,
            long bytesMax,
            long bytesUsed
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Permissions = permissions;
            DatabaseId = databaseId;
            Name = name;
            Enabled = enabled;
            RowSecurity = rowSecurity;
            Columns = columns;
            Indexes = indexes;
            BytesMax = bytesMax;
            BytesUsed = bytesUsed;
        }

        public static Table From(Dictionary<string, object> map) => new Table(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            permissions: map["$permissions"].ConvertToList<string>(),
            databaseId: map["databaseId"].ToString(),
            name: map["name"].ToString(),
            enabled: (bool)map["enabled"],
            rowSecurity: (bool)map["rowSecurity"],
            columns: map["columns"].ConvertToList<object>(),
            indexes: map["indexes"].ConvertToList<Dictionary<string, object>>().Select(it => ColumnIndex.From(map: it)).ToList(),
            bytesMax: Convert.ToInt64(map["bytesMax"]),
            bytesUsed: Convert.ToInt64(map["bytesUsed"])
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
            { "rowSecurity", RowSecurity },
            { "columns", Columns },
            { "indexes", Indexes.Select(it => it.ToMap()) },
            { "bytesMax", BytesMax },
            { "bytesUsed", BytesUsed }
        };
    }
}
