
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

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

        [JsonPropertyName("functionId")]
        public string FunctionId { get; private set; }

        [JsonPropertyName("deploymentId")]
        public string DeploymentId { get; private set; }

        [JsonPropertyName("trigger")]
        public string Trigger { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

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
            string functionId,
            string deploymentId,
            string trigger,
            string status,
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
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Permissions = permissions;
            FunctionId = functionId;
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
            permissions: map["$permissions"] is JsonElement jsonArrayProp4 ? jsonArrayProp4.Deserialize<List<string>>()! : (List<string>)map["$permissions"],
            functionId: map["functionId"].ToString(),
            deploymentId: map["deploymentId"].ToString(),
            trigger: map["trigger"].ToString(),
            status: map["status"].ToString(),
            requestMethod: map["requestMethod"].ToString(),
            requestPath: map["requestPath"].ToString(),
            requestHeaders: map["requestHeaders"] is JsonElement jsonArray11 ? jsonArray11.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Headers.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["requestHeaders"]).Select(it => Headers.From(map: it)).ToList(),
            responseStatusCode: Convert.ToInt64(map["responseStatusCode"]),
            responseBody: map["responseBody"].ToString(),
            responseHeaders: map["responseHeaders"] is JsonElement jsonArray14 ? jsonArray14.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Headers.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["responseHeaders"]).Select(it => Headers.From(map: it)).ToList(),
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
            { "functionId", FunctionId },
            { "deploymentId", DeploymentId },
            { "trigger", Trigger },
            { "status", Status },
            { "requestMethod", RequestMethod },
            { "requestPath", RequestPath },
            { "requestHeaders", RequestHeaders.Select(it => it.ToMap()) },
            { "responseStatusCode", ResponseStatusCode },
            { "responseBody", ResponseBody },
            { "responseHeaders", ResponseHeaders.Select(it => it.ToMap()) },
            { "logs", Logs },
            { "errors", Errors },
            { "duration", Duration },
            { "scheduledAt", ScheduledAt }
        };
    }
}
