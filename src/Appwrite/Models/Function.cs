
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
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("execute")]
        public List<object> Execute { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; private set; }

        [JsonProperty("runtime")]
        public string Runtime { get; private set; }

        [JsonProperty("deployment")]
        public string Deployment { get; private set; }

        [JsonProperty("vars")]
        public List<Variable> Vars { get; private set; }

        [JsonProperty("events")]
        public List<object> Events { get; private set; }

        [JsonProperty("schedule")]
        public string Schedule { get; private set; }

        [JsonProperty("scheduleNext")]
        public string ScheduleNext { get; private set; }

        [JsonProperty("schedulePrevious")]
        public string SchedulePrevious { get; private set; }

        [JsonProperty("timeout")]
        public long Timeout { get; private set; }

        public Function(
            string id,
            string createdAt,
            string updatedAt,
            List<object> execute,
            string name,
            bool enabled,
            string runtime,
            string deployment,
            List<Variable> vars,
            List<object> events,
            string schedule,
            string scheduleNext,
            string schedulePrevious,
            long timeout
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Execute = execute;
            Name = name;
            Enabled = enabled;
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
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            execute: ((JArray)map["execute"]).ToObject<List<object>>(),
            name: map["name"].ToString(),
            enabled: (bool)map["enabled"],
            runtime: map["runtime"].ToString(),
            deployment: map["deployment"].ToString(),
            vars: ((JArray)map["vars"]).ToObject<List<Dictionary<string, object>>>().Select(it => Variable.From(map: it)).ToList(),
            events: ((JArray)map["events"]).ToObject<List<object>>(),
            schedule: map["schedule"].ToString(),
            scheduleNext: map["scheduleNext"].ToString(),
            schedulePrevious: map["schedulePrevious"].ToString(),
            timeout: Convert.ToInt64(map["timeout"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "execute", Execute },
            { "name", Name },
            { "enabled", Enabled },
            { "runtime", Runtime },
            { "deployment", Deployment },
            { "vars", Vars.Select(it => it.ToMap()) },
            { "events", Events },
            { "schedule", Schedule },
            { "scheduleNext", ScheduleNext },
            { "schedulePrevious", SchedulePrevious },
            { "timeout", Timeout }
        };
    }
}