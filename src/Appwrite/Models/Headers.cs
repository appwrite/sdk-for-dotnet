
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Headers
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("value")]
        public string Value { get; private set; }

        public Headers(
            string name,
            string xvalue
        ) {
            Name = name;
            Value = xvalue;
        }

        public static Headers From(Dictionary<string, object> map) => new Headers(
            name: map["name"].ToString(),
            xvalue: map["value"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "name", Name },
            { "value", Value }
        };
    }
}