
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

        [JsonPropertyName("prompt")]
        public List<Appwrite.Enums.OAuth2OidcPrompt> Prompt { get; private set; }

        [JsonPropertyName("wellKnownURL")]
        public string WellKnownURL { get; private set; }

        [JsonPropertyName("authorizationURL")]
        public string AuthorizationURL { get; private set; }

        [JsonPropertyName("tokenURL")]
        public string TokenURL { get; private set; }

        [JsonPropertyName("userInfoURL")]
        public string UserInfoURL { get; private set; }

        [JsonPropertyName("maxAge")]
        public long? MaxAge { get; private set; }

        public OAuth2Oidc(
            string id,
            bool enabled,
            string clientId,
            string clientSecret,
            List<Appwrite.Enums.OAuth2OidcPrompt> prompt,
            string wellKnownURL,
            string authorizationURL,
            string tokenURL,
            string userInfoURL,
            long? maxAge
        )
        {
            Id = id;
            Enabled = enabled;
            ClientId = clientId;
            ClientSecret = clientSecret;
            Prompt = prompt;
            WellKnownURL = wellKnownURL;
            AuthorizationURL = authorizationURL;
            TokenURL = tokenURL;
            UserInfoURL = userInfoURL;
            MaxAge = maxAge;
        }

        public static OAuth2Oidc From(Dictionary<string, object> map) => new OAuth2Oidc(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            enabled: (bool)(map.ContainsKey("enabled") ? map["enabled"] : false),
            clientId: (map.ContainsKey("clientId") ? map["clientId"] : "").ToString(),
            clientSecret: (map.ContainsKey("clientSecret") ? map["clientSecret"] : "").ToString(),
            prompt: (map.ContainsKey("prompt") ? map["prompt"] : new List<object>()).ConvertToList<Appwrite.Enums.OAuth2OidcPrompt>(),
            wellKnownURL: (map.ContainsKey("wellKnownURL") ? map["wellKnownURL"] : "").ToString(),
            authorizationURL: (map.ContainsKey("authorizationURL") ? map["authorizationURL"] : "").ToString(),
            tokenURL: (map.ContainsKey("tokenURL") ? map["tokenURL"] : "").ToString(),
            userInfoURL: (map.ContainsKey("userInfoURL") ? map["userInfoURL"] : "").ToString(),
            maxAge: map.TryGetValue("maxAge", out var numberRaw10) && numberRaw10 != null
                                    ? Convert.ToInt64(numberRaw10)
                                    : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "clientId", ClientId },
            { "clientSecret", ClientSecret },
            { "prompt", Prompt.Select(it => it.Value).ToList() },
            { "wellKnownURL", WellKnownURL },
            { "authorizationURL", AuthorizationURL },
            { "tokenURL", TokenURL },
            { "userInfoURL", UserInfoURL },
            { "maxAge", MaxAge }
        };
    }
}
