
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DatabaseStatusVolume
    {
        [JsonPropertyName("path")]
        public string Path { get; private set; }

        [JsonPropertyName("usedPercent")]
        public string UsedPercent { get; private set; }

        [JsonPropertyName("available")]
        public string Available { get; private set; }

        [JsonPropertyName("mounted")]
        public bool Mounted { get; private set; }

        public DatabaseStatusVolume(
            string @path,
            string usedPercent,
            string available,
            bool mounted
        )
        {
            Path = @path;
            UsedPercent = usedPercent;
            Available = available;
            Mounted = mounted;
        }

        public static DatabaseStatusVolume From(Dictionary<string, object> map) => new DatabaseStatusVolume(
            @path: map["path"].ToString(),
            usedPercent: map["usedPercent"].ToString(),
            available: map["available"].ToString(),
            mounted: (bool)map["mounted"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "path", Path },
            { "usedPercent", UsedPercent },
            { "available", Available },
            { "mounted", Mounted }
        };
    }
}
