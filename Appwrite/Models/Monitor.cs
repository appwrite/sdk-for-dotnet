
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Monitor
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("projectId")]
        public string ProjectId { get; private set; }

        [JsonPropertyName("rules")]
        public List<string> Rules { get; private set; }

        [JsonPropertyName("type")]
        public Appwrite.Enums.MonitorType Type { get; private set; }

        [JsonPropertyName("resourceType")]
        public Appwrite.Enums.MonitorResourceType ResourceType { get; private set; }

        [JsonPropertyName("resourceId")]
        public string ResourceId { get; private set; }

        [JsonPropertyName("window")]
        public long Window { get; private set; }

        [JsonPropertyName("cooldown")]
        public long Cooldown { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("notify")]
        public List<string> Notify { get; private set; }

        [JsonPropertyName("escalationId")]
        public string EscalationId { get; private set; }

        [JsonPropertyName("severity")]
        public Appwrite.Enums.MonitorSeverity Severity { get; private set; }

        [JsonPropertyName("status")]
        public Appwrite.Enums.MonitorStatus Status { get; private set; }

        [JsonPropertyName("value")]
        public double? Value { get; private set; }

        [JsonPropertyName("evaluatedAt")]
        public string? EvaluatedAt { get; private set; }

        [JsonPropertyName("alertId")]
        public string AlertId { get; private set; }

        [JsonPropertyName("triggeredAt")]
        public string? TriggeredAt { get; private set; }

        [JsonPropertyName("interval")]
        public long Interval { get; private set; }

        [JsonPropertyName("timeout")]
        public long Timeout { get; private set; }

        [JsonPropertyName("url")]
        public string Url { get; private set; }

        [JsonPropertyName("method")]
        public Appwrite.Enums.MonitorMethod? Method { get; private set; }

        [JsonPropertyName("headers")]
        public object? Headers { get; private set; }

        [JsonPropertyName("body")]
        public string Body { get; private set; }

        [JsonPropertyName("domain")]
        public string Domain { get; private set; }

        [JsonPropertyName("record")]
        public Appwrite.Enums.MonitorRecord? Record { get; private set; }

        [JsonPropertyName("resolver")]
        public string Resolver { get; private set; }

        [JsonPropertyName("host")]
        public string Host { get; private set; }

        [JsonPropertyName("port")]
        public long Port { get; private set; }

        [JsonPropertyName("tlsMode")]
        public Appwrite.Enums.MonitorTlsMode? TlsMode { get; private set; }

        [JsonPropertyName("result")]
        public Appwrite.Enums.MonitorResult? Result { get; private set; }

        [JsonPropertyName("latency")]
        public long? Latency { get; private set; }

        [JsonPropertyName("code")]
        public long? Code { get; private set; }

        [JsonPropertyName("certificateExpiresAt")]
        public string? CertificateExpiresAt { get; private set; }

        public Monitor(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            string projectId,
            List<string> rules,
            Appwrite.Enums.MonitorType type,
            Appwrite.Enums.MonitorResourceType resourceType,
            string resourceId,
            long window,
            long cooldown,
            bool enabled,
            List<string> notify,
            string escalationId,
            Appwrite.Enums.MonitorSeverity severity,
            Appwrite.Enums.MonitorStatus status,
            double? @value,
            string? evaluatedAt,
            string alertId,
            string? triggeredAt,
            long interval,
            long timeout,
            string url,
            Appwrite.Enums.MonitorMethod? method,
            object? headers,
            string body,
            string domain,
            Appwrite.Enums.MonitorRecord? record,
            string resolver,
            string host,
            long port,
            Appwrite.Enums.MonitorTlsMode? tlsMode,
            Appwrite.Enums.MonitorResult? result,
            long? latency,
            long? code,
            string? certificateExpiresAt
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            ProjectId = projectId;
            Rules = rules;
            Type = type;
            ResourceType = resourceType;
            ResourceId = resourceId;
            Window = window;
            Cooldown = cooldown;
            Enabled = enabled;
            Notify = notify;
            EscalationId = escalationId;
            Severity = severity;
            Status = status;
            Value = @value;
            EvaluatedAt = evaluatedAt;
            AlertId = alertId;
            TriggeredAt = triggeredAt;
            Interval = interval;
            Timeout = timeout;
            Url = url;
            Method = method;
            Headers = headers;
            Body = body;
            Domain = domain;
            Record = record;
            Resolver = resolver;
            Host = host;
            Port = port;
            TlsMode = tlsMode;
            Result = result;
            Latency = latency;
            Code = code;
            CertificateExpiresAt = certificateExpiresAt;
        }

        public static Monitor From(Dictionary<string, object> map) => new Monitor(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            projectId: (map.ContainsKey("projectId") ? map["projectId"] : "").ToString(),
            rules: (map.ContainsKey("rules") ? map["rules"] : new List<object>()).ConvertToList<string>(),
            type: new Appwrite.Enums.MonitorType((map.ContainsKey("type") ? map["type"] : "usage").ToString()!),
            resourceType: new Appwrite.Enums.MonitorResourceType((map.ContainsKey("resourceType") ? map["resourceType"] : "project").ToString()!),
            resourceId: (map.ContainsKey("resourceId") ? map["resourceId"] : "").ToString(),
            window: Convert.ToInt64((map.ContainsKey("window") ? map["window"] : 3600)),
            cooldown: Convert.ToInt64((map.ContainsKey("cooldown") ? map["cooldown"] : 3600)),
            enabled: (bool)(map.ContainsKey("enabled") ? map["enabled"] : true),
            notify: (map.ContainsKey("notify") ? map["notify"] : new List<object> { "owner" }).ConvertToList<string>(),
            escalationId: (map.ContainsKey("escalationId") ? map["escalationId"] : "").ToString(),
            severity: new Appwrite.Enums.MonitorSeverity((map.ContainsKey("severity") ? map["severity"] : "warning").ToString()!),
            status: new Appwrite.Enums.MonitorStatus((map.ContainsKey("status") ? map["status"] : "ok").ToString()!),
            @value: map.TryGetValue("value", out var numberRaw17) && numberRaw17 != null
                                    ? Convert.ToDouble(numberRaw17)
                                    : null,
            evaluatedAt: map.TryGetValue("evaluatedAt", out var evaluatedAt) ? evaluatedAt?.ToString() : null,
            alertId: (map.ContainsKey("alertId") ? map["alertId"] : "").ToString(),
            triggeredAt: map.TryGetValue("triggeredAt", out var triggeredAt) ? triggeredAt?.ToString() : null,
            interval: Convert.ToInt64((map.ContainsKey("interval") ? map["interval"] : 0)),
            timeout: Convert.ToInt64((map.ContainsKey("timeout") ? map["timeout"] : 0)),
            url: (map.ContainsKey("url") ? map["url"] : "").ToString(),
            method: map.TryGetValue("method", out var enumRaw24)
                            ? enumRaw24 == null
                                ? null
                                : new Appwrite.Enums.MonitorMethod(enumRaw24.ToString()!)
                            : null,
            headers: map.TryGetValue("headers", out var objectRaw25) ? objectRaw25 : null,
            body: (map.ContainsKey("body") ? map["body"] : "").ToString(),
            domain: (map.ContainsKey("domain") ? map["domain"] : "").ToString(),
            record: map.TryGetValue("record", out var enumRaw28)
                            ? enumRaw28 == null
                                ? null
                                : new Appwrite.Enums.MonitorRecord(enumRaw28.ToString()!)
                            : null,
            resolver: (map.ContainsKey("resolver") ? map["resolver"] : "").ToString(),
            host: (map.ContainsKey("host") ? map["host"] : "").ToString(),
            port: Convert.ToInt64((map.ContainsKey("port") ? map["port"] : 0)),
            tlsMode: map.TryGetValue("tlsMode", out var enumRaw32)
                            ? enumRaw32 == null
                                ? null
                                : new Appwrite.Enums.MonitorTlsMode(enumRaw32.ToString()!)
                            : null,
            result: map.TryGetValue("result", out var enumRaw33)
                            ? enumRaw33 == null
                                ? null
                                : new Appwrite.Enums.MonitorResult(enumRaw33.ToString()!)
                            : null,
            latency: map.TryGetValue("latency", out var numberRaw34) && numberRaw34 != null
                                    ? Convert.ToInt64(numberRaw34)
                                    : null,
            code: map.TryGetValue("code", out var numberRaw35) && numberRaw35 != null
                                    ? Convert.ToInt64(numberRaw35)
                                    : null,
            certificateExpiresAt: map.TryGetValue("certificateExpiresAt", out var certificateExpiresAt) ? certificateExpiresAt?.ToString() : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "projectId", ProjectId },
            { "rules", Rules },
            { "type", Type.Value },
            { "resourceType", ResourceType.Value },
            { "resourceId", ResourceId },
            { "window", Window },
            { "cooldown", Cooldown },
            { "enabled", Enabled },
            { "notify", Notify },
            { "escalationId", EscalationId },
            { "severity", Severity.Value },
            { "status", Status.Value },
            { "value", Value },
            { "evaluatedAt", EvaluatedAt },
            { "alertId", AlertId },
            { "triggeredAt", TriggeredAt },
            { "interval", Interval },
            { "timeout", Timeout },
            { "url", Url },
            { "method", Method?.Value },
            { "headers", Headers },
            { "body", Body },
            { "domain", Domain },
            { "record", Record?.Value },
            { "resolver", Resolver },
            { "host", Host },
            { "port", Port },
            { "tlsMode", TlsMode?.Value },
            { "result", Result?.Value },
            { "latency", Latency },
            { "code", Code },
            { "certificateExpiresAt", CertificateExpiresAt }
        };
    }
}
