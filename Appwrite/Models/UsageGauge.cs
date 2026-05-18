
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class UsageGauge
    {
        [JsonPropertyName("metric")]
        public string Metric { get; private set; }

        [JsonPropertyName("value")]
        public long Value { get; private set; }

        [JsonPropertyName("time")]
        public string Time { get; private set; }

        public UsageGauge(
            string metric,
            long xvalue,
            string time
        )
        {
            Metric = metric;
            Value = xvalue;
            Time = time;
        }

        public static UsageGauge From(Dictionary<string, object> map) => new UsageGauge(
            metric: map["metric"].ToString(),
            xvalue: Convert.ToInt64(map["value"]),
            time: map["time"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "metric", Metric },
            { "value", Value },
            { "time", Time }
        };
    }
}
