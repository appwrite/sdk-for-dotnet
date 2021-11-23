
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class FunctionList
    {
        [JsonProperty("sum")]
        public int Sum { get; set; }

        [JsonProperty("functions")]
        public List<Function> Functions { get; set; }


        public FunctionList(
            int sum,
            List<Function> functions
        ) {
            Sum = sum;
            Functions = functions;
        }

        public static FunctionList From(Dictionary<string, object> map) => new FunctionList(
            sum: (int)map["sum"],
            functions: ((JArray)map["functions"]).ToObject<List<Function>>()!
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "sum", Sum },
            { "functions", Functions.Select(it => it.ToMap()) }
        };
    }
}