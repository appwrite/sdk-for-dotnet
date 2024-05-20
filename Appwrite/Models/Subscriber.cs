
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Subscriber
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("targetId")]
        public string TargetId { get; private set; }

        [JsonProperty("target")]
        public Target Target { get; private set; }

        [JsonProperty("userId")]
        public string UserId { get; private set; }

        [JsonProperty("userName")]
        public string UserName { get; private set; }

        [JsonProperty("topicId")]
        public string TopicId { get; private set; }

        [JsonProperty("providerType")]
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
            target: Target.From(map: ((JObject)map["target"]).ToObject<Dictionary<string, object>>()!),
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