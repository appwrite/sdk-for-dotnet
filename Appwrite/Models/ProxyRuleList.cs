
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class ProxyRuleList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("rules")]
        public List<ProxyRule> Rules { get; private set; }

        public ProxyRuleList(
            long total,
            List<ProxyRule> rules
        ) {
            Total = total;
            Rules = rules;
        }

        public static ProxyRuleList From(Dictionary<string, object> map) => new ProxyRuleList(
            total: Convert.ToInt64(map["total"]),
            rules: map["rules"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => ProxyRule.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["rules"]).Select(it => ProxyRule.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "rules", Rules.Select(it => it.ToMap()) }
        };
    }
}
