
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Insight
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("reportId")]
        public string ReportId { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("severity")]
        public string Severity { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        [JsonPropertyName("resourceType")]
        public string ResourceType { get; private set; }

        [JsonPropertyName("resourceId")]
        public string ResourceId { get; private set; }

        [JsonPropertyName("parentResourceType")]
        public string ParentResourceType { get; private set; }

        [JsonPropertyName("parentResourceId")]
        public string ParentResourceId { get; private set; }

        [JsonPropertyName("title")]
        public string Title { get; private set; }

        [JsonPropertyName("summary")]
        public string Summary { get; private set; }

        [JsonPropertyName("ctas")]
        public List<InsightCTA> Ctas { get; private set; }

        [JsonPropertyName("analyzedAt")]
        public string? AnalyzedAt { get; private set; }

        [JsonPropertyName("dismissedAt")]
        public string? DismissedAt { get; private set; }

        [JsonPropertyName("dismissedBy")]
        public string? DismissedBy { get; private set; }

        public Insight(
            string id,
            string createdAt,
            string updatedAt,
            string reportId,
            string type,
            string severity,
            string status,
            string resourceType,
            string resourceId,
            string parentResourceType,
            string parentResourceId,
            string title,
            string summary,
            List<InsightCTA> ctas,
            string? analyzedAt,
            string? dismissedAt,
            string? dismissedBy
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ReportId = reportId;
            Type = type;
            Severity = severity;
            Status = status;
            ResourceType = resourceType;
            ResourceId = resourceId;
            ParentResourceType = parentResourceType;
            ParentResourceId = parentResourceId;
            Title = title;
            Summary = summary;
            Ctas = ctas;
            AnalyzedAt = analyzedAt;
            DismissedAt = dismissedAt;
            DismissedBy = dismissedBy;
        }

        public static Insight From(Dictionary<string, object> map) => new Insight(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            reportId: map["reportId"].ToString(),
            type: map["type"].ToString(),
            severity: map["severity"].ToString(),
            status: map["status"].ToString(),
            resourceType: map["resourceType"].ToString(),
            resourceId: map["resourceId"].ToString(),
            parentResourceType: map["parentResourceType"].ToString(),
            parentResourceId: map["parentResourceId"].ToString(),
            title: map["title"].ToString(),
            summary: map["summary"].ToString(),
            ctas: map["ctas"].ConvertToList<Dictionary<string, object>>().Select(it => InsightCTA.From(map: it)).ToList(),
            analyzedAt: map.TryGetValue("analyzedAt", out var analyzedAt) ? analyzedAt?.ToString() : null,
            dismissedAt: map.TryGetValue("dismissedAt", out var dismissedAt) ? dismissedAt?.ToString() : null,
            dismissedBy: map.TryGetValue("dismissedBy", out var dismissedBy) ? dismissedBy?.ToString() : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "reportId", ReportId },
            { "type", Type },
            { "severity", Severity },
            { "status", Status },
            { "resourceType", ResourceType },
            { "resourceId", ResourceId },
            { "parentResourceType", ParentResourceType },
            { "parentResourceId", ParentResourceId },
            { "title", Title },
            { "summary", Summary },
            { "ctas", Ctas?.Select(it => it.ToMap()).ToList() },
            { "analyzedAt", AnalyzedAt },
            { "dismissedAt", DismissedAt },
            { "dismissedBy", DismissedBy }
        };
    }
}
