
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class VideoRendition
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("videoId")]
        public string VideoId { get; private set; }

        [JsonPropertyName("profileId")]
        public string ProfileId { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("startedAt")]
        public string StartedAt { get; private set; }

        [JsonPropertyName("endedAt")]
        public string EndedAt { get; private set; }

        [JsonPropertyName("width")]
        public long Width { get; private set; }

        [JsonPropertyName("height")]
        public long Height { get; private set; }

        [JsonPropertyName("videoBitRate")]
        public long VideoBitRate { get; private set; }

        [JsonPropertyName("audioBitRate")]
        public long AudioBitRate { get; private set; }

        [JsonPropertyName("targetDuration")]
        public double TargetDuration { get; private set; }

        [JsonPropertyName("status")]
        public Appwrite.Enums.VideoRenditionStatus Status { get; private set; }

        [JsonPropertyName("error")]
        public string Error { get; private set; }

        [JsonPropertyName("progress")]
        public long Progress { get; private set; }

        [JsonPropertyName("output")]
        public Appwrite.Enums.VideoOutput Output { get; private set; }

        [JsonPropertyName("codec")]
        public Appwrite.Enums.VideoCodecId Codec { get; private set; }

        [JsonPropertyName("size")]
        public long Size { get; private set; }

        public VideoRendition(
            string id,
            string createdAt,
            string updatedAt,
            string videoId,
            string profileId,
            string name,
            string startedAt,
            string endedAt,
            long width,
            long height,
            long videoBitRate,
            long audioBitRate,
            double targetDuration,
            Appwrite.Enums.VideoRenditionStatus status,
            string error,
            long progress,
            Appwrite.Enums.VideoOutput output,
            Appwrite.Enums.VideoCodecId codec,
            long size
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            VideoId = videoId;
            ProfileId = profileId;
            Name = name;
            StartedAt = startedAt;
            EndedAt = endedAt;
            Width = width;
            Height = height;
            VideoBitRate = videoBitRate;
            AudioBitRate = audioBitRate;
            TargetDuration = targetDuration;
            Status = status;
            Error = error;
            Progress = progress;
            Output = output;
            Codec = codec;
            Size = size;
        }

        public static VideoRendition From(Dictionary<string, object> map) => new VideoRendition(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            videoId: (map.ContainsKey("videoId") ? map["videoId"] : "").ToString(),
            profileId: (map.ContainsKey("profileId") ? map["profileId"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            startedAt: (map.ContainsKey("startedAt") ? map["startedAt"] : "").ToString(),
            endedAt: (map.ContainsKey("endedAt") ? map["endedAt"] : "").ToString(),
            width: Convert.ToInt64((map.ContainsKey("width") ? map["width"] : 0)),
            height: Convert.ToInt64((map.ContainsKey("height") ? map["height"] : 0)),
            videoBitRate: Convert.ToInt64((map.ContainsKey("videoBitRate") ? map["videoBitRate"] : 0)),
            audioBitRate: Convert.ToInt64((map.ContainsKey("audioBitRate") ? map["audioBitRate"] : 0)),
            targetDuration: Convert.ToDouble((map.ContainsKey("targetDuration") ? map["targetDuration"] : 0)),
            status: new Appwrite.Enums.VideoRenditionStatus((map.ContainsKey("status") ? map["status"] : "pending").ToString()!),
            error: (map.ContainsKey("error") ? map["error"] : "").ToString(),
            progress: Convert.ToInt64((map.ContainsKey("progress") ? map["progress"] : 0)),
            output: new Appwrite.Enums.VideoOutput((map.ContainsKey("output") ? map["output"] : "hls").ToString()!),
            codec: new Appwrite.Enums.VideoCodecId((map.ContainsKey("codec") ? map["codec"] : "h264").ToString()!),
            size: Convert.ToInt64((map.ContainsKey("size") ? map["size"] : 0))
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "videoId", VideoId },
            { "profileId", ProfileId },
            { "name", Name },
            { "startedAt", StartedAt },
            { "endedAt", EndedAt },
            { "width", Width },
            { "height", Height },
            { "videoBitRate", VideoBitRate },
            { "audioBitRate", AudioBitRate },
            { "targetDuration", TargetDuration },
            { "status", Status.Value },
            { "error", Error },
            { "progress", Progress },
            { "output", Output.Value },
            { "codec", Codec.Value },
            { "size", Size }
        };
    }
}
