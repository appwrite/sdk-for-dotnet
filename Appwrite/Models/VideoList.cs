
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class VideoList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("videos")]
        public List<Video> Videos { get; private set; }

        public VideoList(
            long total,
            List<Video> videos
        )
        {
            Total = total;
            Videos = videos;
        }

        public static VideoList From(Dictionary<string, object> map) => new VideoList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            videos: (map.ContainsKey("videos") ? map["videos"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Video.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "videos", Videos?.Select(it => it.ToMap()).ToList() }
        };
    }
}
