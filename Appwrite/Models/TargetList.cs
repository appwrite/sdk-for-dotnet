
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class TargetList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("targets")]
        public List<Target> Targets { get; private set; }

        public TargetList(
            long total,
            List<Target> targets
        ) {
            Total = total;
            Targets = targets;
        }

        public static TargetList From(Dictionary<string, object> map) => new TargetList(
            total: Convert.ToInt64(map["total"]),
            targets: ((JArray)map["targets"]).ToObject<List<Dictionary<string, object>>>().Select(it => Target.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "targets", Targets.Select(it => it.ToMap()) }
        };
    }
}