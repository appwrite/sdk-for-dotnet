
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Kakao
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
        public List<Appwrite.Enums.OAuth2KakaoPrompt> Prompt { get; private set; }

        public OAuth2Kakao(
            string id,
            bool enabled,
            string clientId,
            string clientSecret,
            List<Appwrite.Enums.OAuth2KakaoPrompt> prompt
        )
        {
            Id = id;
            Enabled = enabled;
            ClientId = clientId;
            ClientSecret = clientSecret;
            Prompt = prompt;
        }

        public static OAuth2Kakao From(Dictionary<string, object> map) => new OAuth2Kakao(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            enabled: (bool)(map.ContainsKey("enabled") ? map["enabled"] : false),
            clientId: (map.ContainsKey("clientId") ? map["clientId"] : "").ToString(),
            clientSecret: (map.ContainsKey("clientSecret") ? map["clientSecret"] : "").ToString(),
            prompt: (map.ContainsKey("prompt") ? map["prompt"] : new List<object>()).ConvertToList<Appwrite.Enums.OAuth2KakaoPrompt>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "clientId", ClientId },
            { "clientSecret", ClientSecret },
            { "prompt", Prompt.Select(it => it.Value).ToList() }
        };
    }
}
