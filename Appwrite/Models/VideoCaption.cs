
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class VideoCaption
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("videoId")]
        public string VideoId { get; private set; }

        [JsonPropertyName("bucketId")]
        public string BucketId { get; private set; }

        [JsonPropertyName("fileId")]
        public string FileId { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("language")]
        public string Language { get; private set; }

        [JsonPropertyName("default")]
        public bool Default { get; private set; }

        [JsonPropertyName("embedded")]
        public bool Embedded { get; private set; }

        [JsonPropertyName("targetDuration")]
        public double TargetDuration { get; private set; }

        [JsonPropertyName("status")]
        public Appwrite.Enums.VideoCaptionStatus Status { get; private set; }

        [JsonPropertyName("error")]
        public string Error { get; private set; }

        [JsonPropertyName("size")]
        public long Size { get; private set; }

        public VideoCaption(
            string id,
            string createdAt,
            string updatedAt,
            string videoId,
            string bucketId,
            string fileId,
            string name,
            string language,
            bool @default,
            bool embedded,
            double targetDuration,
            Appwrite.Enums.VideoCaptionStatus status,
            string error,
            long size
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            VideoId = videoId;
            BucketId = bucketId;
            FileId = fileId;
            Name = name;
            Language = language;
            Default = @default;
            Embedded = embedded;
            TargetDuration = targetDuration;
            Status = status;
            Error = error;
            Size = size;
        }

        public static VideoCaption From(Dictionary<string, object> map) => new VideoCaption(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            videoId: (map.ContainsKey("videoId") ? map["videoId"] : "").ToString(),
            bucketId: (map.ContainsKey("bucketId") ? map["bucketId"] : "").ToString(),
            fileId: (map.ContainsKey("fileId") ? map["fileId"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            language: (map.ContainsKey("language") ? map["language"] : "").ToString(),
            @default: (bool)(map.ContainsKey("default") ? map["default"] : false),
            embedded: (bool)(map.ContainsKey("embedded") ? map["embedded"] : false),
            targetDuration: Convert.ToDouble((map.ContainsKey("targetDuration") ? map["targetDuration"] : 0)),
            status: new Appwrite.Enums.VideoCaptionStatus((map.ContainsKey("status") ? map["status"] : "pending").ToString()!),
            error: (map.ContainsKey("error") ? map["error"] : "").ToString(),
            size: Convert.ToInt64((map.ContainsKey("size") ? map["size"] : 0))
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "videoId", VideoId },
            { "bucketId", BucketId },
            { "fileId", FileId },
            { "name", Name },
            { "language", Language },
            { "default", Default },
            { "embedded", Embedded },
            { "targetDuration", TargetDuration },
            { "status", Status.Value },
            { "error", Error },
            { "size", Size }
        };
    }
}
