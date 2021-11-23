
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class LogList
    {
        [JsonProperty("logs")]
        public List<Log> Logs { get; set; }


        public LogList(
            List<Log> logs
        ) {
            Logs = logs;
        }

        public static LogList From(Dictionary<string, object> map) => new LogList(
            logs: ((JArray)map["logs"]).ToObject<List<Log>>()!
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "logs", Logs.Select(it => it.ToMap()) }
        };
    }
}