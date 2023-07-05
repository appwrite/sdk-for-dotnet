
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class AlgoScrypt
    {
        [JsonProperty("type")]
        public string Type { get; private set; }

        [JsonProperty("costCpu")]
        public long CostCpu { get; private set; }

        [JsonProperty("costMemory")]
        public long CostMemory { get; private set; }

        [JsonProperty("costParallel")]
        public long CostParallel { get; private set; }

        [JsonProperty("length")]
        public long Length { get; private set; }

        public AlgoScrypt(
            string type,
            long costCpu,
            long costMemory,
            long costParallel,
            long length
        ) {
            Type = type;
            CostCpu = costCpu;
            CostMemory = costMemory;
            CostParallel = costParallel;
            Length = length;
        }

        public static AlgoScrypt From(Dictionary<string, object> map) => new AlgoScrypt(
            type: map["type"].ToString(),
            costCpu: Convert.ToInt64(map["costCpu"]),
            costMemory: Convert.ToInt64(map["costMemory"]),
            costParallel: Convert.ToInt64(map["costParallel"]),
            length: Convert.ToInt64(map["length"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "type", Type },
            { "costCpu", CostCpu },
            { "costMemory", CostMemory },
            { "costParallel", CostParallel },
            { "length", Length }
        };
    }
}