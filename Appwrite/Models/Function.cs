
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Function
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("execute")]
        public List<string> Execute { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("live")]
        public bool Live { get; private set; }

        [JsonPropertyName("logging")]
        public bool Logging { get; private set; }

        [JsonPropertyName("runtime")]
        public string Runtime { get; private set; }

        [JsonPropertyName("deploymentRetention")]
        public long DeploymentRetention { get; private set; }

        [JsonPropertyName("deploymentId")]
        public string DeploymentId { get; private set; }

        [JsonPropertyName("deploymentCreatedAt")]
        public string DeploymentCreatedAt { get; private set; }

        [JsonPropertyName("latestDeploymentId")]
        public string LatestDeploymentId { get; private set; }

        [JsonPropertyName("latestDeploymentCreatedAt")]
        public string LatestDeploymentCreatedAt { get; private set; }

        [JsonPropertyName("latestDeploymentStatus")]
        public string LatestDeploymentStatus { get; private set; }

        [JsonPropertyName("scopes")]
        public List<string> Scopes { get; private set; }

        [JsonPropertyName("vars")]
        public List<Variable> Vars { get; private set; }

        [JsonPropertyName("events")]
        public List<string> Events { get; private set; }

        [JsonPropertyName("schedule")]
        public string Schedule { get; private set; }

        [JsonPropertyName("interval")]
        public long? Interval { get; private set; }

        [JsonPropertyName("timeout")]
        public long Timeout { get; private set; }

        [JsonPropertyName("entrypoint")]
        public string Entrypoint { get; private set; }

        [JsonPropertyName("commands")]
        public string Commands { get; private set; }

        [JsonPropertyName("version")]
        public string Version { get; private set; }

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

        [JsonPropertyName("providerBranches")]
        public List<string> ProviderBranches { get; private set; }

        [JsonPropertyName("providerPaths")]
        public List<string> ProviderPaths { get; private set; }

        [JsonPropertyName("buildSpecification")]
        public string BuildSpecification { get; private set; }

        [JsonPropertyName("runtimeSpecification")]
        public string RuntimeSpecification { get; private set; }

        public Function(
            string id,
            string createdAt,
            string updatedAt,
            List<string> execute,
            string name,
            bool enabled,
            bool live,
            bool logging,
            string runtime,
            long deploymentRetention,
            string deploymentId,
            string deploymentCreatedAt,
            string latestDeploymentId,
            string latestDeploymentCreatedAt,
            string latestDeploymentStatus,
            List<string> scopes,
            List<Variable> vars,
            List<string> events,
            string schedule,
            long? interval,
            long timeout,
            string entrypoint,
            string commands,
            string version,
            string installationId,
            string providerRepositoryId,
            string providerBranch,
            string providerRootDirectory,
            bool providerSilentMode,
            List<string> providerBranches,
            List<string> providerPaths,
            string buildSpecification,
            string runtimeSpecification
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Execute = execute;
            Name = name;
            Enabled = enabled;
            Live = live;
            Logging = logging;
            Runtime = runtime;
            DeploymentRetention = deploymentRetention;
            DeploymentId = deploymentId;
            DeploymentCreatedAt = deploymentCreatedAt;
            LatestDeploymentId = latestDeploymentId;
            LatestDeploymentCreatedAt = latestDeploymentCreatedAt;
            LatestDeploymentStatus = latestDeploymentStatus;
            Scopes = scopes;
            Vars = vars;
            Events = events;
            Schedule = schedule;
            Interval = interval;
            Timeout = timeout;
            Entrypoint = entrypoint;
            Commands = commands;
            Version = version;
            InstallationId = installationId;
            ProviderRepositoryId = providerRepositoryId;
            ProviderBranch = providerBranch;
            ProviderRootDirectory = providerRootDirectory;
            ProviderSilentMode = providerSilentMode;
            ProviderBranches = providerBranches;
            ProviderPaths = providerPaths;
            BuildSpecification = buildSpecification;
            RuntimeSpecification = runtimeSpecification;
        }

        public static Function From(Dictionary<string, object> map) => new Function(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            execute: (map.ContainsKey("execute") ? map["execute"] : new List<object>()).ConvertToList<string>(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            enabled: (bool)(map.ContainsKey("enabled") ? map["enabled"] : true),
            live: (bool)(map.ContainsKey("live") ? map["live"] : true),
            logging: (bool)(map.ContainsKey("logging") ? map["logging"] : true),
            runtime: (map.ContainsKey("runtime") ? map["runtime"] : "").ToString(),
            deploymentRetention: Convert.ToInt64((map.ContainsKey("deploymentRetention") ? map["deploymentRetention"] : 0)),
            deploymentId: (map.ContainsKey("deploymentId") ? map["deploymentId"] : "").ToString(),
            deploymentCreatedAt: (map.ContainsKey("deploymentCreatedAt") ? map["deploymentCreatedAt"] : "").ToString(),
            latestDeploymentId: (map.ContainsKey("latestDeploymentId") ? map["latestDeploymentId"] : "").ToString(),
            latestDeploymentCreatedAt: (map.ContainsKey("latestDeploymentCreatedAt") ? map["latestDeploymentCreatedAt"] : "").ToString(),
            latestDeploymentStatus: (map.ContainsKey("latestDeploymentStatus") ? map["latestDeploymentStatus"] : "").ToString(),
            scopes: (map.ContainsKey("scopes") ? map["scopes"] : new List<object>()).ConvertToList<string>(),
            vars: map["vars"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Variable.From(map: it)).ToList(),
            events: (map.ContainsKey("events") ? map["events"] : new List<object>()).ConvertToList<string>(),
            schedule: (map.ContainsKey("schedule") ? map["schedule"] : "").ToString(),
            interval: map.TryGetValue("interval", out var numberRaw20) && numberRaw20 != null
                                    ? Convert.ToInt64(numberRaw20)
                                    : null,
            timeout: Convert.ToInt64((map.ContainsKey("timeout") ? map["timeout"] : 15)),
            entrypoint: (map.ContainsKey("entrypoint") ? map["entrypoint"] : "").ToString(),
            commands: (map.ContainsKey("commands") ? map["commands"] : "").ToString(),
            version: (map.ContainsKey("version") ? map["version"] : "v5").ToString(),
            installationId: (map.ContainsKey("installationId") ? map["installationId"] : "").ToString(),
            providerRepositoryId: (map.ContainsKey("providerRepositoryId") ? map["providerRepositoryId"] : "").ToString(),
            providerBranch: (map.ContainsKey("providerBranch") ? map["providerBranch"] : "").ToString(),
            providerRootDirectory: (map.ContainsKey("providerRootDirectory") ? map["providerRootDirectory"] : "").ToString(),
            providerSilentMode: (bool)(map.ContainsKey("providerSilentMode") ? map["providerSilentMode"] : false),
            providerBranches: (map.ContainsKey("providerBranches") ? map["providerBranches"] : new List<object>()).ConvertToList<string>(),
            providerPaths: (map.ContainsKey("providerPaths") ? map["providerPaths"] : new List<object>()).ConvertToList<string>(),
            buildSpecification: (map.ContainsKey("buildSpecification") ? map["buildSpecification"] : "s-1vcpu-512mb").ToString(),
            runtimeSpecification: (map.ContainsKey("runtimeSpecification") ? map["runtimeSpecification"] : "s-1vcpu-512mb").ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "execute", Execute },
            { "name", Name },
            { "enabled", Enabled },
            { "live", Live },
            { "logging", Logging },
            { "runtime", Runtime },
            { "deploymentRetention", DeploymentRetention },
            { "deploymentId", DeploymentId },
            { "deploymentCreatedAt", DeploymentCreatedAt },
            { "latestDeploymentId", LatestDeploymentId },
            { "latestDeploymentCreatedAt", LatestDeploymentCreatedAt },
            { "latestDeploymentStatus", LatestDeploymentStatus },
            { "scopes", Scopes },
            { "vars", Vars?.Select(it => it.ToMap()).ToList() },
            { "events", Events },
            { "schedule", Schedule },
            { "interval", Interval },
            { "timeout", Timeout },
            { "entrypoint", Entrypoint },
            { "commands", Commands },
            { "version", Version },
            { "installationId", InstallationId },
            { "providerRepositoryId", ProviderRepositoryId },
            { "providerBranch", ProviderBranch },
            { "providerRootDirectory", ProviderRootDirectory },
            { "providerSilentMode", ProviderSilentMode },
            { "providerBranches", ProviderBranches },
            { "providerPaths", ProviderPaths },
            { "buildSpecification", BuildSpecification },
            { "runtimeSpecification", RuntimeSpecification }
        };
    }
}
