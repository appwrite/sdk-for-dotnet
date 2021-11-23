
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

        [JsonProperty("$permissions")]
        public Permissions Permissions { get; set; }

        [JsonProperty("functionId")]
        public string FunctionId { get; set; }

        [JsonProperty("dateCreated")]
        public int DateCreated { get; set; }

        [JsonProperty("trigger")]
        public string Trigger { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("exitCode")]
        public int ExitCode { get; set; }

        [JsonProperty("stdout")]
        public string Stdout { get; set; }

        [JsonProperty("stderr")]
        public string Stderr { get; set; }

        [JsonProperty("time")]
        public double Time { get; set; }


        public Execution(
            string id,
            Permissions permissions,
            string functionId,
            int dateCreated,
            string trigger,
            string status,
            int exitCode,
            string stdout,
            string stderr,
            double time
        ) {
            Id = id;
            Permissions = permissions;
            FunctionId = functionId;
            DateCreated = dateCreated;
            Trigger = trigger;
            Status = status;
            ExitCode = exitCode;
            Stdout = stdout;
            Stderr = stderr;
            Time = time;
        }

        public static Execution From(Dictionary<string, object> map) => new Execution(
            id: (string)map["$id"],
            permissions: Permissions.From(map: ((JObject)map["$permissions"]).ToObject<Dictionary<string, object>>()!),
            functionId: (string)map["functionId"],
            dateCreated: (int)map["dateCreated"],
            trigger: (string)map["trigger"],
            status: (string)map["status"],
            exitCode: (int)map["exitCode"],
            stdout: (string)map["stdout"],
            stderr: (string)map["stderr"],
            time: (double)map["time"]
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "$id", Id },
            { "$permissions", Permissions.ToMap() },
            { "functionId", FunctionId },
            { "dateCreated", DateCreated },
            { "trigger", Trigger },
            { "status", Status },
            { "exitCode", ExitCode },
            { "stdout", Stdout },
            { "stderr", Stderr },
            { "time", Time }
        };
    }
}