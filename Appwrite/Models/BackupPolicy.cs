
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class BackupPolicy
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("services")]
        public List<string> Services { get; private set; }

        [JsonPropertyName("resources")]
        public List<string> Resources { get; private set; }

        [JsonPropertyName("resourceId")]
        public string? ResourceId { get; private set; }

        [JsonPropertyName("resourceType")]
        public string? ResourceType { get; private set; }

        [JsonPropertyName("retention")]
        public long Retention { get; private set; }

        [JsonPropertyName("schedule")]
        public string Schedule { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        public BackupPolicy(
            string id,
            string name,
            string createdAt,
            string updatedAt,
            List<string> services,
            List<string> resources,
            string? resourceId,
            string? resourceType,
            long retention,
            string schedule,
            bool enabled
        ) {
            Id = id;
            Name = name;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Services = services;
            Resources = resources;
            ResourceId = resourceId;
            ResourceType = resourceType;
            Retention = retention;
            Schedule = schedule;
            Enabled = enabled;
        }

        public static BackupPolicy From(Dictionary<string, object> map) => new BackupPolicy(
            id: map["$id"].ToString(),
            name: map["name"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            services: map["services"].ConvertToList<string>(),
            resources: map["resources"].ConvertToList<string>(),
            resourceId: map.TryGetValue("resourceId", out var resourceId) ? resourceId?.ToString() : null,
            resourceType: map.TryGetValue("resourceType", out var resourceType) ? resourceType?.ToString() : null,
            retention: Convert.ToInt64(map["retention"]),
            schedule: map["schedule"].ToString(),
            enabled: (bool)map["enabled"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "name", Name },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "services", Services },
            { "resources", Resources },
            { "resourceId", ResourceId },
            { "resourceType", ResourceType },
            { "retention", Retention },
            { "schedule", Schedule },
            { "enabled", Enabled }
        };
    }
}
