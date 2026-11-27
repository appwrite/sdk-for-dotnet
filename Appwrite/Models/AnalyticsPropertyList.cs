
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AnalyticsPropertyList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("properties")]
        public List<AnalyticsProperty> Properties { get; private set; }

        public AnalyticsPropertyList(
            long total,
            List<AnalyticsProperty> properties
        )
        {
            Total = total;
            Properties = properties;
        }

        public static AnalyticsPropertyList From(Dictionary<string, object> map) => new AnalyticsPropertyList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            properties: (map.ContainsKey("properties") ? map["properties"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.AnalyticsProperty.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "properties", Properties?.Select(it => it.ToMap()).ToList() }
        };
    }
}
