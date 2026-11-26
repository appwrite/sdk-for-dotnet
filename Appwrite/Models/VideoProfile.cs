
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class VideoProfile
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("codec")]
        public Appwrite.Enums.VideoCodecId Codec { get; private set; }

        [JsonPropertyName("videoBitRate")]
        public long VideoBitRate { get; private set; }

        [JsonPropertyName("audioBitRate")]
        public long AudioBitRate { get; private set; }

        [JsonPropertyName("width")]
        public long Width { get; private set; }

        [JsonPropertyName("height")]
        public long Height { get; private set; }

        public VideoProfile(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            Appwrite.Enums.VideoCodecId codec,
            long videoBitRate,
            long audioBitRate,
            long width,
            long height
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Codec = codec;
            VideoBitRate = videoBitRate;
            AudioBitRate = audioBitRate;
            Width = width;
            Height = height;
        }

        public static VideoProfile From(Dictionary<string, object> map) => new VideoProfile(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            codec: new Appwrite.Enums.VideoCodecId((map.ContainsKey("codec") ? map["codec"] : "h264").ToString()!),
            videoBitRate: Convert.ToInt64((map.ContainsKey("videoBitRate") ? map["videoBitRate"] : 0)),
            audioBitRate: Convert.ToInt64((map.ContainsKey("audioBitRate") ? map["audioBitRate"] : 0)),
            width: Convert.ToInt64((map.ContainsKey("width") ? map["width"] : 0)),
            height: Convert.ToInt64((map.ContainsKey("height") ? map["height"] : 0))
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "codec", Codec.Value },
            { "videoBitRate", VideoBitRate },
            { "audioBitRate", AudioBitRate },
            { "width", Width },
            { "height", Height }
        };
    }
}
