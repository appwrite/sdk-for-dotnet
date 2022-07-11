
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
        public string Id { get; set; }

        [JsonProperty("$createdAt")]
        public long CreatedAt { get; set; }

        [JsonProperty("$updatedAt")]
        public long UpdatedAt { get; set; }

        [JsonProperty("$read")]
        public List<object> Read { get; set; }

        [JsonProperty("functionId")]
        public string FunctionId { get; set; }

        [JsonProperty("trigger")]
        public string Trigger { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public long StatusCode { get; set; }

        [JsonProperty("response")]
        public string Response { get; set; }

        [JsonProperty("stderr")]
        public string Stderr { get; set; }

        [JsonProperty("time")]
        public double Time { get; set; }


        public Execution(
            string id,
            long createdAt,
            long updatedAt,
            List<object> read,
            string functionId,
            string trigger,
            string status,
            long statusCode,
            string response,
            string stderr,
            double time
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Read = read;
            FunctionId = functionId;
            Trigger = trigger;
            Status = status;
            StatusCode = statusCode;
            Response = response;
            Stderr = stderr;
            Time = time;
        }

        public static Execution From(Dictionary<string, object> map) => new Execution(
            id: (string)map["$id"],
            createdAt: Convert.ToInt64(map["$createdAt"]),
            updatedAt: Convert.ToInt64(map["$updatedAt"]),
            read: ((JArray)map["$read"]).ToObject<List<object>>(),
            functionId: (string)map["functionId"],
            trigger: (string)map["trigger"],
            status: (string)map["status"],
            statusCode: Convert.ToInt64(map["statusCode"]),
            response: (string)map["response"],
            stderr: (string)map["stderr"],
            time: Convert.ToDouble(map["time"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "$read", Read },
            { "functionId", FunctionId },
            { "trigger", Trigger },
            { "status", Status },
            { "statusCode", StatusCode },
            { "response", Response },
            { "stderr", Stderr },
            { "time", Time }
        };
    }
}