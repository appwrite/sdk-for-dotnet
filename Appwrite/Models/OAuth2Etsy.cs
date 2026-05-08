
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Etsy
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("keyString")]
        public string KeyString { get; private set; }

        [JsonPropertyName("sharedSecret")]
        public string SharedSecret { get; private set; }

        public OAuth2Etsy(
            string id,
            bool enabled,
            string keyString,
            string sharedSecret
        )
        {
            Id = id;
            Enabled = enabled;
            KeyString = keyString;
            SharedSecret = sharedSecret;
        }

        public static OAuth2Etsy From(Dictionary<string, object> map) => new OAuth2Etsy(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            keyString: map["keyString"].ToString(),
            sharedSecret: map["sharedSecret"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "keyString", KeyString },
            { "sharedSecret", SharedSecret }
        };
    }
}
