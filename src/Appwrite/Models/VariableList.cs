
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class VariableList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("variables")]
        public List<Variable> Variables { get; private set; }

        public VariableList(
            long total,
            List<Variable> variables
        ) {
            Total = total;
            Variables = variables;
        }

        public static VariableList From(Dictionary<string, object> map) => new VariableList(
            total: Convert.ToInt64(map["total"]),
            variables: ((JArray)map["variables"]).ToObject<List<Dictionary<string, object>>>().Select(it => Variable.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "variables", Variables.Select(it => it.ToMap()) }
        };
    }
}