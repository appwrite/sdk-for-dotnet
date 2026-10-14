
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Deployment
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("resourceId")]
        public string ResourceId { get; private set; }

        [JsonPropertyName("resourceType")]
        public string ResourceType { get; private set; }

        [JsonPropertyName("entrypoint")]
        public string Entrypoint { get; private set; }

        [JsonPropertyName("sourceSize")]
        public long SourceSize { get; private set; }

        [JsonPropertyName("buildSize")]
        public long BuildSize { get; private set; }

        [JsonPropertyName("totalSize")]
        public long TotalSize { get; private set; }

        [JsonPropertyName("buildId")]
        public string BuildId { get; private set; }

        [JsonPropertyName("activate")]
        public bool Activate { get; private set; }

        [JsonPropertyName("screenshotLight")]
        public string ScreenshotLight { get; private set; }

        [JsonPropertyName("screenshotDark")]
        public string ScreenshotDark { get; private set; }

        [JsonPropertyName("status")]
        public Appwrite.Enums.DeploymentStatus Status { get; private set; }

        [JsonPropertyName("buildLogs")]
        public string BuildLogs { get; private set; }

        [JsonPropertyName("buildDuration")]
        public long BuildDuration { get; private set; }

        [JsonPropertyName("providerRepositoryName")]
        public string ProviderRepositoryName { get; private set; }

        [JsonPropertyName("providerRepositoryOwner")]
        public string ProviderRepositoryOwner { get; private set; }

        [JsonPropertyName("providerRepositoryUrl")]
        public string ProviderRepositoryUrl { get; private set; }

        [JsonPropertyName("providerCommitHash")]
        public string ProviderCommitHash { get; private set; }

        [JsonPropertyName("providerCommitAuthorUrl")]
        public string ProviderCommitAuthorUrl { get; private set; }

        [JsonPropertyName("providerCommitAuthor")]
        public string ProviderCommitAuthor { get; private set; }

        [JsonPropertyName("providerCommitMessage")]
        public string ProviderCommitMessage { get; private set; }

        [JsonPropertyName("providerCommitUrl")]
        public string ProviderCommitUrl { get; private set; }

        [JsonPropertyName("providerBranch")]
        public string ProviderBranch { get; private set; }

        [JsonPropertyName("providerBranchUrl")]
        public string ProviderBranchUrl { get; private set; }

        public Deployment(
            string id,
            string createdAt,
            string updatedAt,
            string type,
            string resourceId,
            string resourceType,
            string entrypoint,
            long sourceSize,
            long buildSize,
            long totalSize,
            string buildId,
            bool activate,
            string screenshotLight,
            string screenshotDark,
            Appwrite.Enums.DeploymentStatus status,
            string buildLogs,
            long buildDuration,
            string providerRepositoryName,
            string providerRepositoryOwner,
            string providerRepositoryUrl,
            string providerCommitHash,
            string providerCommitAuthorUrl,
            string providerCommitAuthor,
            string providerCommitMessage,
            string providerCommitUrl,
            string providerBranch,
            string providerBranchUrl
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Type = type;
            ResourceId = resourceId;
            ResourceType = resourceType;
            Entrypoint = entrypoint;
            SourceSize = sourceSize;
            BuildSize = buildSize;
            TotalSize = totalSize;
            BuildId = buildId;
            Activate = activate;
            ScreenshotLight = screenshotLight;
            ScreenshotDark = screenshotDark;
            Status = status;
            BuildLogs = buildLogs;
            BuildDuration = buildDuration;
            ProviderRepositoryName = providerRepositoryName;
            ProviderRepositoryOwner = providerRepositoryOwner;
            ProviderRepositoryUrl = providerRepositoryUrl;
            ProviderCommitHash = providerCommitHash;
            ProviderCommitAuthorUrl = providerCommitAuthorUrl;
            ProviderCommitAuthor = providerCommitAuthor;
            ProviderCommitMessage = providerCommitMessage;
            ProviderCommitUrl = providerCommitUrl;
            ProviderBranch = providerBranch;
            ProviderBranchUrl = providerBranchUrl;
        }

        public static Deployment From(Dictionary<string, object> map) => new Deployment(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            type: (map.ContainsKey("type") ? map["type"] : "").ToString(),
            resourceId: (map.ContainsKey("resourceId") ? map["resourceId"] : "").ToString(),
            resourceType: (map.ContainsKey("resourceType") ? map["resourceType"] : "").ToString(),
            entrypoint: (map.ContainsKey("entrypoint") ? map["entrypoint"] : "").ToString(),
            sourceSize: Convert.ToInt64((map.ContainsKey("sourceSize") ? map["sourceSize"] : 0)),
            buildSize: Convert.ToInt64((map.ContainsKey("buildSize") ? map["buildSize"] : 0)),
            totalSize: Convert.ToInt64((map.ContainsKey("totalSize") ? map["totalSize"] : 0)),
            buildId: (map.ContainsKey("buildId") ? map["buildId"] : "").ToString(),
            activate: (bool)(map.ContainsKey("activate") ? map["activate"] : false),
            screenshotLight: (map.ContainsKey("screenshotLight") ? map["screenshotLight"] : "").ToString(),
            screenshotDark: (map.ContainsKey("screenshotDark") ? map["screenshotDark"] : "").ToString(),
            status: new Appwrite.Enums.DeploymentStatus(map["status"].ToString()!),
            buildLogs: (map.ContainsKey("buildLogs") ? map["buildLogs"] : "").ToString(),
            buildDuration: Convert.ToInt64((map.ContainsKey("buildDuration") ? map["buildDuration"] : 0)),
            providerRepositoryName: (map.ContainsKey("providerRepositoryName") ? map["providerRepositoryName"] : "").ToString(),
            providerRepositoryOwner: (map.ContainsKey("providerRepositoryOwner") ? map["providerRepositoryOwner"] : "").ToString(),
            providerRepositoryUrl: (map.ContainsKey("providerRepositoryUrl") ? map["providerRepositoryUrl"] : "").ToString(),
            providerCommitHash: (map.ContainsKey("providerCommitHash") ? map["providerCommitHash"] : "").ToString(),
            providerCommitAuthorUrl: (map.ContainsKey("providerCommitAuthorUrl") ? map["providerCommitAuthorUrl"] : "").ToString(),
            providerCommitAuthor: (map.ContainsKey("providerCommitAuthor") ? map["providerCommitAuthor"] : "").ToString(),
            providerCommitMessage: (map.ContainsKey("providerCommitMessage") ? map["providerCommitMessage"] : "").ToString(),
            providerCommitUrl: (map.ContainsKey("providerCommitUrl") ? map["providerCommitUrl"] : "").ToString(),
            providerBranch: (map.ContainsKey("providerBranch") ? map["providerBranch"] : "").ToString(),
            providerBranchUrl: (map.ContainsKey("providerBranchUrl") ? map["providerBranchUrl"] : "").ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "type", Type },
            { "resourceId", ResourceId },
            { "resourceType", ResourceType },
            { "entrypoint", Entrypoint },
            { "sourceSize", SourceSize },
            { "buildSize", BuildSize },
            { "totalSize", TotalSize },
            { "buildId", BuildId },
            { "activate", Activate },
            { "screenshotLight", ScreenshotLight },
            { "screenshotDark", ScreenshotDark },
            { "status", Status.Value },
            { "buildLogs", BuildLogs },
            { "buildDuration", BuildDuration },
            { "providerRepositoryName", ProviderRepositoryName },
            { "providerRepositoryOwner", ProviderRepositoryOwner },
            { "providerRepositoryUrl", ProviderRepositoryUrl },
            { "providerCommitHash", ProviderCommitHash },
            { "providerCommitAuthorUrl", ProviderCommitAuthorUrl },
            { "providerCommitAuthor", ProviderCommitAuthor },
            { "providerCommitMessage", ProviderCommitMessage },
            { "providerCommitUrl", ProviderCommitUrl },
            { "providerBranch", ProviderBranch },
            { "providerBranchUrl", ProviderBranchUrl }
        };
    }
}
