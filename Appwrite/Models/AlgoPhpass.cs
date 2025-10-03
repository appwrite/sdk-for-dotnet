
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class AlgoPhpass
    {
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        public AlgoPhpass(
            string type
        ) {
            Type = type;
        }

        public static AlgoPhpass From(Dictionary<string, object> map) => new AlgoPhpass(
            type: map["type"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "type", Type }
        };
    }
}
