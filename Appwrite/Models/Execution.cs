
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Execution
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("$permissions")]
        public List<string> Permissions { get; private set; }

        [JsonPropertyName("resourceId")]
        public string ResourceId { get; private set; }

        [JsonPropertyName("resourceType")]
        public Appwrite.Enums.ExecutionResourceType ResourceType { get; private set; }

        [JsonPropertyName("deploymentId")]
        public string DeploymentId { get; private set; }

        [JsonPropertyName("trigger")]
        public Appwrite.Enums.ExecutionTrigger Trigger { get; private set; }

        [JsonPropertyName("status")]
        public Appwrite.Enums.ExecutionStatus Status { get; private set; }

        [JsonPropertyName("requestMethod")]
        public string RequestMethod { get; private set; }

        [JsonPropertyName("requestPath")]
        public string RequestPath { get; private set; }

        [JsonPropertyName("requestHeaders")]
        public List<Headers> RequestHeaders { get; private set; }

        [JsonPropertyName("responseStatusCode")]
        public long ResponseStatusCode { get; private set; }

        [JsonPropertyName("responseBody")]
        public string ResponseBody { get; private set; }

        [JsonPropertyName("responseHeaders")]
        public List<Headers> ResponseHeaders { get; private set; }

        [JsonPropertyName("logs")]
        public string Logs { get; private set; }

        [JsonPropertyName("errors")]
        public string Errors { get; private set; }

        [JsonPropertyName("duration")]
        public double Duration { get; private set; }

        [JsonPropertyName("scheduledAt")]
        public string? ScheduledAt { get; private set; }

        public Execution(
            string id,
            string createdAt,
            string updatedAt,
            List<string> permissions,
            string resourceId,
            Appwrite.Enums.ExecutionResourceType resourceType,
            string deploymentId,
            Appwrite.Enums.ExecutionTrigger trigger,
            Appwrite.Enums.ExecutionStatus status,
            string requestMethod,
            string requestPath,
            List<Headers> requestHeaders,
            long responseStatusCode,
            string responseBody,
            List<Headers> responseHeaders,
            string logs,
            string errors,
            double duration,
            string? scheduledAt
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Permissions = permissions;
            ResourceId = resourceId;
            ResourceType = resourceType;
            DeploymentId = deploymentId;
            Trigger = trigger;
            Status = status;
            RequestMethod = requestMethod;
            RequestPath = requestPath;
            RequestHeaders = requestHeaders;
            ResponseStatusCode = responseStatusCode;
            ResponseBody = responseBody;
            ResponseHeaders = responseHeaders;
            Logs = logs;
            Errors = errors;
            Duration = duration;
            ScheduledAt = scheduledAt;
        }

        public static Execution From(Dictionary<string, object> map) => new Execution(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            permissions: map["$permissions"].ConvertToList<string>(),
            resourceId: map["resourceId"].ToString(),
            resourceType: new Appwrite.Enums.ExecutionResourceType(map["resourceType"].ToString()!),
            deploymentId: map["deploymentId"].ToString(),
            trigger: new Appwrite.Enums.ExecutionTrigger(map["trigger"].ToString()!),
            status: new Appwrite.Enums.ExecutionStatus(map["status"].ToString()!),
            requestMethod: map["requestMethod"].ToString(),
            requestPath: map["requestPath"].ToString(),
            requestHeaders: map["requestHeaders"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Headers.From(map: it)).ToList(),
            responseStatusCode: Convert.ToInt64(map["responseStatusCode"]),
            responseBody: map["responseBody"].ToString(),
            responseHeaders: map["responseHeaders"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Headers.From(map: it)).ToList(),
            logs: map["logs"].ToString(),
            errors: map["errors"].ToString(),
            duration: Convert.ToDouble(map["duration"]),
            scheduledAt: map.TryGetValue("scheduledAt", out var scheduledAt) ? scheduledAt?.ToString() : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "$permissions", Permissions },
            { "resourceId", ResourceId },
            { "resourceType", ResourceType.Value },
            { "deploymentId", DeploymentId },
            { "trigger", Trigger.Value },
            { "status", Status.Value },
            { "requestMethod", RequestMethod },
            { "requestPath", RequestPath },
            { "requestHeaders", RequestHeaders?.Select(it => it.ToMap()).ToList() },
            { "responseStatusCode", ResponseStatusCode },
            { "responseBody", ResponseBody },
            { "responseHeaders", ResponseHeaders?.Select(it => it.ToMap()).ToList() },
            { "logs", Logs },
            { "errors", Errors },
            { "duration", Duration },
            { "scheduledAt", ScheduledAt }
        };
    }
}
