
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Execution
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("$permissions")]
        public List<object> Permissions { get; private set; }

        [JsonProperty("functionId")]
        public string FunctionId { get; private set; }

        [JsonProperty("trigger")]
        public string Trigger { get; private set; }

        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("requestMethod")]
        public string RequestMethod { get; private set; }

        [JsonProperty("requestPath")]
        public string RequestPath { get; private set; }

        [JsonProperty("requestHeaders")]
        public List<Headers> RequestHeaders { get; private set; }

        [JsonProperty("responseStatusCode")]
        public long ResponseStatusCode { get; private set; }

        [JsonProperty("responseBody")]
        public string ResponseBody { get; private set; }

        [JsonProperty("responseHeaders")]
        public List<Headers> ResponseHeaders { get; private set; }

        [JsonProperty("logs")]
        public string Logs { get; private set; }

        [JsonProperty("errors")]
        public string Errors { get; private set; }

        [JsonProperty("duration")]
        public double Duration { get; private set; }

        public Execution(
            string id,
            string createdAt,
            string updatedAt,
            List<object> permissions,
            string functionId,
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
            double duration
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Permissions = permissions;
            FunctionId = functionId;
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
        }

        public static Execution From(Dictionary<string, object> map) => new Execution(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            permissions: ((JArray)map["$permissions"]).ToObject<List<object>>(),
            functionId: map["functionId"].ToString(),
            trigger: map["trigger"].ToString(),
            status: map["status"].ToString(),
            requestMethod: map["requestMethod"].ToString(),
            requestPath: map["requestPath"].ToString(),
            requestHeaders: ((JArray)map["requestHeaders"]).ToObject<List<Dictionary<string, object>>>().Select(it => Headers.From(map: it)).ToList(),
            responseStatusCode: Convert.ToInt64(map["responseStatusCode"]),
            responseBody: map["responseBody"].ToString(),
            responseHeaders: ((JArray)map["responseHeaders"]).ToObject<List<Dictionary<string, object>>>().Select(it => Headers.From(map: it)).ToList(),
            logs: map["logs"].ToString(),
            errors: map["errors"].ToString(),
            duration: Convert.ToDouble(map["duration"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "$permissions", Permissions },
            { "functionId", FunctionId },
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
            { "duration", Duration }
        };
    }
}