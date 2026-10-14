
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Oauth2Grant
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("userId")]
        public string UserId { get; private set; }

        [JsonPropertyName("appId")]
        public string AppId { get; private set; }

        [JsonPropertyName("scopes")]
        public List<string> Scopes { get; private set; }

        [JsonPropertyName("resources")]
        public List<string> Resources { get; private set; }

        [JsonPropertyName("authorizationDetails")]
        public string AuthorizationDetails { get; private set; }

        [JsonPropertyName("prompt")]
        public string Prompt { get; private set; }

        [JsonPropertyName("redirectUri")]
        public string RedirectUri { get; private set; }

        [JsonPropertyName("authTime")]
        public long AuthTime { get; private set; }

        [JsonPropertyName("expire")]
        public string Expire { get; private set; }

        public Oauth2Grant(
            string id,
            string createdAt,
            string updatedAt,
            string userId,
            string appId,
            List<string> scopes,
            List<string> resources,
            string authorizationDetails,
            string prompt,
            string redirectUri,
            long authTime,
            string expire
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            UserId = userId;
            AppId = appId;
            Scopes = scopes;
            Resources = resources;
            AuthorizationDetails = authorizationDetails;
            Prompt = prompt;
            RedirectUri = redirectUri;
            AuthTime = authTime;
            Expire = expire;
        }

        public static Oauth2Grant From(Dictionary<string, object> map) => new Oauth2Grant(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            userId: (map.ContainsKey("userId") ? map["userId"] : "").ToString(),
            appId: (map.ContainsKey("appId") ? map["appId"] : "").ToString(),
            scopes: (map.ContainsKey("scopes") ? map["scopes"] : new List<object>()).ConvertToList<string>(),
            resources: (map.ContainsKey("resources") ? map["resources"] : new List<object>()).ConvertToList<string>(),
            authorizationDetails: (map.ContainsKey("authorizationDetails") ? map["authorizationDetails"] : "[]").ToString(),
            prompt: (map.ContainsKey("prompt") ? map["prompt"] : "").ToString(),
            redirectUri: (map.ContainsKey("redirectUri") ? map["redirectUri"] : "").ToString(),
            authTime: Convert.ToInt64((map.ContainsKey("authTime") ? map["authTime"] : 0)),
            expire: (map.ContainsKey("expire") ? map["expire"] : "").ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "userId", UserId },
            { "appId", AppId },
            { "scopes", Scopes },
            { "resources", Resources },
            { "authorizationDetails", AuthorizationDetails },
            { "prompt", Prompt },
            { "redirectUri", RedirectUri },
            { "authTime", AuthTime },
            { "expire", Expire }
        };
    }
}
