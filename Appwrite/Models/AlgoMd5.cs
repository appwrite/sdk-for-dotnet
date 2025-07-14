
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class AlgoMd5
    {
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        public AlgoMd5(
            string type
        ) {
            Type = type;
        }

        public static AlgoMd5 From(Dictionary<string, object> map) => new AlgoMd5(
            type: map["type"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "type", Type }
        };
    }
}
