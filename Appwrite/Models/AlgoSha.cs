
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AlgoSha
    {
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        public AlgoSha(
            string type
        )
        {
            Type = type;
        }

        public static AlgoSha From(Dictionary<string, object> map) => new AlgoSha(
            type: (map.ContainsKey("type") ? map["type"] : "sha").ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "type", Type }
        };
    }
}
