
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class Identity
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("userId")]
        public string UserId { get; private set; }

        [JsonPropertyName("provider")]
        public string Provider { get; private set; }

        [JsonPropertyName("providerUid")]
        public string ProviderUid { get; private set; }

        [JsonPropertyName("providerEmail")]
        public string ProviderEmail { get; private set; }

        [JsonPropertyName("providerAccessToken")]
        public string ProviderAccessToken { get; private set; }

        [JsonPropertyName("providerAccessTokenExpiry")]
        public string ProviderAccessTokenExpiry { get; private set; }

        [JsonPropertyName("providerRefreshToken")]
        public string ProviderRefreshToken { get; private set; }

        public Identity(
            string id,
            string createdAt,
            string updatedAt,
            string userId,
            string provider,
            string providerUid,
            string providerEmail,
            string providerAccessToken,
            string providerAccessTokenExpiry,
            string providerRefreshToken
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            UserId = userId;
            Provider = provider;
            ProviderUid = providerUid;
            ProviderEmail = providerEmail;
            ProviderAccessToken = providerAccessToken;
            ProviderAccessTokenExpiry = providerAccessTokenExpiry;
            ProviderRefreshToken = providerRefreshToken;
        }

        public static Identity From(Dictionary<string, object> map) => new Identity(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            userId: map["userId"].ToString(),
            provider: map["provider"].ToString(),
            providerUid: map["providerUid"].ToString(),
            providerEmail: map["providerEmail"].ToString(),
            providerAccessToken: map["providerAccessToken"].ToString(),
            providerAccessTokenExpiry: map["providerAccessTokenExpiry"].ToString(),
            providerRefreshToken: map["providerRefreshToken"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "userId", UserId },
            { "provider", Provider },
            { "providerUid", ProviderUid },
            { "providerEmail", ProviderEmail },
            { "providerAccessToken", ProviderAccessToken },
            { "providerAccessTokenExpiry", ProviderAccessTokenExpiry },
            { "providerRefreshToken", ProviderRefreshToken }
        };
    }
}
