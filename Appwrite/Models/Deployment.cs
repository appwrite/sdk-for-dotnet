
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

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
        public string Status { get; private set; }

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

        [JsonPropertyName("providerBranch")]
        public string ProviderBranch { get; private set; }

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
            string status,
            string buildLogs,
            long buildDuration,
            string providerRepositoryName,
            string providerRepositoryOwner,
            string providerRepositoryUrl,
            string providerBranch,
            string providerCommitHash,
            string providerCommitAuthorUrl,
            string providerCommitAuthor,
            string providerCommitMessage,
            string providerCommitUrl,
            string providerBranchUrl
        ) {
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
            ProviderBranch = providerBranch;
            ProviderCommitHash = providerCommitHash;
            ProviderCommitAuthorUrl = providerCommitAuthorUrl;
            ProviderCommitAuthor = providerCommitAuthor;
            ProviderCommitMessage = providerCommitMessage;
            ProviderCommitUrl = providerCommitUrl;
            ProviderBranchUrl = providerBranchUrl;
        }

        public static Deployment From(Dictionary<string, object> map) => new Deployment(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            type: map["type"].ToString(),
            resourceId: map["resourceId"].ToString(),
            resourceType: map["resourceType"].ToString(),
            entrypoint: map["entrypoint"].ToString(),
            sourceSize: Convert.ToInt64(map["sourceSize"]),
            buildSize: Convert.ToInt64(map["buildSize"]),
            totalSize: Convert.ToInt64(map["totalSize"]),
            buildId: map["buildId"].ToString(),
            activate: (bool)map["activate"],
            screenshotLight: map["screenshotLight"].ToString(),
            screenshotDark: map["screenshotDark"].ToString(),
            status: map["status"].ToString(),
            buildLogs: map["buildLogs"].ToString(),
            buildDuration: Convert.ToInt64(map["buildDuration"]),
            providerRepositoryName: map["providerRepositoryName"].ToString(),
            providerRepositoryOwner: map["providerRepositoryOwner"].ToString(),
            providerRepositoryUrl: map["providerRepositoryUrl"].ToString(),
            providerBranch: map["providerBranch"].ToString(),
            providerCommitHash: map["providerCommitHash"].ToString(),
            providerCommitAuthorUrl: map["providerCommitAuthorUrl"].ToString(),
            providerCommitAuthor: map["providerCommitAuthor"].ToString(),
            providerCommitMessage: map["providerCommitMessage"].ToString(),
            providerCommitUrl: map["providerCommitUrl"].ToString(),
            providerBranchUrl: map["providerBranchUrl"].ToString()
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
            { "status", Status },
            { "buildLogs", BuildLogs },
            { "buildDuration", BuildDuration },
            { "providerRepositoryName", ProviderRepositoryName },
            { "providerRepositoryOwner", ProviderRepositoryOwner },
            { "providerRepositoryUrl", ProviderRepositoryUrl },
            { "providerBranch", ProviderBranch },
            { "providerCommitHash", ProviderCommitHash },
            { "providerCommitAuthorUrl", ProviderCommitAuthorUrl },
            { "providerCommitAuthor", ProviderCommitAuthor },
            { "providerCommitMessage", ProviderCommitMessage },
            { "providerCommitUrl", ProviderCommitUrl },
            { "providerBranchUrl", ProviderBranchUrl }
        };
    }
}
