
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AppInstallation
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("appId")]
        public string AppId { get; private set; }

        [JsonPropertyName("teamId")]
        public string TeamId { get; private set; }

        [JsonPropertyName("scopes")]
        public List<string> Scopes { get; private set; }

        [JsonPropertyName("authorizationDetails")]
        public object AuthorizationDetails { get; private set; }

        [JsonPropertyName("createdById")]
        public string CreatedById { get; private set; }

        [JsonPropertyName("createdByName")]
        public string CreatedByName { get; private set; }

        [JsonPropertyName("lastAccessedAt")]
        public string? LastAccessedAt { get; private set; }

        public AppInstallation(
            string id,
            string createdAt,
            string updatedAt,
            string appId,
            string teamId,
            List<string> scopes,
            object authorizationDetails,
            string createdById,
            string createdByName,
            string? lastAccessedAt
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            AppId = appId;
            TeamId = teamId;
            Scopes = scopes;
            AuthorizationDetails = authorizationDetails;
            CreatedById = createdById;
            CreatedByName = createdByName;
            LastAccessedAt = lastAccessedAt;
        }

        public static AppInstallation From(Dictionary<string, object> map) => new AppInstallation(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            appId: map["appId"].ToString(),
            teamId: map["teamId"].ToString(),
            scopes: map["scopes"].ConvertToList<string>(),
            authorizationDetails: map["authorizationDetails"].ToString(),
            createdById: map["createdById"].ToString(),
            createdByName: map["createdByName"].ToString(),
            lastAccessedAt: map.TryGetValue("lastAccessedAt", out var lastAccessedAt) ? lastAccessedAt?.ToString() : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "appId", AppId },
            { "teamId", TeamId },
            { "scopes", Scopes },
            { "authorizationDetails", AuthorizationDetails },
            { "createdById", CreatedById },
            { "createdByName", CreatedByName },
            { "lastAccessedAt", LastAccessedAt }
        };
    }
}
