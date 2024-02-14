
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Token
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("userId")]
        public string UserId { get; private set; }

        [JsonProperty("secret")]
        public string Secret { get; private set; }

        [JsonProperty("expire")]
        public string Expire { get; private set; }

        public Token(
            string id,
            string createdAt,
            string userId,
            string secret,
            string expire
        ) {
            Id = id;
            CreatedAt = createdAt;
            UserId = userId;
            Secret = secret;
            Expire = expire;
        }

        public static Token From(Dictionary<string, object> map) => new Token(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            userId: map["userId"].ToString(),
            secret: map["secret"].ToString(),
            expire: map["expire"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "userId", UserId },
            { "secret", Secret },
            { "expire", Expire }
        };
    }
}