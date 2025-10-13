
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class SiteList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("sites")]
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
            sites: map["sites"].ConvertToList<Dictionary<string, object>>().Select(it => Site.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "sites", Sites.Select(it => it.ToMap()) }
        };
    }
}
