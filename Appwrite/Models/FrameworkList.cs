
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class FrameworkList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("frameworks")]
        public List<Framework> Frameworks { get; private set; }

        public FrameworkList(
            long total,
            List<Framework> frameworks
        ) {
            Total = total;
            Frameworks = frameworks;
        }

        public static FrameworkList From(Dictionary<string, object> map) => new FrameworkList(
            total: Convert.ToInt64(map["total"]),
            frameworks: map["frameworks"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Framework.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["frameworks"]).Select(it => Framework.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "frameworks", Frameworks.Select(it => it.ToMap()) }
        };
    }
}
