
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class SiteList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("sites")]
        public List<Site> Sites { get; private set; }

        public SiteList(
            long total,
            List<Site> sites
        ) {
            Total = total;
            Sites = sites;
        }

        public static SiteList From(Dictionary<string, object> map) => new SiteList(
            total: Convert.ToInt64(map["total"]),
            sites: ((JArray)map["sites"]).ToObject<List<Dictionary<string, object>>>().Select(it => Site.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "sites", Sites.Select(it => it.ToMap()) }
        };
    }
}
