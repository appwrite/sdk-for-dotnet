
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PolicyPasswordRotation
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("maxAge")]
        public long MaxAge { get; private set; }

        public PolicyPasswordRotation(
            string id,
            bool enabled,
            long maxAge
        )
        {
            Id = id;
            Enabled = enabled;
            MaxAge = maxAge;
        }

        public static PolicyPasswordRotation From(Dictionary<string, object> map) => new PolicyPasswordRotation(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            maxAge: Convert.ToInt64(map["maxAge"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "maxAge", MaxAge }
        };
    }
}
