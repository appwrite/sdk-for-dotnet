
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class ProviderList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("providers")]
        public List<Provider> Providers { get; private set; }

        public ProviderList(
            long total,
            List<Provider> providers
        ) {
            Total = total;
            Providers = providers;
        }

        public static ProviderList From(Dictionary<string, object> map) => new ProviderList(
            total: Convert.ToInt64(map["total"]),
            providers: ((JArray)map["providers"]).ToObject<List<Dictionary<string, object>>>().Select(it => Provider.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "providers", Providers.Select(it => it.ToMap()) }
        };
    }
}