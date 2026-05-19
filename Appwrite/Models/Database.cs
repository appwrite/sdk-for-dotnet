
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Database
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("type")]
        public DatabaseType Type { get; private set; }

        [JsonPropertyName("policies")]
        public List<BackupPolicy> Policies { get; private set; }

        [JsonPropertyName("archives")]
        public List<BackupArchive> Archives { get; private set; }

        public Database(
            string id,
            string name,
            string createdAt,
            string updatedAt,
            bool enabled,
            DatabaseType type,
            List<BackupPolicy> policies,
            List<BackupArchive> archives
        )
        {
            Id = id;
            Name = name;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Enabled = enabled;
            Type = type;
            Policies = policies;
            Archives = archives;
        }

        public static Database From(Dictionary<string, object> map) => new Database(
            id: map["$id"].ToString(),
            name: map["name"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            enabled: (bool)map["enabled"],
            type: new DatabaseType(map["type"].ToString()!),
            policies: map["policies"].ConvertToList<Dictionary<string, object>>().Select(it => BackupPolicy.From(map: it)).ToList(),
            archives: map["archives"].ConvertToList<Dictionary<string, object>>().Select(it => BackupArchive.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "name", Name },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "enabled", Enabled },
            { "type", Type.Value },
            { "policies", Policies?.Select(it => it.ToMap()).ToList() },
            { "archives", Archives?.Select(it => it.ToMap()).ToList() }
        };
    }
}
