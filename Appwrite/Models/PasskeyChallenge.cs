
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PasskeyChallenge
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("passkeyId")]
        public string PasskeyId { get; private set; }

        [JsonPropertyName("expire")]
        public string Expire { get; private set; }

        [JsonPropertyName("publicKey")]
        public object PublicKey { get; private set; }

        public PasskeyChallenge(
            string id,
            string createdAt,
            string passkeyId,
            string expire,
            object publicKey
        )
        {
            Id = id;
            CreatedAt = createdAt;
            PasskeyId = passkeyId;
            Expire = expire;
            PublicKey = publicKey;
        }

        public static PasskeyChallenge From(Dictionary<string, object> map) => new PasskeyChallenge(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            passkeyId: (map.ContainsKey("passkeyId") ? map["passkeyId"] : "").ToString(),
            expire: (map.ContainsKey("expire") ? map["expire"] : "").ToString(),
            publicKey: (map.ContainsKey("publicKey") ? map["publicKey"] : new Dictionary<string, object>())
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "passkeyId", PasskeyId },
            { "expire", Expire },
            { "publicKey", PublicKey }
        };
    }
}
