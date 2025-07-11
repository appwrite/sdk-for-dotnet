
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class ProviderRepositoryRuntimeList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("runtimeProviderRepositories")]
        public List<ProviderRepositoryRuntime> RuntimeProviderRepositories { get; private set; }

        public ProviderRepositoryRuntimeList(
            long total,
            List<ProviderRepositoryRuntime> runtimeProviderRepositories
        ) {
            Total = total;
            RuntimeProviderRepositories = runtimeProviderRepositories;
        }

        public static ProviderRepositoryRuntimeList From(Dictionary<string, object> map) => new ProviderRepositoryRuntimeList(
            total: Convert.ToInt64(map["total"]),
            runtimeProviderRepositories: map["runtimeProviderRepositories"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => ProviderRepositoryRuntime.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["runtimeProviderRepositories"]).Select(it => ProviderRepositoryRuntime.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "runtimeProviderRepositories", RuntimeProviderRepositories.Select(it => it.ToMap()) }
        };
    }
}
