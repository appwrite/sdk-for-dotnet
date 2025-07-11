
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class PlatformList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("platforms")]
        public List<Platform> Platforms { get; private set; }

        public PlatformList(
            long total,
            List<Platform> platforms
        ) {
            Total = total;
            Platforms = platforms;
        }

        public static PlatformList From(Dictionary<string, object> map) => new PlatformList(
            total: Convert.ToInt64(map["total"]),
            platforms: map["platforms"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Platform.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["platforms"]).Select(it => Platform.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "platforms", Platforms.Select(it => it.ToMap()) }
        };
    }
}
