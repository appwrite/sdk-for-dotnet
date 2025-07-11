
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class Framework
    {
        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("buildRuntime")]
        public string BuildRuntime { get; private set; }

        [JsonPropertyName("runtimes")]
        public List<string> Runtimes { get; private set; }

        [JsonPropertyName("adapters")]
        public List<FrameworkAdapter> Adapters { get; private set; }

        public Framework(
            string key,
            string name,
            string buildRuntime,
            List<string> runtimes,
            List<FrameworkAdapter> adapters
        ) {
            Key = key;
            Name = name;
            BuildRuntime = buildRuntime;
            Runtimes = runtimes;
            Adapters = adapters;
        }

        public static Framework From(Dictionary<string, object> map) => new Framework(
            key: map["key"].ToString(),
            name: map["name"].ToString(),
            buildRuntime: map["buildRuntime"].ToString(),
            runtimes: map["runtimes"] is JsonElement jsonArrayProp4 ? jsonArrayProp4.Deserialize<List<string>>()! : (List<string>)map["runtimes"],
            adapters: map["adapters"] is JsonElement jsonArray5 ? jsonArray5.Deserialize<List<Dictionary<string, object>>>()!.Select(it => FrameworkAdapter.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["adapters"]).Select(it => FrameworkAdapter.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "name", Name },
            { "buildRuntime", BuildRuntime },
            { "runtimes", Runtimes },
            { "adapters", Adapters.Select(it => it.ToMap()) }
        };
    }
}
