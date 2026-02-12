
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class BackupRestoration
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("archiveId")]
        public string ArchiveId { get; private set; }

        [JsonPropertyName("policyId")]
        public string PolicyId { get; private set; }

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

        [JsonPropertyName("options")]
        public string Options { get; private set; }

        public BackupRestoration(
            string id,
            string createdAt,
            string updatedAt,
            string archiveId,
            string policyId,
            string status,
            string startedAt,
            string migrationId,
            List<string> services,
            List<string> resources,
            string options
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ArchiveId = archiveId;
            PolicyId = policyId;
            Status = status;
            StartedAt = startedAt;
            MigrationId = migrationId;
            Services = services;
            Resources = resources;
            Options = options;
        }

        public static BackupRestoration From(Dictionary<string, object> map) => new BackupRestoration(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            archiveId: map["archiveId"].ToString(),
            policyId: map["policyId"].ToString(),
            status: map["status"].ToString(),
            startedAt: map["startedAt"].ToString(),
            migrationId: map["migrationId"].ToString(),
            services: map["services"].ConvertToList<string>(),
            resources: map["resources"].ConvertToList<string>(),
            options: map["options"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "archiveId", ArchiveId },
            { "policyId", PolicyId },
            { "status", Status },
            { "startedAt", StartedAt },
            { "migrationId", MigrationId },
            { "services", Services },
            { "resources", Resources },
            { "options", Options }
        };
    }
}
