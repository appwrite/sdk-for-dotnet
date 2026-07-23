
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Oauth2Token
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; private set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; private set; }

        [JsonPropertyName("expires_in")]
        public long ExpiresIn { get; private set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; private set; }

        [JsonPropertyName("scope")]
        public string Scope { get; private set; }

        [JsonPropertyName("authorization_details")]
        public string? AuthorizationDetails { get; private set; }

        [JsonPropertyName("id_token")]
        public string? IdToken { get; private set; }

        public Oauth2Token(
            string accessToken,
            string tokenType,
            long expiresIn,
            string refreshToken,
            string scope,
            string? authorizationDetails,
            string? idToken
        )
        {
            AccessToken = accessToken;
            TokenType = tokenType;
            ExpiresIn = expiresIn;
            RefreshToken = refreshToken;
            Scope = scope;
            AuthorizationDetails = authorizationDetails;
            IdToken = idToken;
        }

        public static Oauth2Token From(Dictionary<string, object> map) => new Oauth2Token(
            accessToken: map["access_token"].ToString(),
            tokenType: map["token_type"].ToString(),
            expiresIn: Convert.ToInt64(map["expires_in"]),
            refreshToken: map["refresh_token"].ToString(),
            scope: map["scope"].ToString(),
            authorizationDetails: map.TryGetValue("authorization_details", out var authorizationDetails) ? authorizationDetails?.ToString() : null,
            idToken: map.TryGetValue("id_token", out var idToken) ? idToken?.ToString() : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "access_token", AccessToken },
            { "token_type", TokenType },
            { "expires_in", ExpiresIn },
            { "refresh_token", RefreshToken },
            { "scope", Scope },
            { "authorization_details", AuthorizationDetails },
            { "id_token", IdToken }
        };
    }
}
