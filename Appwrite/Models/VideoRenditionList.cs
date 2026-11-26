
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class VideoRenditionList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("renditions")]
        public List<VideoRendition> Renditions { get; private set; }

        public VideoRenditionList(
            long total,
            List<VideoRendition> renditions
        )
        {
            Total = total;
            Renditions = renditions;
        }

        public static VideoRenditionList From(Dictionary<string, object> map) => new VideoRenditionList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            renditions: (map.ContainsKey("renditions") ? map["renditions"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.VideoRendition.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "renditions", Renditions?.Select(it => it.ToMap()).ToList() }
        };
    }
}
