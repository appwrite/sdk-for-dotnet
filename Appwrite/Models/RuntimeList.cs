using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class RuntimeList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("runtimes")]
        public List&lt;Runtime&gt; Runtimes { get; private set; }

        public RuntimeList(
            long total,
            List&lt;Runtime&gt; runtimes
        ) {
            Total = total;
            Runtimes = runtimes;
        }

        public static RuntimeList From(Dictionary<string, object> map) => new RuntimeList(
            total: Convert.ToInt64(map["total"]),
            runtimes: map["runtimes"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Runtime.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["runtimes"]).Select(it => Runtime.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "runtimes", Runtimes.Select(it => it.ToMap()) }
        };
    }
}
