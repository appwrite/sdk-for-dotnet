
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
        public Appwrite.Enums.DatabaseType Type { get; private set; }

        [JsonPropertyName("status")]
        public Appwrite.Enums.DatabaseStatus? Status { get; private set; }

        [JsonPropertyName("engine")]
        public string? Engine { get; private set; }

        [JsonPropertyName("specification")]
        public string? Specification { get; private set; }

        [JsonPropertyName("replicas")]
        public long? Replicas { get; private set; }

        [JsonPropertyName("error")]
        public string? Error { get; private set; }

        [JsonPropertyName("containerStatus")]
        public string? ContainerStatus { get; private set; }

        [JsonPropertyName("lifecycleState")]
        public string? LifecycleState { get; private set; }

        [JsonPropertyName("policies")]
        public List<BackupPolicy>? Policies { get; private set; }

        [JsonPropertyName("archives")]
        public List<BackupArchive>? Archives { get; private set; }

        public Database(
            string id,
            string name,
            string createdAt,
            string updatedAt,
            bool enabled,
            Appwrite.Enums.DatabaseType type,
            Appwrite.Enums.DatabaseStatus? status,
            string? engine,
            string? specification,
            long? replicas,
            string? error,
            string? containerStatus,
            string? lifecycleState,
            List<BackupPolicy>? policies,
            List<BackupArchive>? archives
        )
        {
            Id = id;
            Name = name;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Enabled = enabled;
            Type = type;
            Status = status;
            Engine = engine;
            Specification = specification;
            Replicas = replicas;
            Error = error;
            ContainerStatus = containerStatus;
            LifecycleState = lifecycleState;
            Policies = policies;
            Archives = archives;
        }

        public static Database From(Dictionary<string, object> map) => new Database(
            id: map["$id"].ToString(),
            name: map["name"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            enabled: (bool)map["enabled"],
            type: new Appwrite.Enums.DatabaseType(map["type"].ToString()!),
            status: map.TryGetValue("status", out var enumRaw7)
                            ? enumRaw7 == null
                                ? null
                                : new Appwrite.Enums.DatabaseStatus(enumRaw7.ToString()!)
                            : null,
            engine: map.TryGetValue("engine", out var engine) ? engine?.ToString() : null,
            specification: map.TryGetValue("specification", out var specification) ? specification?.ToString() : null,
            replicas: map.TryGetValue("replicas", out var numberRaw10) && numberRaw10 != null
                                    ? Convert.ToInt64(numberRaw10)
                                    : null,
            error: map.TryGetValue("error", out var error) ? error?.ToString() : null,
            containerStatus: map.TryGetValue("containerStatus", out var containerStatus) ? containerStatus?.ToString() : null,
            lifecycleState: map.TryGetValue("lifecycleState", out var lifecycleState) ? lifecycleState?.ToString() : null,
            policies: map.TryGetValue("policies", out var arrayRaw14) && arrayRaw14 != null
                                    ? arrayRaw14.ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.BackupPolicy.From(map: it)).ToList()
                                    : null,
            archives: map.TryGetValue("archives", out var arrayRaw15) && arrayRaw15 != null
                                    ? arrayRaw15.ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.BackupArchive.From(map: it)).ToList()
                                    : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "name", Name },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "enabled", Enabled },
            { "type", Type.Value },
            { "status", Status?.Value },
            { "engine", Engine },
            { "specification", Specification },
            { "replicas", Replicas },
            { "error", Error },
            { "containerStatus", ContainerStatus },
            { "lifecycleState", LifecycleState },
            { "policies", Policies?.Select(it => it.ToMap()).ToList() },
            { "archives", Archives?.Select(it => it.ToMap()).ToList() }
        };
    }
}
