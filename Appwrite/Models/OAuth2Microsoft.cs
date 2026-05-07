
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Microsoft
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("applicationId")]
        public string ApplicationId { get; private set; }

        [JsonPropertyName("applicationSecret")]
        public string ApplicationSecret { get; private set; }

        [JsonPropertyName("tenant")]
        public string Tenant { get; private set; }

        public OAuth2Microsoft(
            string id,
            bool enabled,
            string applicationId,
            string applicationSecret,
            string tenant
        )
        {
            Id = id;
            Enabled = enabled;
            ApplicationId = applicationId;
            ApplicationSecret = applicationSecret;
            Tenant = tenant;
        }

        public static OAuth2Microsoft From(Dictionary<string, object> map) => new OAuth2Microsoft(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            applicationId: map["applicationId"].ToString(),
            applicationSecret: map["applicationSecret"].ToString(),
            tenant: map["tenant"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "applicationId", ApplicationId },
            { "applicationSecret", ApplicationSecret },
            { "tenant", Tenant }
        };
    }
}
