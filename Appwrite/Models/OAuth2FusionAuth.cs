
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2FusionAuth
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("clientId")]
        public string ClientId { get; private set; }

        [JsonPropertyName("clientSecret")]
        public string ClientSecret { get; private set; }

        [JsonPropertyName("endpoint")]
        public string Endpoint { get; private set; }

        public OAuth2FusionAuth(
            string id,
            bool enabled,
            string clientId,
            string clientSecret,
            string endpoint
        )
        {
            Id = id;
            Enabled = enabled;
            ClientId = clientId;
            ClientSecret = clientSecret;
            Endpoint = endpoint;
        }

        public static OAuth2FusionAuth From(Dictionary<string, object> map) => new OAuth2FusionAuth(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            clientId: map["clientId"].ToString(),
            clientSecret: map["clientSecret"].ToString(),
            endpoint: map["endpoint"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "clientId", ClientId },
            { "clientSecret", ClientSecret },
            { "endpoint", Endpoint }
        };
    }
}
