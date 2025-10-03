
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

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

        [JsonPropertyName("specification")]
        public string Specification { get; private set; }

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
            string deploymentId,
            string deploymentCreatedAt,
            string latestDeploymentId,
            string latestDeploymentCreatedAt,
            string latestDeploymentStatus,
            List<string> scopes,
            List<Variable> vars,
            List<string> events,
            string schedule,
            long timeout,
            string entrypoint,
            string commands,
            string version,
            string installationId,
            string providerRepositoryId,
            string providerBranch,
            string providerRootDirectory,
            bool providerSilentMode,
            string specification
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Execute = execute;
            Name = name;
            Enabled = enabled;
            Live = live;
            Logging = logging;
            Runtime = runtime;
            DeploymentId = deploymentId;
            DeploymentCreatedAt = deploymentCreatedAt;
            LatestDeploymentId = latestDeploymentId;
            LatestDeploymentCreatedAt = latestDeploymentCreatedAt;
            LatestDeploymentStatus = latestDeploymentStatus;
            Scopes = scopes;
            Vars = vars;
            Events = events;
            Schedule = schedule;
            Timeout = timeout;
            Entrypoint = entrypoint;
            Commands = commands;
            Version = version;
            InstallationId = installationId;
            ProviderRepositoryId = providerRepositoryId;
            ProviderBranch = providerBranch;
            ProviderRootDirectory = providerRootDirectory;
            ProviderSilentMode = providerSilentMode;
            Specification = specification;
        }

        public static Function From(Dictionary<string, object> map) => new Function(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            execute: map["execute"] is JsonElement jsonArrayProp4 ? jsonArrayProp4.Deserialize<List<string>>()! : (List<string>)map["execute"],
            name: map["name"].ToString(),
            enabled: (bool)map["enabled"],
            live: (bool)map["live"],
            logging: (bool)map["logging"],
            runtime: map["runtime"].ToString(),
            deploymentId: map["deploymentId"].ToString(),
            deploymentCreatedAt: map["deploymentCreatedAt"].ToString(),
            latestDeploymentId: map["latestDeploymentId"].ToString(),
            latestDeploymentCreatedAt: map["latestDeploymentCreatedAt"].ToString(),
            latestDeploymentStatus: map["latestDeploymentStatus"].ToString(),
            scopes: map["scopes"] is JsonElement jsonArrayProp15 ? jsonArrayProp15.Deserialize<List<string>>()! : (List<string>)map["scopes"],
            vars: map["vars"] is JsonElement jsonArray16 ? jsonArray16.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Variable.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["vars"]).Select(it => Variable.From(map: it)).ToList(),
            events: map["events"] is JsonElement jsonArrayProp17 ? jsonArrayProp17.Deserialize<List<string>>()! : (List<string>)map["events"],
            schedule: map["schedule"].ToString(),
            timeout: Convert.ToInt64(map["timeout"]),
            entrypoint: map["entrypoint"].ToString(),
            commands: map["commands"].ToString(),
            version: map["version"].ToString(),
            installationId: map["installationId"].ToString(),
            providerRepositoryId: map["providerRepositoryId"].ToString(),
            providerBranch: map["providerBranch"].ToString(),
            providerRootDirectory: map["providerRootDirectory"].ToString(),
            providerSilentMode: (bool)map["providerSilentMode"],
            specification: map["specification"].ToString()
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
            { "deploymentId", DeploymentId },
            { "deploymentCreatedAt", DeploymentCreatedAt },
            { "latestDeploymentId", LatestDeploymentId },
            { "latestDeploymentCreatedAt", LatestDeploymentCreatedAt },
            { "latestDeploymentStatus", LatestDeploymentStatus },
            { "scopes", Scopes },
            { "vars", Vars.Select(it => it.ToMap()) },
            { "events", Events },
            { "schedule", Schedule },
            { "timeout", Timeout },
            { "entrypoint", Entrypoint },
            { "commands", Commands },
            { "version", Version },
            { "installationId", InstallationId },
            { "providerRepositoryId", ProviderRepositoryId },
            { "providerBranch", ProviderBranch },
            { "providerRootDirectory", ProviderRootDirectory },
            { "providerSilentMode", ProviderSilentMode },
            { "specification", Specification }
        };
    }
}
