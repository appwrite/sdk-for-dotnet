
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Subscriber
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("targetId")]
        public string TargetId { get; private set; }

        [JsonPropertyName("target")]
        public Target Target { get; private set; }

        [JsonPropertyName("userId")]
        public string UserId { get; private set; }

        [JsonPropertyName("userName")]
        public string UserName { get; private set; }

        [JsonPropertyName("topicId")]
        public string TopicId { get; private set; }

        [JsonPropertyName("providerType")]
        public string ProviderType { get; private set; }

        public Subscriber(
            string id,
            string createdAt,
            string updatedAt,
            string targetId,
            Target target,
            string userId,
            string userName,
            string topicId,
            string providerType
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            TargetId = targetId;
            Target = target;
            UserId = userId;
            UserName = userName;
            TopicId = topicId;
            ProviderType = providerType;
        }

        public static Subscriber From(Dictionary<string, object> map) => new Subscriber(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            targetId: map["targetId"].ToString(),
            target: Target.From(map: map["target"] is JsonElement jsonObj5 ? jsonObj5.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["target"]),
            userId: map["userId"].ToString(),
            userName: map["userName"].ToString(),
            topicId: map["topicId"].ToString(),
            providerType: map["providerType"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "targetId", TargetId },
            { "target", Target.ToMap() },
            { "userId", UserId },
            { "userName", UserName },
            { "topicId", TopicId },
            { "providerType", ProviderType }
        };
    }
}
