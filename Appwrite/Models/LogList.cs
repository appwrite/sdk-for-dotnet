
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class LogList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("logs")]
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
            logs: map["logs"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Log.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["logs"]).Select(it => Log.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "logs", Logs.Select(it => it.ToMap()) }
        };
    }
}
