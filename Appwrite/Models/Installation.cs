
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class Installation
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("provider")]
        public string Provider { get; private set; }

        [JsonPropertyName("organization")]
        public string Organization { get; private set; }

        [JsonPropertyName("providerInstallationId")]
        public string ProviderInstallationId { get; private set; }

        public Installation(
            string id,
            string createdAt,
            string updatedAt,
            string provider,
            string organization,
            string providerInstallationId
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Provider = provider;
            Organization = organization;
            ProviderInstallationId = providerInstallationId;
        }

        public static Installation From(Dictionary<string, object> map) => new Installation(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            provider: map["provider"].ToString(),
            organization: map["organization"].ToString(),
            providerInstallationId: map["providerInstallationId"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "provider", Provider },
            { "organization", Organization },
            { "providerInstallationId", ProviderInstallationId }
        };
    }
}
