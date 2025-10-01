
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class Headers
    {
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("value")]
        public string @Value { get; private set; }

        public Headers(
            string name,
            string xvalue
        ) {
            Name = name;
            @Value = xvalue;
        }

        public static Headers From(Dictionary<string, object> map) => new Headers(
            name: map["name"].ToString(),
            xvalue: map["value"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "name", Name },
            { "value", @Value }
        };
    }
}
