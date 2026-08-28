
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseExecutionColumn
    {
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        public DedicatedDatabaseExecutionColumn(
            string name,
            string type
        )
        {
            Name = name;
            Type = type;
        }

        public static DedicatedDatabaseExecutionColumn From(Dictionary<string, object> map) => new DedicatedDatabaseExecutionColumn(
            name: map["name"].ToString(),
            type: map["type"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "name", Name },
            { "type", Type }
        };
    }
}
