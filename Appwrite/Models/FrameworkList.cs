
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class FrameworkList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("frameworks")]
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
            frameworks: ((JArray)map["frameworks"]).ToObject<List<Dictionary<string, object>>>().Select(it => Framework.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "frameworks", Frameworks.Select(it => it.ToMap()) }
        };
    }
}
