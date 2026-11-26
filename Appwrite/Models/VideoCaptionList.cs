
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class VideoCaptionList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("captions")]
        public List<VideoCaption> Captions { get; private set; }

        public VideoCaptionList(
            long total,
            List<VideoCaption> captions
        )
        {
            Total = total;
            Captions = captions;
        }

        public static VideoCaptionList From(Dictionary<string, object> map) => new VideoCaptionList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            captions: (map.ContainsKey("captions") ? map["captions"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.VideoCaption.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "captions", Captions?.Select(it => it.ToMap()).ToList() }
        };
    }
}
