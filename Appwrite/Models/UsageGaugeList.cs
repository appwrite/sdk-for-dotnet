
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class UsageGaugeList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("gauges")]
        public List<UsageGauge> Gauges { get; private set; }

        public UsageGaugeList(
            long total,
            List<UsageGauge> gauges
        )
        {
            Total = total;
            Gauges = gauges;
        }

        public static UsageGaugeList From(Dictionary<string, object> map) => new UsageGaugeList(
            total: Convert.ToInt64(map["total"]),
            gauges: map["gauges"].ConvertToList<Dictionary<string, object>>().Select(it => UsageGauge.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "gauges", Gauges?.Select(it => it.ToMap()).ToList() }
        };
    }
}
