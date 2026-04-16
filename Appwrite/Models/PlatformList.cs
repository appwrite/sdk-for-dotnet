
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PlatformList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("platforms")]
        public List<object> Platforms { get; private set; }

        public PlatformList(
            long total,
            List<object> platforms
        ) {
            Total = total;
            Platforms = platforms;
        }

        public static PlatformList From(Dictionary<string, object> map) => new PlatformList(
            total: Convert.ToInt64(map["total"]),
            platforms: map["platforms"].ConvertToList<object>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "platforms", Platforms }
        };
    }
}
