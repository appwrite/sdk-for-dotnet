
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseRestoration
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("databaseId")]
        public string DatabaseId { get; private set; }

        [JsonPropertyName("sourceDatabaseId")]
        public string? SourceDatabaseId { get; private set; }

        [JsonPropertyName("projectId")]
        public string ProjectId { get; private set; }

        [JsonPropertyName("backupId")]
        public string? BackupId { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        [JsonPropertyName("targetTime")]
        public string? TargetTime { get; private set; }

        [JsonPropertyName("startedAt")]
        public string? StartedAt { get; private set; }

        [JsonPropertyName("completedAt")]
        public string? CompletedAt { get; private set; }

        [JsonPropertyName("error")]
        public string Error { get; private set; }

        public DedicatedDatabaseRestoration(
            string id,
            string createdAt,
            string databaseId,
            string? sourceDatabaseId,
            string projectId,
            string? backupId,
            string type,
            string status,
            string? targetTime,
            string? startedAt,
            string? completedAt,
            string error
        )
        {
            Id = id;
            CreatedAt = createdAt;
            DatabaseId = databaseId;
            SourceDatabaseId = sourceDatabaseId;
            ProjectId = projectId;
            BackupId = backupId;
            Type = type;
            Status = status;
            TargetTime = targetTime;
            StartedAt = startedAt;
            CompletedAt = completedAt;
            Error = error;
        }

        public static DedicatedDatabaseRestoration From(Dictionary<string, object> map) => new DedicatedDatabaseRestoration(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            databaseId: (map.ContainsKey("databaseId") ? map["databaseId"] : "").ToString(),
            sourceDatabaseId: map.TryGetValue("sourceDatabaseId", out var sourceDatabaseId) ? sourceDatabaseId?.ToString() : null,
            projectId: (map.ContainsKey("projectId") ? map["projectId"] : "").ToString(),
            backupId: map.TryGetValue("backupId", out var backupId) ? backupId?.ToString() : null,
            type: (map.ContainsKey("type") ? map["type"] : "backup").ToString(),
            status: (map.ContainsKey("status") ? map["status"] : "pending").ToString(),
            targetTime: map.TryGetValue("targetTime", out var targetTime) ? targetTime?.ToString() : null,
            startedAt: map.TryGetValue("startedAt", out var startedAt) ? startedAt?.ToString() : null,
            completedAt: map.TryGetValue("completedAt", out var completedAt) ? completedAt?.ToString() : null,
            error: (map.ContainsKey("error") ? map["error"] : "").ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "databaseId", DatabaseId },
            { "sourceDatabaseId", SourceDatabaseId },
            { "projectId", ProjectId },
            { "backupId", BackupId },
            { "type", Type },
            { "status", Status },
            { "targetTime", TargetTime },
            { "startedAt", StartedAt },
            { "completedAt", CompletedAt },
            { "error", Error }
        };
    }
}
