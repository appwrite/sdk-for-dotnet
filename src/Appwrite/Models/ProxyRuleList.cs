
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class ProxyRuleList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("rules")]
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
            rules: ((JArray)map["rules"]).ToObject<List<Dictionary<string, object>>>().Select(it => ProxyRule.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "rules", Rules.Select(it => it.ToMap()) }
        };
    }
}