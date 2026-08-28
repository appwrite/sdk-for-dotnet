
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabasePITRWindows
    {
        [JsonPropertyName("earliest")]
        public string Earliest { get; private set; }

        [JsonPropertyName("latest")]
        public string Latest { get; private set; }

        public DedicatedDatabasePITRWindows(
            string earliest,
            string latest
        )
        {
            Earliest = earliest;
            Latest = latest;
        }

        public static DedicatedDatabasePITRWindows From(Dictionary<string, object> map) => new DedicatedDatabasePITRWindows(
            earliest: map["earliest"].ToString(),
            latest: map["latest"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "earliest", Earliest },
            { "latest", Latest }
        };
    }
}
