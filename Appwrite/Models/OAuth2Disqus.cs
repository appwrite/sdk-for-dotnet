
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Disqus
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("publicKey")]
        public string PublicKey { get; private set; }

        [JsonPropertyName("secretKey")]
        public string SecretKey { get; private set; }

        public OAuth2Disqus(
            string id,
            bool enabled,
            string publicKey,
            string secretKey
        )
        {
            Id = id;
            Enabled = enabled;
            PublicKey = publicKey;
            SecretKey = secretKey;
        }

        public static OAuth2Disqus From(Dictionary<string, object> map) => new OAuth2Disqus(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            publicKey: map["publicKey"].ToString(),
            secretKey: map["secretKey"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "publicKey", PublicKey },
            { "secretKey", SecretKey }
        };
    }
}
