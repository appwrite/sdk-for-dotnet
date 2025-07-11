
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class ProviderRepositoryFrameworkList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("frameworkProviderRepositories")]
        public List<ProviderRepositoryFramework> FrameworkProviderRepositories { get; private set; }

        public ProviderRepositoryFrameworkList(
            long total,
            List<ProviderRepositoryFramework> frameworkProviderRepositories
        ) {
            Total = total;
            FrameworkProviderRepositories = frameworkProviderRepositories;
        }

        public static ProviderRepositoryFrameworkList From(Dictionary<string, object> map) => new ProviderRepositoryFrameworkList(
            total: Convert.ToInt64(map["total"]),
            frameworkProviderRepositories: map["frameworkProviderRepositories"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => ProviderRepositoryFramework.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["frameworkProviderRepositories"]).Select(it => ProviderRepositoryFramework.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "frameworkProviderRepositories", FrameworkProviderRepositories.Select(it => it.ToMap()) }
        };
    }
}
