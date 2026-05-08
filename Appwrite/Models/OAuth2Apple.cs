
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Apple
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("serviceId")]
        public string ServiceId { get; private set; }

        [JsonPropertyName("keyId")]
        public string KeyId { get; private set; }

        [JsonPropertyName("teamId")]
        public string TeamId { get; private set; }

        [JsonPropertyName("p8File")]
        public string P8File { get; private set; }

        public OAuth2Apple(
            string id,
            bool enabled,
            string serviceId,
            string keyId,
            string teamId,
            string p8File
        )
        {
            Id = id;
            Enabled = enabled;
            ServiceId = serviceId;
            KeyId = keyId;
            TeamId = teamId;
            P8File = p8File;
        }

        public static OAuth2Apple From(Dictionary<string, object> map) => new OAuth2Apple(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            serviceId: map["serviceId"].ToString(),
            keyId: map["keyId"].ToString(),
            teamId: map["teamId"].ToString(),
            p8File: map["p8File"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "serviceId", ServiceId },
            { "keyId", KeyId },
            { "teamId", TeamId },
            { "p8File", P8File }
        };
    }
}
