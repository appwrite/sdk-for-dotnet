
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PolicyPasswordDictionary
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        public PolicyPasswordDictionary(
            string id,
            bool enabled
        )
        {
            Id = id;
            Enabled = enabled;
        }

        public static PolicyPasswordDictionary From(Dictionary<string, object> map) => new PolicyPasswordDictionary(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled }
        };
    }
}
