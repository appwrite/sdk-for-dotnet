
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class ExecutionList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("executions")]
        public List<Execution> Executions { get; private set; }

        public ExecutionList(
            long total,
            List<Execution> executions
        ) {
            Total = total;
            Executions = executions;
        }

        public static ExecutionList From(Dictionary<string, object> map) => new ExecutionList(
            total: Convert.ToInt64(map["total"]),
            executions: ((JArray)map["executions"]).ToObject<List<Dictionary<string, object>>>().Select(it => Execution.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "executions", Executions.Select(it => it.ToMap()) }
        };
    }
}