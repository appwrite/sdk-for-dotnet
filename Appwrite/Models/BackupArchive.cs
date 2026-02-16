
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class BackupArchive
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("policyId")]
        public string PolicyId { get; private set; }

        [JsonPropertyName("size")]
        public long Size { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        [JsonPropertyName("startedAt")]
        public string StartedAt { get; private set; }

        [JsonPropertyName("migrationId")]
        public string MigrationId { get; private set; }

        [JsonPropertyName("services")]
        public List<string> Services { get; private set; }

        [JsonPropertyName("resources")]
        public List<string> Resources { get; private set; }

        [JsonPropertyName("resourceId")]
        public string? ResourceId { get; private set; }

        [JsonPropertyName("resourceType")]
        public string? ResourceType { get; private set; }

        public BackupArchive(
            string id,
            string createdAt,
            string updatedAt,
            string policyId,
            long size,
            string status,
            string startedAt,
            string migrationId,
            List<string> services,
            List<string> resources,
            string? resourceId,
            string? resourceType
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            PolicyId = policyId;
            Size = size;
            Status = status;
            StartedAt = startedAt;
            MigrationId = migrationId;
            Services = services;
            Resources = resources;
            ResourceId = resourceId;
            ResourceType = resourceType;
        }

        public static BackupArchive From(Dictionary<string, object> map) => new BackupArchive(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            policyId: map["policyId"].ToString(),
            size: Convert.ToInt64(map["size"]),
            status: map["status"].ToString(),
            startedAt: map["startedAt"].ToString(),
            migrationId: map["migrationId"].ToString(),
            services: map["services"].ConvertToList<string>(),
            resources: map["resources"].ConvertToList<string>(),
            resourceId: map.TryGetValue("resourceId", out var resourceId) ? resourceId?.ToString() : null,
            resourceType: map.TryGetValue("resourceType", out var resourceType) ? resourceType?.ToString() : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "policyId", PolicyId },
            { "size", Size },
            { "status", Status },
            { "startedAt", StartedAt },
            { "migrationId", MigrationId },
            { "services", Services },
            { "resources", Resources },
            { "resourceId", ResourceId },
            { "resourceType", ResourceType }
        };
    }
}
