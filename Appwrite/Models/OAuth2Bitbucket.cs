
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Bitbucket
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("secret")]
        public string Secret { get; private set; }

        public OAuth2Bitbucket(
            string id,
            bool enabled,
            string key,
            string secret
        )
        {
            Id = id;
            Enabled = enabled;
            Key = key;
            Secret = secret;
        }

        public static OAuth2Bitbucket From(Dictionary<string, object> map) => new OAuth2Bitbucket(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            key: map["key"].ToString(),
            secret: map["secret"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "key", Key },
            { "secret", Secret }
        };
    }
}
