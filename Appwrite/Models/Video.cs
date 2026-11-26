
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Video
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("$permissions")]
        public List<string> Permissions { get; private set; }

        [JsonPropertyName("bucketId")]
        public string BucketId { get; private set; }

        [JsonPropertyName("fileId")]
        public string FileId { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("size")]
        public long Size { get; private set; }

        [JsonPropertyName("format")]
        public string Format { get; private set; }

        [JsonPropertyName("duration")]
        public long Duration { get; private set; }

        [JsonPropertyName("width")]
        public long Width { get; private set; }

        [JsonPropertyName("height")]
        public long Height { get; private set; }

        [JsonPropertyName("aspectRatio")]
        public string AspectRatio { get; private set; }

        [JsonPropertyName("videoCodec")]
        public string VideoCodec { get; private set; }

        [JsonPropertyName("videoFormat")]
        public string VideoFormat { get; private set; }

        [JsonPropertyName("videoFormatProfile")]
        public string VideoFormatProfile { get; private set; }

        [JsonPropertyName("videoBitRate")]
        public long VideoBitRate { get; private set; }

        [JsonPropertyName("videoFrameRate")]
        public double VideoFrameRate { get; private set; }

        [JsonPropertyName("videoFrameRateMode")]
        public string VideoFrameRateMode { get; private set; }

        [JsonPropertyName("audioCodec")]
        public string AudioCodec { get; private set; }

        [JsonPropertyName("audioFormat")]
        public string AudioFormat { get; private set; }

        [JsonPropertyName("audioBitRate")]
        public long AudioBitRate { get; private set; }

        [JsonPropertyName("audioSampleRate")]
        public long AudioSampleRate { get; private set; }

        [JsonPropertyName("timelineStatus")]
        public Appwrite.Enums.VideoTimelineStatus TimelineStatus { get; private set; }

        [JsonPropertyName("timelineError")]
        public string TimelineError { get; private set; }

        public Video(
            string id,
            string createdAt,
            string updatedAt,
            List<string> permissions,
            string bucketId,
            string fileId,
            string name,
            long size,
            string format,
            long duration,
            long width,
            long height,
            string aspectRatio,
            string videoCodec,
            string videoFormat,
            string videoFormatProfile,
            long videoBitRate,
            double videoFrameRate,
            string videoFrameRateMode,
            string audioCodec,
            string audioFormat,
            long audioBitRate,
            long audioSampleRate,
            Appwrite.Enums.VideoTimelineStatus timelineStatus,
            string timelineError
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Permissions = permissions;
            BucketId = bucketId;
            FileId = fileId;
            Name = name;
            Size = size;
            Format = format;
            Duration = duration;
            Width = width;
            Height = height;
            AspectRatio = aspectRatio;
            VideoCodec = videoCodec;
            VideoFormat = videoFormat;
            VideoFormatProfile = videoFormatProfile;
            VideoBitRate = videoBitRate;
            VideoFrameRate = videoFrameRate;
            VideoFrameRateMode = videoFrameRateMode;
            AudioCodec = audioCodec;
            AudioFormat = audioFormat;
            AudioBitRate = audioBitRate;
            AudioSampleRate = audioSampleRate;
            TimelineStatus = timelineStatus;
            TimelineError = timelineError;
        }

        public static Video From(Dictionary<string, object> map) => new Video(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            permissions: (map.ContainsKey("$permissions") ? map["$permissions"] : new List<object>()).ConvertToList<string>(),
            bucketId: (map.ContainsKey("bucketId") ? map["bucketId"] : "").ToString(),
            fileId: (map.ContainsKey("fileId") ? map["fileId"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            size: Convert.ToInt64((map.ContainsKey("size") ? map["size"] : 0)),
            format: (map.ContainsKey("format") ? map["format"] : "").ToString(),
            duration: Convert.ToInt64((map.ContainsKey("duration") ? map["duration"] : 0)),
            width: Convert.ToInt64((map.ContainsKey("width") ? map["width"] : 0)),
            height: Convert.ToInt64((map.ContainsKey("height") ? map["height"] : 0)),
            aspectRatio: (map.ContainsKey("aspectRatio") ? map["aspectRatio"] : "").ToString(),
            videoCodec: (map.ContainsKey("videoCodec") ? map["videoCodec"] : "").ToString(),
            videoFormat: (map.ContainsKey("videoFormat") ? map["videoFormat"] : "").ToString(),
            videoFormatProfile: (map.ContainsKey("videoFormatProfile") ? map["videoFormatProfile"] : "").ToString(),
            videoBitRate: Convert.ToInt64((map.ContainsKey("videoBitRate") ? map["videoBitRate"] : 0)),
            videoFrameRate: Convert.ToDouble((map.ContainsKey("videoFrameRate") ? map["videoFrameRate"] : 0)),
            videoFrameRateMode: (map.ContainsKey("videoFrameRateMode") ? map["videoFrameRateMode"] : "").ToString(),
            audioCodec: (map.ContainsKey("audioCodec") ? map["audioCodec"] : "").ToString(),
            audioFormat: (map.ContainsKey("audioFormat") ? map["audioFormat"] : "").ToString(),
            audioBitRate: Convert.ToInt64((map.ContainsKey("audioBitRate") ? map["audioBitRate"] : 0)),
            audioSampleRate: Convert.ToInt64((map.ContainsKey("audioSampleRate") ? map["audioSampleRate"] : 0)),
            timelineStatus: new Appwrite.Enums.VideoTimelineStatus((map.ContainsKey("timelineStatus") ? map["timelineStatus"] : "pending").ToString()!),
            timelineError: (map.ContainsKey("timelineError") ? map["timelineError"] : "").ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "$permissions", Permissions },
            { "bucketId", BucketId },
            { "fileId", FileId },
            { "name", Name },
            { "size", Size },
            { "format", Format },
            { "duration", Duration },
            { "width", Width },
            { "height", Height },
            { "aspectRatio", AspectRatio },
            { "videoCodec", VideoCodec },
            { "videoFormat", VideoFormat },
            { "videoFormatProfile", VideoFormatProfile },
            { "videoBitRate", VideoBitRate },
            { "videoFrameRate", VideoFrameRate },
            { "videoFrameRateMode", VideoFrameRateMode },
            { "audioCodec", AudioCodec },
            { "audioFormat", AudioFormat },
            { "audioBitRate", AudioBitRate },
            { "audioSampleRate", AudioSampleRate },
            { "timelineStatus", TimelineStatus.Value },
            { "timelineError", TimelineError }
        };
    }
}
