using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class Execution
    {
        [JsonPropertyName("$id")]
        public string id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string createdAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string updatedAt { get; private set; }

        [JsonPropertyName("$permissions")]
        public List&lt;string&gt; permissions { get; private set; }

        [JsonPropertyName("functionId")]
        public string FunctionId { get; private set; }

        [JsonPropertyName("deploymentId")]
        public string DeploymentId { get; private set; }

        [JsonPropertyName("trigger")]
        public ExecutionTrigger Trigger { get; private set; }

        [JsonPropertyName("status")]
        public ExecutionStatus Status { get; private set; }

        [JsonPropertyName("requestMethod")]
        public string RequestMethod { get; private set; }

        [JsonPropertyName("requestPath")]
        public string RequestPath { get; private set; }

        [JsonPropertyName("requestHeaders")]
        public List&lt;Headers&gt; RequestHeaders { get; private set; }

        [JsonPropertyName("responseStatusCode")]
        public long ResponseStatusCode { get; private set; }

        [JsonPropertyName("responseBody")]
        public string ResponseBody { get; private set; }

        [JsonPropertyName("responseHeaders")]
        public List&lt;Headers&gt; ResponseHeaders { get; private set; }

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
            List&lt;string&gt; permissions,
            string functionId,
            string deploymentId,
            ExecutionTrigger trigger,
            ExecutionStatus status,
            string requestMethod,
            string requestPath,
            List&lt;Headers&gt; requestHeaders,
            long responseStatusCode,
            string responseBody,
            List&lt;Headers&gt; responseHeaders,
            string logs,
            string errors,
            double duration,
            string? scheduledAt
        ) {
            id = id;
            createdAt = createdAt;
            updatedAt = updatedAt;
            permissions = permissions;
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
            trigger: new ExecutionTrigger(map["trigger"].ToString()!),
            status: new ExecutionStatus(map["status"].ToString()!),
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
            { "$id", id },
            { "$createdAt", createdAt },
            { "$updatedAt", updatedAt },
            { "$permissions", permissions },
            { "functionId", FunctionId },
            { "deploymentId", DeploymentId },
            { "trigger", Trigger.Value },
            { "status", Status.Value },
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
