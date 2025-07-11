
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class AlgoArgon2
    {
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("memoryCost")]
        public long MemoryCost { get; private set; }

        [JsonPropertyName("timeCost")]
        public long TimeCost { get; private set; }

        [JsonPropertyName("threads")]
        public long Threads { get; private set; }

        public AlgoArgon2(
            string type,
            long memoryCost,
            long timeCost,
            long threads
        ) {
            Type = type;
            MemoryCost = memoryCost;
            TimeCost = timeCost;
            Threads = threads;
        }

        public static AlgoArgon2 From(Dictionary<string, object> map) => new AlgoArgon2(
            type: map["type"].ToString(),
            memoryCost: Convert.ToInt64(map["memoryCost"]),
            timeCost: Convert.ToInt64(map["timeCost"]),
            threads: Convert.ToInt64(map["threads"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "type", Type },
            { "memoryCost", MemoryCost },
            { "timeCost", TimeCost },
            { "threads", Threads }
        };
    }
}
