
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class WafRuleList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("rules")]
        public List<object> Rules { get; private set; }

        public WafRuleList(
            long total,
            List<object> rules
        )
        {
            Total = total;
            Rules = rules;
        }

        public static WafRuleList From(Dictionary<string, object> map) => new WafRuleList(
            total: Convert.ToInt64(map["total"]),
            rules: map["rules"].ConvertToList<object>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "rules", Rules }
        };
    }
}
