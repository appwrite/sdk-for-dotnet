
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class FunctionList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("functions")]
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
            functions: map["functions"].ConvertToList<Dictionary<string, object>>().Select(it => Function.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "functions", Functions.Select(it => it.ToMap()) }
        };
    }
}
