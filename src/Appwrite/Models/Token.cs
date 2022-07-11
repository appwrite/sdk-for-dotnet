
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
        public string Id { get; set; }

        [JsonProperty("$createdAt")]
        public long CreatedAt { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("expire")]
        public long Expire { get; set; }


        public Token(
            string id,
            long createdAt,
            string userId,
            string secret,
            long expire
        ) {
            Id = id;
            CreatedAt = createdAt;
            UserId = userId;
            Secret = secret;
            Expire = expire;
        }

        public static Token From(Dictionary<string, object> map) => new Token(
            id: (string)map["$id"],
            createdAt: Convert.ToInt64(map["$createdAt"]),
            userId: (string)map["userId"],
            secret: (string)map["secret"],
            expire: Convert.ToInt64(map["expire"])
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