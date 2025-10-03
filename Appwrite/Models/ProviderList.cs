using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class ProviderList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("providers")]
        public List&lt;Provider&gt; Providers { get; private set; }

        public ProviderList(
            long total,
            List&lt;Provider&gt; providers
        ) {
            Total = total;
            Providers = providers;
        }

        public static ProviderList From(Dictionary<string, object> map) => new ProviderList(
            total: Convert.ToInt64(map["total"]),
            providers: map["providers"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Provider.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["providers"]).Select(it => Provider.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "providers", Providers.Select(it => it.ToMap()) }
        };
    }
}
