
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

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("expire")]
        public int Expire { get; set; }


        public Token(
            string id,
            string userId,
            string secret,
            int expire
        ) {
            Id = id;
            UserId = userId;
            Secret = secret;
            Expire = expire;
        }

        public static Token From(Dictionary<string, object> map) => new Token(
            id: (string)map["$id"],
            userId: (string)map["userId"],
            secret: (string)map["secret"],
            expire: (int)map["expire"]
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "$id", Id },
            { "userId", UserId },
            { "secret", Secret },
            { "expire", Expire }
        };
    }
}