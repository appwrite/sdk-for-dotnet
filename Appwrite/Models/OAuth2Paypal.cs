
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Paypal
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("clientId")]
        public string ClientId { get; private set; }

        [JsonPropertyName("secretKey")]
        public string SecretKey { get; private set; }

        public OAuth2Paypal(
            string id,
            bool enabled,
            string clientId,
            string secretKey
        )
        {
            Id = id;
            Enabled = enabled;
            ClientId = clientId;
            SecretKey = secretKey;
        }

        public static OAuth2Paypal From(Dictionary<string, object> map) => new OAuth2Paypal(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            clientId: map["clientId"].ToString(),
            secretKey: map["secretKey"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "clientId", ClientId },
            { "secretKey", SecretKey }
        };
    }
}
