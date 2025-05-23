
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Deployment
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("type")]
        public string Type { get; private set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; private set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; private set; }

        [JsonProperty("entrypoint")]
        public string Entrypoint { get; private set; }

        [JsonProperty("sourceSize")]
        public long SourceSize { get; private set; }

        [JsonProperty("buildSize")]
        public long BuildSize { get; private set; }

        [JsonProperty("totalSize")]
        public long TotalSize { get; private set; }

        [JsonProperty("buildId")]
        public string BuildId { get; private set; }

        [JsonProperty("activate")]
        public bool Activate { get; private set; }

        [JsonProperty("screenshotLight")]
        public string ScreenshotLight { get; private set; }

        [JsonProperty("screenshotDark")]
        public string ScreenshotDark { get; private set; }

        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("buildLogs")]
        public string BuildLogs { get; private set; }

        [JsonProperty("buildDuration")]
        public long BuildDuration { get; private set; }

        [JsonProperty("providerRepositoryName")]
        public string ProviderRepositoryName { get; private set; }

        [JsonProperty("providerRepositoryOwner")]
        public string ProviderRepositoryOwner { get; private set; }

        [JsonProperty("providerRepositoryUrl")]
        public string ProviderRepositoryUrl { get; private set; }

        [JsonProperty("providerBranch")]
        public string ProviderBranch { get; private set; }

        [JsonProperty("providerCommitHash")]
        public string ProviderCommitHash { get; private set; }

        [JsonProperty("providerCommitAuthorUrl")]
        public string ProviderCommitAuthorUrl { get; private set; }

        [JsonProperty("providerCommitAuthor")]
        public string ProviderCommitAuthor { get; private set; }

        [JsonProperty("providerCommitMessage")]
        public string ProviderCommitMessage { get; private set; }

        [JsonProperty("providerCommitUrl")]
        public string ProviderCommitUrl { get; private set; }

        [JsonProperty("providerBranchUrl")]
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
