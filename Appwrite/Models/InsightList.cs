
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class InsightList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("insights")]
        public List<Insight> Insights { get; private set; }

        public InsightList(
            long total,
            List<Insight> insights
        )
        {
            Total = total;
            Insights = insights;
        }

        public static InsightList From(Dictionary<string, object> map) => new InsightList(
            total: Convert.ToInt64(map["total"]),
            insights: map["insights"].ConvertToList<Dictionary<string, object>>().Select(it => Insight.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "insights", Insights?.Select(it => it.ToMap()).ToList() }
        };
    }
}
