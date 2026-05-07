
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Linkedin
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("clientId")]
        public string ClientId { get; private set; }

        [JsonPropertyName("primaryClientSecret")]
        public string PrimaryClientSecret { get; private set; }

        public OAuth2Linkedin(
            string id,
            bool enabled,
            string clientId,
            string primaryClientSecret
        )
        {
            Id = id;
            Enabled = enabled;
            ClientId = clientId;
            PrimaryClientSecret = primaryClientSecret;
        }

        public static OAuth2Linkedin From(Dictionary<string, object> map) => new OAuth2Linkedin(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            clientId: map["clientId"].ToString(),
            primaryClientSecret: map["primaryClientSecret"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "clientId", ClientId },
            { "primaryClientSecret", PrimaryClientSecret }
        };
    }
}
