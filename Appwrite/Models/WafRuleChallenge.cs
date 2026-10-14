
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class WafRuleChallenge
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

        [JsonPropertyName("challengeType")]
        public string ChallengeType { get; private set; }

        [JsonPropertyName("difficulty")]
        public long Difficulty { get; private set; }

        [JsonPropertyName("ttl")]
        public long Ttl { get; private set; }

        public WafRuleChallenge(
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
            string challengeType,
            long difficulty,
            long ttl
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
            ChallengeType = challengeType;
            Difficulty = difficulty;
            Ttl = ttl;
        }

        public static WafRuleChallenge From(Dictionary<string, object> map) => new WafRuleChallenge(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            name: map["name"].ToString(),
            description: map["description"].ToString(),
            teamId: map["teamId"].ToString(),
            projectId: map["projectId"].ToString(),
            resourceType: map["resourceType"].ToString(),
            resourceId: map["resourceId"].ToString(),
            action: new Appwrite.Enums.WafRuleAction(map["action"].ToString()!),
            priority: Convert.ToInt64(map["priority"]),
            enabled: (bool)map["enabled"],
            conditions: map["conditions"].ConvertToList<object>(),
            config: map["config"],
            challengeType: map["challengeType"].ToString(),
            difficulty: Convert.ToInt64(map["difficulty"]),
            ttl: Convert.ToInt64(map["ttl"])
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
            { "challengeType", ChallengeType },
            { "difficulty", Difficulty },
            { "ttl", Ttl }
        };
    }
}
