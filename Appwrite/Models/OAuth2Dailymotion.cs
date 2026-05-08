
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Dailymotion
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("apiKey")]
        public string ApiKey { get; private set; }

        [JsonPropertyName("apiSecret")]
        public string ApiSecret { get; private set; }

        public OAuth2Dailymotion(
            string id,
            bool enabled,
            string apiKey,
            string apiSecret
        )
        {
            Id = id;
            Enabled = enabled;
            ApiKey = apiKey;
            ApiSecret = apiSecret;
        }

        public static OAuth2Dailymotion From(Dictionary<string, object> map) => new OAuth2Dailymotion(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            apiKey: map["apiKey"].ToString(),
            apiSecret: map["apiSecret"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "apiKey", ApiKey },
            { "apiSecret", ApiSecret }
        };
    }
}
