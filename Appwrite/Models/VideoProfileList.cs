
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class VideoProfileList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("profiles")]
        public List<VideoProfile> Profiles { get; private set; }

        public VideoProfileList(
            long total,
            List<VideoProfile> profiles
        )
        {
            Total = total;
            Profiles = profiles;
        }

        public static VideoProfileList From(Dictionary<string, object> map) => new VideoProfileList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            profiles: (map.ContainsKey("profiles") ? map["profiles"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.VideoProfile.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "profiles", Profiles?.Select(it => it.ToMap()).ToList() }
        };
    }
}
