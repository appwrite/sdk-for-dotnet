
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Alert
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("monitorId")]
        public string MonitorId { get; private set; }

        [JsonPropertyName("projectId")]
        public string ProjectId { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("status")]
        public Appwrite.Enums.AlertStatus Status { get; private set; }

        [JsonPropertyName("resolvedAt")]
        public string? ResolvedAt { get; private set; }

        [JsonPropertyName("acknowledgedAt")]
        public string? AcknowledgedAt { get; private set; }

        [JsonPropertyName("acknowledgedBy")]
        public string AcknowledgedBy { get; private set; }

        [JsonPropertyName("acknowledgedByName")]
        public string AcknowledgedByName { get; private set; }

        [JsonPropertyName("escalationId")]
        public string EscalationId { get; private set; }

        [JsonPropertyName("escalationStep")]
        public long EscalationStep { get; private set; }

        [JsonPropertyName("escalationRound")]
        public long EscalationRound { get; private set; }

        [JsonPropertyName("escalatesAt")]
        public string? EscalatesAt { get; private set; }

        [JsonPropertyName("rules")]
        public List<string> Rules { get; private set; }

        [JsonPropertyName("severity")]
        public Appwrite.Enums.MonitorSeverity Severity { get; private set; }

        [JsonPropertyName("metric")]
        public Appwrite.Enums.AlertMetric? Metric { get; private set; }

        [JsonPropertyName("comparator")]
        public Appwrite.Enums.AlertComparator? Comparator { get; private set; }

        [JsonPropertyName("threshold")]
        public double Threshold { get; private set; }

        [JsonPropertyName("value")]
        public double Value { get; private set; }

        [JsonPropertyName("peak")]
        public double Peak { get; private set; }

        [JsonPropertyName("type")]
        public Appwrite.Enums.MonitorType Type { get; private set; }

        [JsonPropertyName("resourceType")]
        public Appwrite.Enums.MonitorResourceType ResourceType { get; private set; }

        [JsonPropertyName("resourceId")]
        public string ResourceId { get; private set; }

        [JsonPropertyName("notifications")]
        public long Notifications { get; private set; }

        [JsonPropertyName("latency")]
        public long? Latency { get; private set; }

        [JsonPropertyName("result")]
        public Appwrite.Enums.MonitorResult? Result { get; private set; }

        public Alert(
            string id,
            string createdAt,
            string updatedAt,
            string monitorId,
            string projectId,
            string name,
            Appwrite.Enums.AlertStatus status,
            string? resolvedAt,
            string? acknowledgedAt,
            string acknowledgedBy,
            string acknowledgedByName,
            string escalationId,
            long escalationStep,
            long escalationRound,
            string? escalatesAt,
            List<string> rules,
            Appwrite.Enums.MonitorSeverity severity,
            Appwrite.Enums.AlertMetric? metric,
            Appwrite.Enums.AlertComparator? comparator,
            double threshold,
            double @value,
            double peak,
            Appwrite.Enums.MonitorType type,
            Appwrite.Enums.MonitorResourceType resourceType,
            string resourceId,
            long notifications,
            long? latency,
            Appwrite.Enums.MonitorResult? result
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            MonitorId = monitorId;
            ProjectId = projectId;
            Name = name;
            Status = status;
            ResolvedAt = resolvedAt;
            AcknowledgedAt = acknowledgedAt;
            AcknowledgedBy = acknowledgedBy;
            AcknowledgedByName = acknowledgedByName;
            EscalationId = escalationId;
            EscalationStep = escalationStep;
            EscalationRound = escalationRound;
            EscalatesAt = escalatesAt;
            Rules = rules;
            Severity = severity;
            Metric = metric;
            Comparator = comparator;
            Threshold = threshold;
            Value = @value;
            Peak = peak;
            Type = type;
            ResourceType = resourceType;
            ResourceId = resourceId;
            Notifications = notifications;
            Latency = latency;
            Result = result;
        }

        public static Alert From(Dictionary<string, object> map) => new Alert(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            monitorId: (map.ContainsKey("monitorId") ? map["monitorId"] : "").ToString(),
            projectId: (map.ContainsKey("projectId") ? map["projectId"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            status: new Appwrite.Enums.AlertStatus((map.ContainsKey("status") ? map["status"] : "firing").ToString()!),
            resolvedAt: map.TryGetValue("resolvedAt", out var resolvedAt) ? resolvedAt?.ToString() : null,
            acknowledgedAt: map.TryGetValue("acknowledgedAt", out var acknowledgedAt) ? acknowledgedAt?.ToString() : null,
            acknowledgedBy: (map.ContainsKey("acknowledgedBy") ? map["acknowledgedBy"] : "").ToString(),
            acknowledgedByName: (map.ContainsKey("acknowledgedByName") ? map["acknowledgedByName"] : "").ToString(),
            escalationId: (map.ContainsKey("escalationId") ? map["escalationId"] : "").ToString(),
            escalationStep: Convert.ToInt64((map.ContainsKey("escalationStep") ? map["escalationStep"] : 0)),
            escalationRound: Convert.ToInt64((map.ContainsKey("escalationRound") ? map["escalationRound"] : 0)),
            escalatesAt: map.TryGetValue("escalatesAt", out var escalatesAt) ? escalatesAt?.ToString() : null,
            rules: (map.ContainsKey("rules") ? map["rules"] : new List<object>()).ConvertToList<string>(),
            severity: new Appwrite.Enums.MonitorSeverity((map.ContainsKey("severity") ? map["severity"] : "warning").ToString()!),
            metric: map.TryGetValue("metric", out var enumRaw18)
                            ? enumRaw18 == null
                                ? null
                                : new Appwrite.Enums.AlertMetric(enumRaw18.ToString()!)
                            : null,
            comparator: map.TryGetValue("comparator", out var enumRaw19)
                            ? enumRaw19 == null
                                ? null
                                : new Appwrite.Enums.AlertComparator(enumRaw19.ToString()!)
                            : null,
            threshold: Convert.ToDouble((map.ContainsKey("threshold") ? map["threshold"] : 0)),
            @value: Convert.ToDouble((map.ContainsKey("value") ? map["value"] : 0)),
            peak: Convert.ToDouble((map.ContainsKey("peak") ? map["peak"] : 0)),
            type: new Appwrite.Enums.MonitorType((map.ContainsKey("type") ? map["type"] : "usage").ToString()!),
            resourceType: new Appwrite.Enums.MonitorResourceType((map.ContainsKey("resourceType") ? map["resourceType"] : "project").ToString()!),
            resourceId: (map.ContainsKey("resourceId") ? map["resourceId"] : "").ToString(),
            notifications: Convert.ToInt64((map.ContainsKey("notifications") ? map["notifications"] : 0)),
            latency: map.TryGetValue("latency", out var numberRaw27) && numberRaw27 != null
                                    ? Convert.ToInt64(numberRaw27)
                                    : null,
            result: map.TryGetValue("result", out var enumRaw28)
                            ? enumRaw28 == null
                                ? null
                                : new Appwrite.Enums.MonitorResult(enumRaw28.ToString()!)
                            : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "monitorId", MonitorId },
            { "projectId", ProjectId },
            { "name", Name },
            { "status", Status.Value },
            { "resolvedAt", ResolvedAt },
            { "acknowledgedAt", AcknowledgedAt },
            { "acknowledgedBy", AcknowledgedBy },
            { "acknowledgedByName", AcknowledgedByName },
            { "escalationId", EscalationId },
            { "escalationStep", EscalationStep },
            { "escalationRound", EscalationRound },
            { "escalatesAt", EscalatesAt },
            { "rules", Rules },
            { "severity", Severity.Value },
            { "metric", Metric?.Value },
            { "comparator", Comparator?.Value },
            { "threshold", Threshold },
            { "value", Value },
            { "peak", Peak },
            { "type", Type.Value },
            { "resourceType", ResourceType.Value },
            { "resourceId", ResourceId },
            { "notifications", Notifications },
            { "latency", Latency },
            { "result", Result?.Value }
        };
    }
}
