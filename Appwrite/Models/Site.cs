
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Site
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; private set; }

        [JsonProperty("live")]
        public bool Live { get; private set; }

        [JsonProperty("logging")]
        public bool Logging { get; private set; }

        [JsonProperty("framework")]
        public string Framework { get; private set; }

        [JsonProperty("deploymentId")]
        public string DeploymentId { get; private set; }

        [JsonProperty("deploymentCreatedAt")]
        public string DeploymentCreatedAt { get; private set; }

        [JsonProperty("deploymentScreenshotLight")]
        public string DeploymentScreenshotLight { get; private set; }

        [JsonProperty("deploymentScreenshotDark")]
        public string DeploymentScreenshotDark { get; private set; }

        [JsonProperty("latestDeploymentId")]
        public string LatestDeploymentId { get; private set; }

        [JsonProperty("latestDeploymentCreatedAt")]
        public string LatestDeploymentCreatedAt { get; private set; }

        [JsonProperty("latestDeploymentStatus")]
        public string LatestDeploymentStatus { get; private set; }

        [JsonProperty("vars")]
        public List<Variable> Vars { get; private set; }

        [JsonProperty("timeout")]
        public long Timeout { get; private set; }

        [JsonProperty("installCommand")]
        public string InstallCommand { get; private set; }

        [JsonProperty("buildCommand")]
        public string BuildCommand { get; private set; }

        [JsonProperty("outputDirectory")]
        public string OutputDirectory { get; private set; }

        [JsonProperty("installationId")]
        public string InstallationId { get; private set; }

        [JsonProperty("providerRepositoryId")]
        public string ProviderRepositoryId { get; private set; }

        [JsonProperty("providerBranch")]
        public string ProviderBranch { get; private set; }

        [JsonProperty("providerRootDirectory")]
        public string ProviderRootDirectory { get; private set; }

        [JsonProperty("providerSilentMode")]
        public bool ProviderSilentMode { get; private set; }

        [JsonProperty("specification")]
        public string Specification { get; private set; }

        [JsonProperty("buildRuntime")]
        public string BuildRuntime { get; private set; }

        [JsonProperty("adapter")]
        public string Adapter { get; private set; }

        [JsonProperty("fallbackFile")]
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
            vars: ((JArray)map["vars"]).ToObject<List<Dictionary<string, object>>>().Select(it => Variable.From(map: it)).ToList(),
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
