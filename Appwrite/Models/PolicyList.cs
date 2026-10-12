
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PolicyList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("policies")]
        public List<object> Policies { get; private set; }

        public PolicyList(
            long total,
            List<object> policies
        )
        {
            Total = total;
            Policies = policies;
        }

        public static PolicyList From(Dictionary<string, object> map) => new PolicyList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            policies: map["policies"].ConvertToList<object>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "policies", Policies }
        };
    }
}
