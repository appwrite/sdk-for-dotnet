
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
            id: map["$id"].ToString(),
            min: Convert.ToInt64(map["min"]),
            uppercase: (bool)map["uppercase"],
            lowercase: (bool)map["lowercase"],
            number: (bool)map["number"],
            symbols: (bool)map["symbols"]
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
