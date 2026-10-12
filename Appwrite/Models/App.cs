
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class App
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("description")]
        public string Description { get; private set; }

        [JsonPropertyName("clientUri")]
        public string ClientUri { get; private set; }

        [JsonPropertyName("logoUri")]
        public string LogoUri { get; private set; }

        [JsonPropertyName("privacyPolicyUrl")]
        public string PrivacyPolicyUrl { get; private set; }

        [JsonPropertyName("termsUrl")]
        public string TermsUrl { get; private set; }

        [JsonPropertyName("contacts")]
        public List<string> Contacts { get; private set; }

        [JsonPropertyName("tagline")]
        public string Tagline { get; private set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; private set; }

        [JsonPropertyName("labels")]
        public List<string> Labels { get; private set; }

        [JsonPropertyName("images")]
        public List<string> Images { get; private set; }

        [JsonPropertyName("supportUrl")]
        public string SupportUrl { get; private set; }

        [JsonPropertyName("dataDeletionUrl")]
        public string DataDeletionUrl { get; private set; }

        [JsonPropertyName("redirectUris")]
        public List<string> RedirectUris { get; private set; }

        [JsonPropertyName("postLogoutRedirectUris")]
        public List<string> PostLogoutRedirectUris { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("deviceFlow")]
        public bool DeviceFlow { get; private set; }

        [JsonPropertyName("teamId")]
        public string TeamId { get; private set; }

        [JsonPropertyName("userId")]
        public string UserId { get; private set; }

        [JsonPropertyName("installationScopes")]
        public List<string> InstallationScopes { get; private set; }

        [JsonPropertyName("installationRedirectUrl")]
        public string InstallationRedirectUrl { get; private set; }

        [JsonPropertyName("secrets")]
        public List<AppSecret> Secrets { get; private set; }

        public App(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            string description,
            string clientUri,
            string logoUri,
            string privacyPolicyUrl,
            string termsUrl,
            List<string> contacts,
            string tagline,
            List<string> tags,
            List<string> labels,
            List<string> images,
            string supportUrl,
            string dataDeletionUrl,
            List<string> redirectUris,
            List<string> postLogoutRedirectUris,
            bool enabled,
            string type,
            bool deviceFlow,
            string teamId,
            string userId,
            List<string> installationScopes,
            string installationRedirectUrl,
            List<AppSecret> secrets
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Description = description;
            ClientUri = clientUri;
            LogoUri = logoUri;
            PrivacyPolicyUrl = privacyPolicyUrl;
            TermsUrl = termsUrl;
            Contacts = contacts;
            Tagline = tagline;
            Tags = tags;
            Labels = labels;
            Images = images;
            SupportUrl = supportUrl;
            DataDeletionUrl = dataDeletionUrl;
            RedirectUris = redirectUris;
            PostLogoutRedirectUris = postLogoutRedirectUris;
            Enabled = enabled;
            Type = type;
            DeviceFlow = deviceFlow;
            TeamId = teamId;
            UserId = userId;
            InstallationScopes = installationScopes;
            InstallationRedirectUrl = installationRedirectUrl;
            Secrets = secrets;
        }

        public static App From(Dictionary<string, object> map) => new App(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            description: (map.ContainsKey("description") ? map["description"] : "").ToString(),
            clientUri: (map.ContainsKey("clientUri") ? map["clientUri"] : "").ToString(),
            logoUri: (map.ContainsKey("logoUri") ? map["logoUri"] : "").ToString(),
            privacyPolicyUrl: (map.ContainsKey("privacyPolicyUrl") ? map["privacyPolicyUrl"] : "").ToString(),
            termsUrl: (map.ContainsKey("termsUrl") ? map["termsUrl"] : "").ToString(),
            contacts: (map.ContainsKey("contacts") ? map["contacts"] : new List<object>()).ConvertToList<string>(),
            tagline: (map.ContainsKey("tagline") ? map["tagline"] : "").ToString(),
            tags: (map.ContainsKey("tags") ? map["tags"] : new List<object>()).ConvertToList<string>(),
            labels: (map.ContainsKey("labels") ? map["labels"] : new List<object>()).ConvertToList<string>(),
            images: (map.ContainsKey("images") ? map["images"] : new List<object>()).ConvertToList<string>(),
            supportUrl: (map.ContainsKey("supportUrl") ? map["supportUrl"] : "").ToString(),
            dataDeletionUrl: (map.ContainsKey("dataDeletionUrl") ? map["dataDeletionUrl"] : "").ToString(),
            redirectUris: (map.ContainsKey("redirectUris") ? map["redirectUris"] : new List<object>()).ConvertToList<string>(),
            postLogoutRedirectUris: (map.ContainsKey("postLogoutRedirectUris") ? map["postLogoutRedirectUris"] : new List<object>()).ConvertToList<string>(),
            enabled: (bool)(map.ContainsKey("enabled") ? map["enabled"] : true),
            type: (map.ContainsKey("type") ? map["type"] : "confidential").ToString(),
            deviceFlow: (bool)(map.ContainsKey("deviceFlow") ? map["deviceFlow"] : false),
            teamId: (map.ContainsKey("teamId") ? map["teamId"] : "").ToString(),
            userId: (map.ContainsKey("userId") ? map["userId"] : "").ToString(),
            installationScopes: (map.ContainsKey("installationScopes") ? map["installationScopes"] : new List<object>()).ConvertToList<string>(),
            installationRedirectUrl: (map.ContainsKey("installationRedirectUrl") ? map["installationRedirectUrl"] : "").ToString(),
            secrets: map["secrets"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.AppSecret.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "description", Description },
            { "clientUri", ClientUri },
            { "logoUri", LogoUri },
            { "privacyPolicyUrl", PrivacyPolicyUrl },
            { "termsUrl", TermsUrl },
            { "contacts", Contacts },
            { "tagline", Tagline },
            { "tags", Tags },
            { "labels", Labels },
            { "images", Images },
            { "supportUrl", SupportUrl },
            { "dataDeletionUrl", DataDeletionUrl },
            { "redirectUris", RedirectUris },
            { "postLogoutRedirectUris", PostLogoutRedirectUris },
            { "enabled", Enabled },
            { "type", Type },
            { "deviceFlow", DeviceFlow },
            { "teamId", TeamId },
            { "userId", UserId },
            { "installationScopes", InstallationScopes },
            { "installationRedirectUrl", InstallationRedirectUrl },
            { "secrets", Secrets?.Select(it => it.ToMap()).ToList() }
        };
    }
}
