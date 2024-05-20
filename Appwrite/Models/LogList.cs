
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class LogList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("logs")]
        public List<Log> Logs { get; private set; }

        public LogList(
            long total,
            List<Log> logs
        ) {
            Total = total;
            Logs = logs;
        }

        public static LogList From(Dictionary<string, object> map) => new LogList(
            total: Convert.ToInt64(map["total"]),
            logs: ((JArray)map["logs"]).ToObject<List<Dictionary<string, object>>>().Select(it => Log.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "logs", Logs.Select(it => it.ToMap()) }
        };
    }
}