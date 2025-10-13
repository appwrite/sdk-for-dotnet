
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class ExecutionList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("executions")]
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
            executions: map["executions"].ConvertToList<Dictionary<string, object>>().Select(it => Execution.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "executions", Executions.Select(it => it.ToMap()) }
        };
    }
}
