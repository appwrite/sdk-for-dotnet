
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Report
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("appId")]
        public string AppId { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("title")]
        public string Title { get; private set; }

        [JsonPropertyName("summary")]
        public string Summary { get; private set; }

        [JsonPropertyName("targetType")]
        public string TargetType { get; private set; }

        [JsonPropertyName("target")]
        public string Target { get; private set; }

        [JsonPropertyName("categories")]
        public List<string> Categories { get; private set; }

        [JsonPropertyName("insights")]
        public List<Insight> Insights { get; private set; }

        [JsonPropertyName("analyzedAt")]
        public string? AnalyzedAt { get; private set; }

        public Report(
            string id,
            string createdAt,
            string updatedAt,
            string appId,
            string type,
            string title,
            string summary,
            string targetType,
            string target,
            List<string> categories,
            List<Insight> insights,
            string? analyzedAt
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            AppId = appId;
            Type = type;
            Title = title;
            Summary = summary;
            TargetType = targetType;
            Target = target;
            Categories = categories;
            Insights = insights;
            AnalyzedAt = analyzedAt;
        }

        public static Report From(Dictionary<string, object> map) => new Report(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            appId: map["appId"].ToString(),
            type: map["type"].ToString(),
            title: map["title"].ToString(),
            summary: map["summary"].ToString(),
            targetType: map["targetType"].ToString(),
            target: map["target"].ToString(),
            categories: map["categories"].ConvertToList<string>(),
            insights: map["insights"].ConvertToList<Dictionary<string, object>>().Select(it => Insight.From(map: it)).ToList(),
            analyzedAt: map.TryGetValue("analyzedAt", out var analyzedAt) ? analyzedAt?.ToString() : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "appId", AppId },
            { "type", Type },
            { "title", Title },
            { "summary", Summary },
            { "targetType", TargetType },
            { "target", Target },
            { "categories", Categories },
            { "insights", Insights?.Select(it => it.ToMap()).ToList() },
            { "analyzedAt", AnalyzedAt }
        };
    }
}
