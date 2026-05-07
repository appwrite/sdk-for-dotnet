
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Stripe
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("clientId")]
        public string ClientId { get; private set; }

        [JsonPropertyName("apiSecretKey")]
        public string ApiSecretKey { get; private set; }

        public OAuth2Stripe(
            string id,
            bool enabled,
            string clientId,
            string apiSecretKey
        )
        {
            Id = id;
            Enabled = enabled;
            ClientId = clientId;
            ApiSecretKey = apiSecretKey;
        }

        public static OAuth2Stripe From(Dictionary<string, object> map) => new OAuth2Stripe(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            clientId: map["clientId"].ToString(),
            apiSecretKey: map["apiSecretKey"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "clientId", ClientId },
            { "apiSecretKey", ApiSecretKey }
        };
    }
}
