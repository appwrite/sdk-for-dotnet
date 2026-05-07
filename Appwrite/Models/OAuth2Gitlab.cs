
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Gitlab
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("applicationId")]
        public string ApplicationId { get; private set; }

        [JsonPropertyName("secret")]
        public string Secret { get; private set; }

        [JsonPropertyName("endpoint")]
        public string Endpoint { get; private set; }

        public OAuth2Gitlab(
            string id,
            bool enabled,
            string applicationId,
            string secret,
            string endpoint
        )
        {
            Id = id;
            Enabled = enabled;
            ApplicationId = applicationId;
            Secret = secret;
            Endpoint = endpoint;
        }

        public static OAuth2Gitlab From(Dictionary<string, object> map) => new OAuth2Gitlab(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            applicationId: map["applicationId"].ToString(),
            secret: map["secret"].ToString(),
            endpoint: map["endpoint"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "applicationId", ApplicationId },
            { "secret", Secret },
            { "endpoint", Endpoint }
        };
    }
}
