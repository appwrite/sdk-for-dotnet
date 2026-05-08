
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2X
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("customerKey")]
        public string CustomerKey { get; private set; }

        [JsonPropertyName("secretKey")]
        public string SecretKey { get; private set; }

        public OAuth2X(
            string id,
            bool enabled,
            string customerKey,
            string secretKey
        )
        {
            Id = id;
            Enabled = enabled;
            CustomerKey = customerKey;
            SecretKey = secretKey;
        }

        public static OAuth2X From(Dictionary<string, object> map) => new OAuth2X(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            customerKey: map["customerKey"].ToString(),
            secretKey: map["secretKey"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "customerKey", CustomerKey },
            { "secretKey", SecretKey }
        };
    }
}
