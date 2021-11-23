
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class ExecutionList
    {
        [JsonProperty("sum")]
        public int Sum { get; set; }

        [JsonProperty("executions")]
        public List<Execution> Executions { get; set; }


        public ExecutionList(
            int sum,
            List<Execution> executions
        ) {
            Sum = sum;
            Executions = executions;
        }

        public static ExecutionList From(Dictionary<string, object> map) => new ExecutionList(
            sum: (int)map["sum"],
            executions: ((JArray)map["executions"]).ToObject<List<Execution>>()!
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "sum", Sum },
            { "executions", Executions.Select(it => it.ToMap()) }
        };
    }
}