
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Function
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        [JsonProperty("$createdAt")]
        public long CreatedAt { get; set; }

        [JsonProperty("$updatedAt")]
        public long UpdatedAt { get; set; }

        [JsonProperty("execute")]
        public List<object> Execute { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("runtime")]
        public string Runtime { get; set; }

        [JsonProperty("deployment")]
        public string Deployment { get; set; }

        [JsonProperty("vars")]
        public object Vars { get; set; }

        [JsonProperty("events")]
        public List<object> Events { get; set; }

        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        [JsonProperty("scheduleNext")]
        public long ScheduleNext { get; set; }

        [JsonProperty("schedulePrevious")]
        public long SchedulePrevious { get; set; }

        [JsonProperty("timeout")]
        public long Timeout { get; set; }


        public Function(
            string id,
            long createdAt,
            long updatedAt,
            List<object> execute,
            string name,
            string status,
            string runtime,
            string deployment,
            object vars,
            List<object> events,
            string schedule,
            long scheduleNext,
            long schedulePrevious,
            long timeout
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Execute = execute;
            Name = name;
            Status = status;
            Runtime = runtime;
            Deployment = deployment;
            Vars = vars;
            Events = events;
            Schedule = schedule;
            ScheduleNext = scheduleNext;
            SchedulePrevious = schedulePrevious;
            Timeout = timeout;
        }

        public static Function From(Dictionary<string, object> map) => new Function(
            id: (string)map["$id"],
            createdAt: Convert.ToInt64(map["$createdAt"]),
            updatedAt: Convert.ToInt64(map["$updatedAt"]),
            execute: ((JArray)map["execute"]).ToObject<List<object>>(),
            name: (string)map["name"],
            status: (string)map["status"],
            runtime: (string)map["runtime"],
            deployment: (string)map["deployment"],
            vars: (object)map["vars"],
            events: ((JArray)map["events"]).ToObject<List<object>>(),
            schedule: (string)map["schedule"],
            scheduleNext: Convert.ToInt64(map["scheduleNext"]),
            schedulePrevious: Convert.ToInt64(map["schedulePrevious"]),
            timeout: Convert.ToInt64(map["timeout"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "execute", Execute },
            { "name", Name },
            { "status", Status },
            { "runtime", Runtime },
            { "deployment", Deployment },
            { "vars", Vars },
            { "events", Events },
            { "schedule", Schedule },
            { "scheduleNext", ScheduleNext },
            { "schedulePrevious", SchedulePrevious },
            { "timeout", Timeout }
        };
    }
}