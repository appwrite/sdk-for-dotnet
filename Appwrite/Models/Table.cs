
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

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
            List<ColumnIndex> indexes
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
        }

        public static Table From(Dictionary<string, object> map) => new Table(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            permissions: map["$permissions"] is JsonElement jsonArrayProp4 ? jsonArrayProp4.Deserialize<List<string>>()! : (List<string>)map["$permissions"],
            databaseId: map["databaseId"].ToString(),
            name: map["name"].ToString(),
            enabled: (bool)map["enabled"],
            rowSecurity: (bool)map["rowSecurity"],
            columns: map["columns"] is JsonElement jsonArrayProp9 ? jsonArrayProp9.Deserialize<List<object>>()! : (List<object>)map["columns"],
            indexes: map["indexes"] is JsonElement jsonArray10 ? jsonArray10.Deserialize<List<Dictionary<string, object>>>()!.Select(it => ColumnIndex.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["indexes"]).Select(it => ColumnIndex.From(map: it)).ToList()
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
            { "indexes", Indexes.Select(it => it.ToMap()) }
        };
    }
}
