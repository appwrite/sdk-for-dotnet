
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Site
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("live")]
        public bool Live { get; private set; }

        [JsonPropertyName("logging")]
        public bool Logging { get; private set; }

        [JsonPropertyName("framework")]
        public string Framework { get; private set; }

        [JsonPropertyName("deploymentId")]
        public string DeploymentId { get; private set; }

        [JsonPropertyName("deploymentCreatedAt")]
        public string DeploymentCreatedAt { get; private set; }

        [JsonPropertyName("deploymentScreenshotLight")]
        public string DeploymentScreenshotLight { get; private set; }

        [JsonPropertyName("deploymentScreenshotDark")]
        public string DeploymentScreenshotDark { get; private set; }

        [JsonPropertyName("latestDeploymentId")]
        public string LatestDeploymentId { get; private set; }

        [JsonPropertyName("latestDeploymentCreatedAt")]
        public string LatestDeploymentCreatedAt { get; private set; }

        [JsonPropertyName("latestDeploymentStatus")]
        public string LatestDeploymentStatus { get; private set; }

        [JsonPropertyName("vars")]
        public List<Variable> Vars { get; private set; }

        [JsonPropertyName("timeout")]
        public long Timeout { get; private set; }

        [JsonPropertyName("installCommand")]
        public string InstallCommand { get; private set; }

        [JsonPropertyName("buildCommand")]
        public string BuildCommand { get; private set; }

        [JsonPropertyName("outputDirectory")]
        public string OutputDirectory { get; private set; }

        [JsonPropertyName("installationId")]
        public string InstallationId { get; private set; }

        [JsonPropertyName("providerRepositoryId")]
        public string ProviderRepositoryId { get; private set; }

        [JsonPropertyName("providerBranch")]
        public string ProviderBranch { get; private set; }

        [JsonPropertyName("providerRootDirectory")]
        public string ProviderRootDirectory { get; private set; }

        [JsonPropertyName("providerSilentMode")]
        public bool ProviderSilentMode { get; private set; }

        [JsonPropertyName("specification")]
        public string Specification { get; private set; }

        [JsonPropertyName("buildRuntime")]
        public string BuildRuntime { get; private set; }

        [JsonPropertyName("adapter")]
        public string Adapter { get; private set; }

        [JsonPropertyName("fallbackFile")]
        public string FallbackFile { get; private set; }

        public Site(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            bool enabled,
            bool live,
            bool logging,
            string framework,
            string deploymentId,
            string deploymentCreatedAt,
            string deploymentScreenshotLight,
            string deploymentScreenshotDark,
            string latestDeploymentId,
            string latestDeploymentCreatedAt,
            string latestDeploymentStatus,
            List<Variable> vars,
            long timeout,
            string installCommand,
            string buildCommand,
            string outputDirectory,
            string installationId,
            string providerRepositoryId,
            string providerBranch,
            string providerRootDirectory,
            bool providerSilentMode,
            string specification,
            string buildRuntime,
            string adapter,
            string fallbackFile
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Enabled = enabled;
            Live = live;
            Logging = logging;
            Framework = framework;
            DeploymentId = deploymentId;
            DeploymentCreatedAt = deploymentCreatedAt;
            DeploymentScreenshotLight = deploymentScreenshotLight;
            DeploymentScreenshotDark = deploymentScreenshotDark;
            LatestDeploymentId = latestDeploymentId;
            LatestDeploymentCreatedAt = latestDeploymentCreatedAt;
            LatestDeploymentStatus = latestDeploymentStatus;
            Vars = vars;
            Timeout = timeout;
            InstallCommand = installCommand;
            BuildCommand = buildCommand;
            OutputDirectory = outputDirectory;
            InstallationId = installationId;
            ProviderRepositoryId = providerRepositoryId;
            ProviderBranch = providerBranch;
            ProviderRootDirectory = providerRootDirectory;
            ProviderSilentMode = providerSilentMode;
            Specification = specification;
            BuildRuntime = buildRuntime;
            Adapter = adapter;
            FallbackFile = fallbackFile;
        }

        public static Site From(Dictionary<string, object> map) => new Site(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            name: map["name"].ToString(),
            enabled: (bool)map["enabled"],
            live: (bool)map["live"],
            logging: (bool)map["logging"],
            framework: map["framework"].ToString(),
            deploymentId: map["deploymentId"].ToString(),
            deploymentCreatedAt: map["deploymentCreatedAt"].ToString(),
            deploymentScreenshotLight: map["deploymentScreenshotLight"].ToString(),
            deploymentScreenshotDark: map["deploymentScreenshotDark"].ToString(),
            latestDeploymentId: map["latestDeploymentId"].ToString(),
            latestDeploymentCreatedAt: map["latestDeploymentCreatedAt"].ToString(),
            latestDeploymentStatus: map["latestDeploymentStatus"].ToString(),
            vars: map["vars"].ConvertToList<Dictionary<string, object>>().Select(it => Variable.From(map: it)).ToList(),
            timeout: Convert.ToInt64(map["timeout"]),
            installCommand: map["installCommand"].ToString(),
            buildCommand: map["buildCommand"].ToString(),
            outputDirectory: map["outputDirectory"].ToString(),
            installationId: map["installationId"].ToString(),
            providerRepositoryId: map["providerRepositoryId"].ToString(),
            providerBranch: map["providerBranch"].ToString(),
            providerRootDirectory: map["providerRootDirectory"].ToString(),
            providerSilentMode: (bool)map["providerSilentMode"],
            specification: map["specification"].ToString(),
            buildRuntime: map["buildRuntime"].ToString(),
            adapter: map["adapter"].ToString(),
            fallbackFile: map["fallbackFile"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "enabled", Enabled },
            { "live", Live },
            { "logging", Logging },
            { "framework", Framework },
            { "deploymentId", DeploymentId },
            { "deploymentCreatedAt", DeploymentCreatedAt },
            { "deploymentScreenshotLight", DeploymentScreenshotLight },
            { "deploymentScreenshotDark", DeploymentScreenshotDark },
            { "latestDeploymentId", LatestDeploymentId },
            { "latestDeploymentCreatedAt", LatestDeploymentCreatedAt },
            { "latestDeploymentStatus", LatestDeploymentStatus },
            { "vars", Vars.Select(it => it.ToMap()) },
            { "timeout", Timeout },
            { "installCommand", InstallCommand },
            { "buildCommand", BuildCommand },
            { "outputDirectory", OutputDirectory },
            { "installationId", InstallationId },
            { "providerRepositoryId", ProviderRepositoryId },
            { "providerBranch", ProviderBranch },
            { "providerRootDirectory", ProviderRootDirectory },
            { "providerSilentMode", ProviderSilentMode },
            { "specification", Specification },
            { "buildRuntime", BuildRuntime },
            { "adapter", Adapter },
            { "fallbackFile", FallbackFile }
        };
    }
}
