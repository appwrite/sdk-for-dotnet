
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Oauth2Consent
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

        [JsonPropertyName("cimdUrl")]
        public string CimdUrl { get; private set; }

        [JsonPropertyName("scopes")]
        public List<string> Scopes { get; private set; }

        [JsonPropertyName("resources")]
        public List<string> Resources { get; private set; }

        [JsonPropertyName("authorizationDetails")]
        public string AuthorizationDetails { get; private set; }

        [JsonPropertyName("expire")]
        public string Expire { get; private set; }

        public Oauth2Consent(
            string id,
            string createdAt,
            string updatedAt,
            string userId,
            string appId,
            string cimdUrl,
            List<string> scopes,
            List<string> resources,
            string authorizationDetails,
            string expire
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            UserId = userId;
            AppId = appId;
            CimdUrl = cimdUrl;
            Scopes = scopes;
            Resources = resources;
            AuthorizationDetails = authorizationDetails;
            Expire = expire;
        }

        public static Oauth2Consent From(Dictionary<string, object> map) => new Oauth2Consent(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            userId: map["userId"].ToString(),
            appId: map["appId"].ToString(),
            cimdUrl: map["cimdUrl"].ToString(),
            scopes: map["scopes"].ConvertToList<string>(),
            resources: map["resources"].ConvertToList<string>(),
            authorizationDetails: map["authorizationDetails"].ToString(),
            expire: map["expire"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "userId", UserId },
            { "appId", AppId },
            { "cimdUrl", CimdUrl },
            { "scopes", Scopes },
            { "resources", Resources },
            { "authorizationDetails", AuthorizationDetails },
            { "expire", Expire }
        };
    }
}
