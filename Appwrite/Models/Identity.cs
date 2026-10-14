
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

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

        [JsonPropertyName("providerIdToken")]
        public string ProviderIdToken { get; private set; }

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
            string providerRefreshToken,
            string providerIdToken
        )
        {
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
            ProviderIdToken = providerIdToken;
        }

        public static Identity From(Dictionary<string, object> map) => new Identity(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            userId: (map.ContainsKey("userId") ? map["userId"] : "").ToString(),
            provider: (map.ContainsKey("provider") ? map["provider"] : "").ToString(),
            providerUid: (map.ContainsKey("providerUid") ? map["providerUid"] : "").ToString(),
            providerEmail: (map.ContainsKey("providerEmail") ? map["providerEmail"] : "").ToString(),
            providerAccessToken: (map.ContainsKey("providerAccessToken") ? map["providerAccessToken"] : "").ToString(),
            providerAccessTokenExpiry: (map.ContainsKey("providerAccessTokenExpiry") ? map["providerAccessTokenExpiry"] : "").ToString(),
            providerRefreshToken: (map.ContainsKey("providerRefreshToken") ? map["providerRefreshToken"] : "").ToString(),
            providerIdToken: (map.ContainsKey("providerIdToken") ? map["providerIdToken"] : "").ToString()
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
            { "providerRefreshToken", ProviderRefreshToken },
            { "providerIdToken", ProviderIdToken }
        };
    }
}
