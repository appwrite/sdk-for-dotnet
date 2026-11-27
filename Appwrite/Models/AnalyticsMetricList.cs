
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AnalyticsMetricList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("metrics")]
        public List<AnalyticsMetric> Metrics { get; private set; }

        public AnalyticsMetricList(
            long total,
            List<AnalyticsMetric> metrics
        )
        {
            Total = total;
            Metrics = metrics;
        }

        public static AnalyticsMetricList From(Dictionary<string, object> map) => new AnalyticsMetricList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            metrics: (map.ContainsKey("metrics") ? map["metrics"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.AnalyticsMetric.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "metrics", Metrics?.Select(it => it.ToMap()).ToList() }
        };
    }
}
