
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

        [JsonProperty("$permissions")]
        public Permissions Permissions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("dateCreated")]
        public int DateCreated { get; set; }

        [JsonProperty("dateUpdated")]
        public int DateUpdated { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("runtime")]
        public string Runtime { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("vars")]
        public string Vars { get; set; }

        [JsonProperty("events")]
        public List<object> Events { get; set; }

        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        [JsonProperty("scheduleNext")]
        public int ScheduleNext { get; set; }

        [JsonProperty("schedulePrevious")]
        public int SchedulePrevious { get; set; }

        [JsonProperty("timeout")]
        public int Timeout { get; set; }


        public Function(
            string id,
            Permissions permissions,
            string name,
            int dateCreated,
            int dateUpdated,
            string status,
            string runtime,
            string tag,
            string vars,
            List<object> events,
            string schedule,
            int scheduleNext,
            int schedulePrevious,
            int timeout
        ) {
            Id = id;
            Permissions = permissions;
            Name = name;
            DateCreated = dateCreated;
            DateUpdated = dateUpdated;
            Status = status;
            Runtime = runtime;
            Tag = tag;
            Vars = vars;
            Events = events;
            Schedule = schedule;
            ScheduleNext = scheduleNext;
            SchedulePrevious = schedulePrevious;
            Timeout = timeout;
        }

        public static Function From(Dictionary<string, object> map) => new Function(
            id: (string)map["$id"],
            permissions: Permissions.From(map: ((JObject)map["$permissions"]).ToObject<Dictionary<string, object>>()!),
            name: (string)map["name"],
            dateCreated: (int)map["dateCreated"],
            dateUpdated: (int)map["dateUpdated"],
            status: (string)map["status"],
            runtime: (string)map["runtime"],
            tag: (string)map["tag"],
            vars: (string)map["vars"],
            events: ((JArray)map["events"]).ToObject<List<object>>(),
            schedule: (string)map["schedule"],
            scheduleNext: (int)map["scheduleNext"],
            schedulePrevious: (int)map["schedulePrevious"],
            timeout: (int)map["timeout"]
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "$id", Id },
            { "$permissions", Permissions.ToMap() },
            { "name", Name },
            { "dateCreated", DateCreated },
            { "dateUpdated", DateUpdated },
            { "status", Status },
            { "runtime", Runtime },
            { "tag", Tag },
            { "vars", Vars },
            { "events", Events },
            { "schedule", Schedule },
            { "scheduleNext", ScheduleNext },
            { "schedulePrevious", SchedulePrevious },
            { "timeout", Timeout }
        };
    }
}