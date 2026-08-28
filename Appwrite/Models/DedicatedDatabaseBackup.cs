
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseBackup
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("databaseId")]
        public string DatabaseId { get; private set; }

        [JsonPropertyName("projectId")]
        public string ProjectId { get; private set; }

        [JsonPropertyName("policyId")]
        public string PolicyId { get; private set; }

        [JsonPropertyName("trigger")]
        public string Trigger { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("requestedType")]
        public string RequestedType { get; private set; }

        [JsonPropertyName("fallbackReason")]
        public string FallbackReason { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        [JsonPropertyName("sizeBytes")]
        public long SizeBytes { get; private set; }

        [JsonPropertyName("startedAt")]
        public string? StartedAt { get; private set; }

        [JsonPropertyName("completedAt")]
        public string? CompletedAt { get; private set; }

        [JsonPropertyName("verifiedAt")]
        public string? VerifiedAt { get; private set; }

        [JsonPropertyName("expiresAt")]
        public string? ExpiresAt { get; private set; }

        [JsonPropertyName("logPosition")]
        public string? LogPosition { get; private set; }

        [JsonPropertyName("error")]
        public string Error { get; private set; }

        public DedicatedDatabaseBackup(
            string id,
            string createdAt,
            string databaseId,
            string projectId,
            string policyId,
            string trigger,
            string type,
            string requestedType,
            string fallbackReason,
            string status,
            long sizeBytes,
            string? startedAt,
            string? completedAt,
            string? verifiedAt,
            string? expiresAt,
            string? logPosition,
            string error
        )
        {
            Id = id;
            CreatedAt = createdAt;
            DatabaseId = databaseId;
            ProjectId = projectId;
            PolicyId = policyId;
            Trigger = trigger;
            Type = type;
            RequestedType = requestedType;
            FallbackReason = fallbackReason;
            Status = status;
            SizeBytes = sizeBytes;
            StartedAt = startedAt;
            CompletedAt = completedAt;
            VerifiedAt = verifiedAt;
            ExpiresAt = expiresAt;
            LogPosition = logPosition;
            Error = error;
        }

        public static DedicatedDatabaseBackup From(Dictionary<string, object> map) => new DedicatedDatabaseBackup(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            databaseId: map["databaseId"].ToString(),
            projectId: map["projectId"].ToString(),
            policyId: map["policyId"].ToString(),
            trigger: map["trigger"].ToString(),
            type: map["type"].ToString(),
            requestedType: map["requestedType"].ToString(),
            fallbackReason: map["fallbackReason"].ToString(),
            status: map["status"].ToString(),
            sizeBytes: Convert.ToInt64(map["sizeBytes"]),
            startedAt: map.TryGetValue("startedAt", out var startedAt) ? startedAt?.ToString() : null,
            completedAt: map.TryGetValue("completedAt", out var completedAt) ? completedAt?.ToString() : null,
            verifiedAt: map.TryGetValue("verifiedAt", out var verifiedAt) ? verifiedAt?.ToString() : null,
            expiresAt: map.TryGetValue("expiresAt", out var expiresAt) ? expiresAt?.ToString() : null,
            logPosition: map.TryGetValue("logPosition", out var logPosition) ? logPosition?.ToString() : null,
            error: map["error"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "databaseId", DatabaseId },
            { "projectId", ProjectId },
            { "policyId", PolicyId },
            { "trigger", Trigger },
            { "type", Type },
            { "requestedType", RequestedType },
            { "fallbackReason", FallbackReason },
            { "status", Status },
            { "sizeBytes", SizeBytes },
            { "startedAt", StartedAt },
            { "completedAt", CompletedAt },
            { "verifiedAt", VerifiedAt },
            { "expiresAt", ExpiresAt },
            { "logPosition", LogPosition },
            { "error", Error }
        };
    }
}
