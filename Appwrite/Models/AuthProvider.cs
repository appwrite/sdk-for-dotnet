
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class AuthProvider
    {
        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("appId")]
        public string AppId { get; private set; }

        [JsonPropertyName("secret")]
        public string Secret { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        public AuthProvider(
            string key,
            string name,
            string appId,
            string secret,
            bool enabled
        ) {
            Key = key;
            Name = name;
            AppId = appId;
            Secret = secret;
            Enabled = enabled;
        }

        public static AuthProvider From(Dictionary<string, object> map) => new AuthProvider(
            key: map["key"].ToString(),
            name: map["name"].ToString(),
            appId: map["appId"].ToString(),
            secret: map["secret"].ToString(),
            enabled: (bool)map["enabled"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "name", Name },
            { "appId", AppId },
            { "secret", Secret },
            { "enabled", Enabled }
        };
    }
}
