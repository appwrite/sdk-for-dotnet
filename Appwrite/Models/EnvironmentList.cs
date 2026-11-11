
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class EnvironmentList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("environments")]
        public List<Environment> Environments { get; private set; }

        public EnvironmentList(
            long total,
            List<Environment> environments
        )
        {
            Total = total;
            Environments = environments;
        }

        public static EnvironmentList From(Dictionary<string, object> map) => new EnvironmentList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            environments: (map.ContainsKey("environments") ? map["environments"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Environment.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "environments", Environments?.Select(it => it.ToMap()).ToList() }
        };
    }
}
