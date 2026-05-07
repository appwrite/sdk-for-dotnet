
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Oidc
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("clientId")]
        public string ClientId { get; private set; }

        [JsonPropertyName("clientSecret")]
        public string ClientSecret { get; private set; }

        [JsonPropertyName("wellKnownURL")]
        public string WellKnownURL { get; private set; }

        [JsonPropertyName("authorizationURL")]
        public string AuthorizationURL { get; private set; }

        [JsonPropertyName("tokenURL")]
        public string TokenURL { get; private set; }

        [JsonPropertyName("userInfoURL")]
        public string UserInfoURL { get; private set; }

        public OAuth2Oidc(
            string id,
            bool enabled,
            string clientId,
            string clientSecret,
            string wellKnownURL,
            string authorizationURL,
            string tokenURL,
            string userInfoURL
        )
        {
            Id = id;
            Enabled = enabled;
            ClientId = clientId;
            ClientSecret = clientSecret;
            WellKnownURL = wellKnownURL;
            AuthorizationURL = authorizationURL;
            TokenURL = tokenURL;
            UserInfoURL = userInfoURL;
        }

        public static OAuth2Oidc From(Dictionary<string, object> map) => new OAuth2Oidc(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            clientId: map["clientId"].ToString(),
            clientSecret: map["clientSecret"].ToString(),
            wellKnownURL: map["wellKnownURL"].ToString(),
            authorizationURL: map["authorizationURL"].ToString(),
            tokenURL: map["tokenURL"].ToString(),
            userInfoURL: map["userInfoURL"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "clientId", ClientId },
            { "clientSecret", ClientSecret },
            { "wellKnownURL", WellKnownURL },
            { "authorizationURL", AuthorizationURL },
            { "tokenURL", TokenURL },
            { "userInfoURL", UserInfoURL }
        };
    }
}
