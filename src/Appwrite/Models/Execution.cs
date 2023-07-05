
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

        [JsonProperty("statusCode")]
        public long StatusCode { get; private set; }

        [JsonProperty("response")]
        public string Response { get; private set; }

        [JsonProperty("stdout")]
        public string Stdout { get; private set; }

        [JsonProperty("stderr")]
        public string Stderr { get; private set; }

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
            long statusCode,
            string response,
            string stdout,
            string stderr,
            double duration
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Permissions = permissions;
            FunctionId = functionId;
            Trigger = trigger;
            Status = status;
            StatusCode = statusCode;
            Response = response;
            Stdout = stdout;
            Stderr = stderr;
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
            statusCode: Convert.ToInt64(map["statusCode"]),
            response: map["response"].ToString(),
            stdout: map["stdout"].ToString(),
            stderr: map["stderr"].ToString(),
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
            { "statusCode", StatusCode },
            { "response", Response },
            { "stdout", Stdout },
            { "stderr", Stderr },
            { "duration", Duration }
        };
    }
}