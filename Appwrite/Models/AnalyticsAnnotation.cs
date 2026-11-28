
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AnalyticsAnnotation
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("propertyId")]
        public string PropertyId { get; private set; }

        [JsonPropertyName("date")]
        public string Date { get; private set; }

        [JsonPropertyName("content")]
        public string Content { get; private set; }

        [JsonPropertyName("userId")]
        public string UserId { get; private set; }

        public AnalyticsAnnotation(
            string id,
            string createdAt,
            string updatedAt,
            string propertyId,
            string date,
            string content,
            string userId
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            PropertyId = propertyId;
            Date = date;
            Content = content;
            UserId = userId;
        }

        public static AnalyticsAnnotation From(Dictionary<string, object> map) => new AnalyticsAnnotation(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            propertyId: (map.ContainsKey("propertyId") ? map["propertyId"] : "").ToString(),
            date: (map.ContainsKey("date") ? map["date"] : "").ToString(),
            content: (map.ContainsKey("content") ? map["content"] : "").ToString(),
            userId: (map.ContainsKey("userId") ? map["userId"] : "").ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "propertyId", PropertyId },
            { "date", Date },
            { "content", Content },
            { "userId", UserId }
        };
    }
}
