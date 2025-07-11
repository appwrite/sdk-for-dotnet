
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class MetricBreakdown
    {
        [JsonPropertyName("resourceId")]
        public string? ResourceId { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("value")]
        public long Value { get; private set; }

        [JsonPropertyName("estimate")]
        public double? Estimate { get; private set; }

        public MetricBreakdown(
            string? resourceId,
            string name,
            long xvalue,
            double? estimate
        ) {
            ResourceId = resourceId;
            Name = name;
            Value = xvalue;
            Estimate = estimate;
        }

        public static MetricBreakdown From(Dictionary<string, object> map) => new MetricBreakdown(
            resourceId: map.TryGetValue("resourceId", out var resourceId) ? resourceId?.ToString() : null,
            name: map["name"].ToString(),
            xvalue: Convert.ToInt64(map["value"]),
            estimate: map["estimate"] == null ? null :Convert.ToDouble(map["estimate"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "resourceId", ResourceId },
            { "name", Name },
            { "value", Value },
            { "estimate", Estimate }
        };
    }
}
