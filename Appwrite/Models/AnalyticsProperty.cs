
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AnalyticsProperty
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("domain")]
        public string Domain { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("allowedOrigins")]
        public List<string> AllowedOrigins { get; private set; }

        [JsonPropertyName("type")]
        public Appwrite.Enums.AnalyticsPropertyType Type { get; private set; }

        [JsonPropertyName("identifyUsers")]
        public bool IdentifyUsers { get; private set; }

        [JsonPropertyName("accessedAt")]
        public string AccessedAt { get; private set; }

        [JsonPropertyName("firstAccessedAt")]
        public string FirstAccessedAt { get; private set; }

        public AnalyticsProperty(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            string domain,
            bool enabled,
            List<string> allowedOrigins,
            Appwrite.Enums.AnalyticsPropertyType type,
            bool identifyUsers,
            string accessedAt,
            string firstAccessedAt
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Domain = domain;
            Enabled = enabled;
            AllowedOrigins = allowedOrigins;
            Type = type;
            IdentifyUsers = identifyUsers;
            AccessedAt = accessedAt;
            FirstAccessedAt = firstAccessedAt;
        }

        public static AnalyticsProperty From(Dictionary<string, object> map) => new AnalyticsProperty(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            domain: (map.ContainsKey("domain") ? map["domain"] : "").ToString(),
            enabled: (bool)(map.ContainsKey("enabled") ? map["enabled"] : true),
            allowedOrigins: (map.ContainsKey("allowedOrigins") ? map["allowedOrigins"] : new List<object> { "*" }).ConvertToList<string>(),
            type: new Appwrite.Enums.AnalyticsPropertyType((map.ContainsKey("type") ? map["type"] : "web").ToString()!),
            identifyUsers: (bool)(map.ContainsKey("identifyUsers") ? map["identifyUsers"] : false),
            accessedAt: (map.ContainsKey("accessedAt") ? map["accessedAt"] : "").ToString(),
            firstAccessedAt: (map.ContainsKey("firstAccessedAt") ? map["firstAccessedAt"] : "").ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "domain", Domain },
            { "enabled", Enabled },
            { "allowedOrigins", AllowedOrigins },
            { "type", Type.Value },
            { "identifyUsers", IdentifyUsers },
            { "accessedAt", AccessedAt },
            { "firstAccessedAt", FirstAccessedAt }
        };
    }
}
