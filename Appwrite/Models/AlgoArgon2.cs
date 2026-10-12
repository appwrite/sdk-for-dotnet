
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

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
        )
        {
            Type = type;
            MemoryCost = memoryCost;
            TimeCost = timeCost;
            Threads = threads;
        }

        public static AlgoArgon2 From(Dictionary<string, object> map) => new AlgoArgon2(
            type: (map.ContainsKey("type") ? map["type"] : "argon2").ToString(),
            memoryCost: Convert.ToInt64((map.ContainsKey("memoryCost") ? map["memoryCost"] : 0)),
            timeCost: Convert.ToInt64((map.ContainsKey("timeCost") ? map["timeCost"] : 0)),
            threads: Convert.ToInt64((map.ContainsKey("threads") ? map["threads"] : 0))
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
