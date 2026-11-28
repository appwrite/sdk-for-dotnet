
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AnalyticsAnnotationList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("annotations")]
        public List<AnalyticsAnnotation> Annotations { get; private set; }

        public AnalyticsAnnotationList(
            long total,
            List<AnalyticsAnnotation> annotations
        )
        {
            Total = total;
            Annotations = annotations;
        }

        public static AnalyticsAnnotationList From(Dictionary<string, object> map) => new AnalyticsAnnotationList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            annotations: (map.ContainsKey("annotations") ? map["annotations"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.AnalyticsAnnotation.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "annotations", Annotations?.Select(it => it.ToMap()).ToList() }
        };
    }
}
