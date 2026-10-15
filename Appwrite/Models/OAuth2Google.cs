
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Google
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
        public List<Appwrite.Enums.OAuth2GooglePrompt> Prompt { get; private set; }

        [JsonPropertyName("nativeEnabled")]
        public bool NativeEnabled { get; private set; }

        [JsonPropertyName("nativeClientIds")]
        public List<string> NativeClientIds { get; private set; }

        public OAuth2Google(
            string id,
            bool enabled,
            string clientId,
            string clientSecret,
            List<Appwrite.Enums.OAuth2GooglePrompt> prompt,
            bool nativeEnabled,
            List<string> nativeClientIds
        )
        {
            Id = id;
            Enabled = enabled;
            ClientId = clientId;
            ClientSecret = clientSecret;
            Prompt = prompt;
            NativeEnabled = nativeEnabled;
            NativeClientIds = nativeClientIds;
        }

        public static OAuth2Google From(Dictionary<string, object> map) => new OAuth2Google(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            enabled: (bool)(map.ContainsKey("enabled") ? map["enabled"] : false),
            clientId: (map.ContainsKey("clientId") ? map["clientId"] : "").ToString(),
            clientSecret: (map.ContainsKey("clientSecret") ? map["clientSecret"] : "").ToString(),
            prompt: (map.ContainsKey("prompt") ? map["prompt"] : new List<object> { "consent" }).ConvertToList<Appwrite.Enums.OAuth2GooglePrompt>(),
            nativeEnabled: (bool)(map.ContainsKey("nativeEnabled") ? map["nativeEnabled"] : false),
            nativeClientIds: (map.ContainsKey("nativeClientIds") ? map["nativeClientIds"] : new List<object>()).ConvertToList<string>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "clientId", ClientId },
            { "clientSecret", ClientSecret },
            { "prompt", Prompt.Select(it => it.Value).ToList() },
            { "nativeEnabled", NativeEnabled },
            { "nativeClientIds", NativeClientIds }
        };
    }
}
