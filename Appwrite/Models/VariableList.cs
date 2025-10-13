
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class VariableList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("variables")]
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
            variables: map["variables"].ConvertToList<Dictionary<string, object>>().Select(it => Variable.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "variables", Variables.Select(it => it.ToMap()) }
        };
    }
}
