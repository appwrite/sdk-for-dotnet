
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Auth0
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
        public List<Appwrite.Enums.OAuth2Auth0Prompt>? Prompt { get; private set; }

        [JsonPropertyName("endpoint")]
        public string Endpoint { get; private set; }

        public OAuth2Auth0(
            string id,
            bool enabled,
            string clientId,
            string clientSecret,
            string endpoint,
            List<Appwrite.Enums.OAuth2Auth0Prompt>? prompt = null
        )
        {
            Id = id;
            Enabled = enabled;
            ClientId = clientId;
            ClientSecret = clientSecret;
            Prompt = prompt;
            Endpoint = endpoint;
        }

        public static OAuth2Auth0 From(Dictionary<string, object> map) => new OAuth2Auth0(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            clientId: map["clientId"].ToString(),
            clientSecret: map["clientSecret"].ToString(),
            endpoint: map["endpoint"].ToString(),
            prompt: map.TryGetValue("prompt", out var arrayRaw5Added) && arrayRaw5Added != null
                                ? arrayRaw5Added.ConvertToList<Appwrite.Enums.OAuth2Auth0Prompt>()
                                : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "clientId", ClientId },
            { "clientSecret", ClientSecret },
            { "prompt", Prompt?.Select(it => it.Value).ToList() },
            { "endpoint", Endpoint }
        };
    }
}
