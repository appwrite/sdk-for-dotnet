
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DatabaseStatusConnections
    {
        [JsonPropertyName("current")]
        public long Current { get; private set; }

        [JsonPropertyName("max")]
        public long Max { get; private set; }

        public DatabaseStatusConnections(
            long current,
            long max
        )
        {
            Current = current;
            Max = max;
        }

        public static DatabaseStatusConnections From(Dictionary<string, object> map) => new DatabaseStatusConnections(
            current: Convert.ToInt64(map["current"]),
            max: Convert.ToInt64(map["max"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "current", Current },
            { "max", Max }
        };
    }
}
