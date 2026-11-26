
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class VideoCodecList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("codecs")]
        public List<VideoCodec> Codecs { get; private set; }

        public VideoCodecList(
            long total,
            List<VideoCodec> codecs
        )
        {
            Total = total;
            Codecs = codecs;
        }

        public static VideoCodecList From(Dictionary<string, object> map) => new VideoCodecList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            codecs: (map.ContainsKey("codecs") ? map["codecs"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.VideoCodec.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "codecs", Codecs?.Select(it => it.ToMap()).ToList() }
        };
    }
}
