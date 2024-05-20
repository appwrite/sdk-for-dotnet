
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class FunctionList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("functions")]
        public List<Function> Functions { get; private set; }

        public FunctionList(
            long total,
            List<Function> functions
        ) {
            Total = total;
            Functions = functions;
        }

        public static FunctionList From(Dictionary<string, object> map) => new FunctionList(
            total: Convert.ToInt64(map["total"]),
            functions: ((JArray)map["functions"]).ToObject<List<Dictionary<string, object>>>().Select(it => Function.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "functions", Functions.Select(it => it.ToMap()) }
        };
    }
}