
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

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
        )
        {
            Total = total;
            Rules = rules;
        }

        public static ProxyRuleList From(Dictionary<string, object> map) => new ProxyRuleList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            rules: (map.ContainsKey("rules") ? map["rules"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.ProxyRule.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "rules", Rules?.Select(it => it.ToMap()).ToList() }
        };
    }
}
