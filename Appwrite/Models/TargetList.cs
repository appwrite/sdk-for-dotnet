
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class TargetList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("targets")]
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
            targets: map["targets"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Target.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["targets"]).Select(it => Target.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "targets", Targets.Select(it => it.ToMap()) }
        };
    }
}
