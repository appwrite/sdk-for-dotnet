
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AlgoBcrypt
    {
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        public AlgoBcrypt(
            string type
        )
        {
            Type = type;
        }

        public static AlgoBcrypt From(Dictionary<string, object> map) => new AlgoBcrypt(
            type: (map.ContainsKey("type") ? map["type"] : "bcrypt").ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "type", Type }
        };
    }
}
