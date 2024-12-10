
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class AlgoSha
    {
        [JsonProperty("type")]
        public string Type { get; private set; }

        public AlgoSha(
            string type
        ) {
            Type = type;
        }

        public static AlgoSha From(Dictionary<string, object> map) => new AlgoSha(
            type: map["type"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "type", Type }
        };
    }
}