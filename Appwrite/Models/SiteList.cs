using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class SiteList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("sites")]
        public List&lt;Site&gt; Sites { get; private set; }

        public SiteList(
            long total,
            List&lt;Site&gt; sites
        ) {
            Total = total;
            Sites = sites;
        }

        public static SiteList From(Dictionary<string, object> map) => new SiteList(
            total: Convert.ToInt64(map["total"]),
            sites: map["sites"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Site.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["sites"]).Select(it => Site.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "sites", Sites.Select(it => it.ToMap()) }
        };
    }
}
