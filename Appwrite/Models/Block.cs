
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Block
    {
        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("resourceType")]
        public string ResourceType { get; private set; }

        [JsonPropertyName("resourceId")]
        public string ResourceId { get; private set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; private set; }

        [JsonPropertyName("expiredAt")]
        public string? ExpiredAt { get; private set; }

        [JsonPropertyName("projectName")]
        public string ProjectName { get; private set; }

        [JsonPropertyName("region")]
        public string Region { get; private set; }

        [JsonPropertyName("organizationName")]
        public string OrganizationName { get; private set; }

        [JsonPropertyName("organizationId")]
        public string OrganizationId { get; private set; }

        [JsonPropertyName("billingPlan")]
        public string BillingPlan { get; private set; }

        public Block(
            string createdAt,
            string resourceType,
            string resourceId,
            string? reason,
            string? expiredAt,
            string projectName,
            string region,
            string organizationName,
            string organizationId,
            string billingPlan
        )
        {
            CreatedAt = createdAt;
            ResourceType = resourceType;
            ResourceId = resourceId;
            Reason = reason;
            ExpiredAt = expiredAt;
            ProjectName = projectName;
            Region = region;
            OrganizationName = organizationName;
            OrganizationId = organizationId;
            BillingPlan = billingPlan;
        }

        public static Block From(Dictionary<string, object> map) => new Block(
            createdAt: map["$createdAt"].ToString(),
            resourceType: map["resourceType"].ToString(),
            resourceId: map["resourceId"].ToString(),
            reason: map.TryGetValue("reason", out var reason) ? reason?.ToString() : null,
            expiredAt: map.TryGetValue("expiredAt", out var expiredAt) ? expiredAt?.ToString() : null,
            projectName: map["projectName"].ToString(),
            region: map["region"].ToString(),
            organizationName: map["organizationName"].ToString(),
            organizationId: map["organizationId"].ToString(),
            billingPlan: map["billingPlan"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$createdAt", CreatedAt },
            { "resourceType", ResourceType },
            { "resourceId", ResourceId },
            { "reason", Reason },
            { "expiredAt", ExpiredAt },
            { "projectName", ProjectName },
            { "region", Region },
            { "organizationName", OrganizationName },
            { "organizationId", OrganizationId },
            { "billingPlan", BillingPlan }
        };
    }
}
