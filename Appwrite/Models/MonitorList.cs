
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class MonitorList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("monitors")]
        public List<Monitor> Monitors { get; private set; }

        public MonitorList(
            long total,
            List<Monitor> monitors
        )
        {
            Total = total;
            Monitors = monitors;
        }

        public static MonitorList From(Dictionary<string, object> map) => new MonitorList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            monitors: (map.ContainsKey("monitors") ? map["monitors"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Monitor.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "monitors", Monitors?.Select(it => it.ToMap()).ToList() }
        };
    }
}
