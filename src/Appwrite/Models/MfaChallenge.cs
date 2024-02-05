
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class MfaChallenge
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("userId")]
        public string UserId { get; private set; }

        [JsonProperty("expire")]
        public string Expire { get; private set; }

        public MfaChallenge(
            string id,
            string createdAt,
            string userId,
            string expire
        ) {
            Id = id;
            CreatedAt = createdAt;
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
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "userId", UserId },
            { "expire", Expire }
        };
    }
}