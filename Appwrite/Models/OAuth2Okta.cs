
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Okta
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("clientId")]
        public string ClientId { get; private set; }

        [JsonPropertyName("clientSecret")]
        public string ClientSecret { get; private set; }

        [JsonPropertyName("domain")]
        public string Domain { get; private set; }

        [JsonPropertyName("authorizationServerId")]
        public string AuthorizationServerId { get; private set; }

        public OAuth2Okta(
            string id,
            bool enabled,
            string clientId,
            string clientSecret,
            string domain,
            string authorizationServerId
        )
        {
            Id = id;
            Enabled = enabled;
            ClientId = clientId;
            ClientSecret = clientSecret;
            Domain = domain;
            AuthorizationServerId = authorizationServerId;
        }

        public static OAuth2Okta From(Dictionary<string, object> map) => new OAuth2Okta(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            clientId: map["clientId"].ToString(),
            clientSecret: map["clientSecret"].ToString(),
            domain: map["domain"].ToString(),
            authorizationServerId: map["authorizationServerId"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "clientId", ClientId },
            { "clientSecret", ClientSecret },
            { "domain", Domain },
            { "authorizationServerId", AuthorizationServerId }
        };
    }
}
