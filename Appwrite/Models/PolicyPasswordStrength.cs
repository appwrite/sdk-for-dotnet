
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PolicyPasswordStrength
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("min")]
        public long Min { get; private set; }

        [JsonPropertyName("uppercase")]
        public bool Uppercase { get; private set; }

        [JsonPropertyName("lowercase")]
        public bool Lowercase { get; private set; }

        [JsonPropertyName("number")]
        public bool Number { get; private set; }

        [JsonPropertyName("symbols")]
        public bool Symbols { get; private set; }

        public PolicyPasswordStrength(
            string id,
            long min,
            bool uppercase,
            bool lowercase,
            bool number,
            bool symbols
        )
        {
            Id = id;
            Min = min;
            Uppercase = uppercase;
            Lowercase = lowercase;
            Number = number;
            Symbols = symbols;
        }

        public static PolicyPasswordStrength From(Dictionary<string, object> map) => new PolicyPasswordStrength(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            min: Convert.ToInt64((map.ContainsKey("min") ? map["min"] : 8)),
            uppercase: (bool)(map.ContainsKey("uppercase") ? map["uppercase"] : false),
            lowercase: (bool)(map.ContainsKey("lowercase") ? map["lowercase"] : false),
            number: (bool)(map.ContainsKey("number") ? map["number"] : false),
            symbols: (bool)(map.ContainsKey("symbols") ? map["symbols"] : false)
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "min", Min },
            { "uppercase", Uppercase },
            { "lowercase", Lowercase },
            { "number", Number },
            { "symbols", Symbols }
        };
    }
}
