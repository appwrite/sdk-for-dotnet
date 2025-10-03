
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class Token
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("userId")]
        public string UserId { get; private set; }

        [JsonPropertyName("secret")]
        public string Secret { get; private set; }

        [JsonPropertyName("expire")]
        public string Expire { get; private set; }

        [JsonPropertyName("phrase")]
        public string Phrase { get; private set; }

        public Token(
            string id,
            string createdAt,
            string userId,
            string secret,
            string expire,
            string phrase
        ) {
            Id = id;
            CreatedAt = createdAt;
            UserId = userId;
            Secret = secret;
            Expire = expire;
            Phrase = phrase;
        }

        public static Token From(Dictionary<string, object> map) => new Token(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            userId: map["userId"].ToString(),
            secret: map["secret"].ToString(),
            expire: map["expire"].ToString(),
            phrase: map["phrase"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "userId", UserId },
            { "secret", Secret },
            { "expire", Expire },
            { "phrase", Phrase }
        };
    }
}
