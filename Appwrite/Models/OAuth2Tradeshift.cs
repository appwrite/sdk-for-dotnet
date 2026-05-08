
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Tradeshift
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("oauth2ClientId")]
        public string Oauth2ClientId { get; private set; }

        [JsonPropertyName("oauth2ClientSecret")]
        public string Oauth2ClientSecret { get; private set; }

        public OAuth2Tradeshift(
            string id,
            bool enabled,
            string oauth2ClientId,
            string oauth2ClientSecret
        )
        {
            Id = id;
            Enabled = enabled;
            Oauth2ClientId = oauth2ClientId;
            Oauth2ClientSecret = oauth2ClientSecret;
        }

        public static OAuth2Tradeshift From(Dictionary<string, object> map) => new OAuth2Tradeshift(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            oauth2ClientId: map["oauth2ClientId"].ToString(),
            oauth2ClientSecret: map["oauth2ClientSecret"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "oauth2ClientId", Oauth2ClientId },
            { "oauth2ClientSecret", Oauth2ClientSecret }
        };
    }
}
