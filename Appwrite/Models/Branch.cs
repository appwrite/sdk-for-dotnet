
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class Branch
    {
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        public Branch(
            string name
        ) {
            Name = name;
        }

        public static Branch From(Dictionary<string, object> map) => new Branch(
            name: map["name"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "name", Name }
        };
    }
}
