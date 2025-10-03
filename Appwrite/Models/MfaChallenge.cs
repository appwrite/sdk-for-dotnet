using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class MfaChallenge
    {
        [JsonPropertyName("$id")]
        public string id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string createdAt { get; private set; }

        [JsonPropertyName("userId")]
        public string UserId { get; private set; }

        [JsonPropertyName("expire")]
        public string Expire { get; private set; }

        public MfaChallenge(
            string id,
            string createdAt,
            string userId,
            string expire
        ) {
            id = id;
            createdAt = createdAt;
            UserId = userId;
            Expire = expire;
        }

        public static MfaChallenge From(Dictionary<string, object> map) => new MfaChallenge(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            userId: map["userId"].ToString(),
            expire: map["expire"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", id },
            { "$createdAt", createdAt },
            { "userId", UserId },
            { "expire", Expire }
        };
    }
}
