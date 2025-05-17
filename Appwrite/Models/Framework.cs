
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Framework
    {
        [JsonProperty("key")]
        public string Key { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("buildRuntime")]
        public string BuildRuntime { get; private set; }

        [JsonProperty("runtimes")]
        public List<string> Runtimes { get; private set; }

        [JsonProperty("adapters")]
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
            runtimes: ((JArray)map["runtimes"]).ToObject<List<string>>(),
            adapters: ((JArray)map["adapters"]).ToObject<List<Dictionary<string, object>>>().Select(it => FrameworkAdapter.From(map: it)).ToList()
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
