
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class RuntimeList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("runtimes")]
        public List<Runtime> Runtimes { get; private set; }

        public RuntimeList(
            long total,
            List<Runtime> runtimes
        ) {
            Total = total;
            Runtimes = runtimes;
        }

        public static RuntimeList From(Dictionary<string, object> map) => new RuntimeList(
            total: Convert.ToInt64(map["total"]),
            runtimes: ((JArray)map["runtimes"]).ToObject<List<Dictionary<string, object>>>().Select(it => Runtime.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "runtimes", Runtimes.Select(it => it.ToMap()) }
        };
    }
}