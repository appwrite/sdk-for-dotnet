
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Notion
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("oauthClientId")]
        public string OauthClientId { get; private set; }

        [JsonPropertyName("oauthClientSecret")]
        public string OauthClientSecret { get; private set; }

        public OAuth2Notion(
            string id,
            bool enabled,
            string oauthClientId,
            string oauthClientSecret
        )
        {
            Id = id;
            Enabled = enabled;
            OauthClientId = oauthClientId;
            OauthClientSecret = oauthClientSecret;
        }

        public static OAuth2Notion From(Dictionary<string, object> map) => new OAuth2Notion(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            oauthClientId: map["oauthClientId"].ToString(),
            oauthClientSecret: map["oauthClientSecret"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "oauthClientId", OauthClientId },
            { "oauthClientSecret", OauthClientSecret }
        };
    }
}
