
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class WafRuleRedirect
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("description")]
        public string Description { get; private set; }

        [JsonPropertyName("teamId")]
        public string TeamId { get; private set; }

        [JsonPropertyName("projectId")]
        public string ProjectId { get; private set; }

        [JsonPropertyName("resourceType")]
        public string ResourceType { get; private set; }

        [JsonPropertyName("resourceId")]
        public string ResourceId { get; private set; }

        [JsonPropertyName("action")]
        public Appwrite.Enums.WafRuleAction Action { get; private set; }

        [JsonPropertyName("priority")]
        public long Priority { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("conditions")]
        public List<object> Conditions { get; private set; }

        [JsonPropertyName("config")]
        public object Config { get; private set; }

        [JsonPropertyName("location")]
        public string Location { get; private set; }

        [JsonPropertyName("statusCode")]
        public long StatusCode { get; private set; }

        public WafRuleRedirect(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            string description,
            string teamId,
            string projectId,
            string resourceType,
            string resourceId,
            Appwrite.Enums.WafRuleAction action,
            long priority,
            bool enabled,
            List<object> conditions,
            object config,
            string location,
            long statusCode
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Description = description;
            TeamId = teamId;
            ProjectId = projectId;
            ResourceType = resourceType;
            ResourceId = resourceId;
            Action = action;
            Priority = priority;
            Enabled = enabled;
            Conditions = conditions;
            Config = config;
            Location = location;
            StatusCode = statusCode;
        }

        public static WafRuleRedirect From(Dictionary<string, object> map) => new WafRuleRedirect(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            description: (map.ContainsKey("description") ? map["description"] : "").ToString(),
            teamId: (map.ContainsKey("teamId") ? map["teamId"] : "").ToString(),
            projectId: (map.ContainsKey("projectId") ? map["projectId"] : "").ToString(),
            resourceType: (map.ContainsKey("resourceType") ? map["resourceType"] : "api").ToString(),
            resourceId: (map.ContainsKey("resourceId") ? map["resourceId"] : "").ToString(),
            action: new Appwrite.Enums.WafRuleAction(map["action"].ToString()!),
            priority: Convert.ToInt64((map.ContainsKey("priority") ? map["priority"] : 0)),
            enabled: (bool)(map.ContainsKey("enabled") ? map["enabled"] : true),
            conditions: (map.ContainsKey("conditions") ? map["conditions"] : new List<object>()).ConvertToList<object>(),
            config: (map.ContainsKey("config") ? map["config"] : new Dictionary<string, object>()),
            location: (map.ContainsKey("location") ? map["location"] : "/").ToString(),
            statusCode: Convert.ToInt64((map.ContainsKey("statusCode") ? map["statusCode"] : 302))
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "description", Description },
            { "teamId", TeamId },
            { "projectId", ProjectId },
            { "resourceType", ResourceType },
            { "resourceId", ResourceId },
            { "action", Action.Value },
            { "priority", Priority },
            { "enabled", Enabled },
            { "conditions", Conditions },
            { "config", Config },
            { "location", Location },
            { "statusCode", StatusCode }
        };
    }
}
