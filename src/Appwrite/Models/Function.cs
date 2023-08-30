
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Function
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("execute")]
        public List<object> Execute { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; private set; }

        [JsonProperty("live")]
        public bool Live { get; private set; }

        [JsonProperty("logging")]
        public bool Logging { get; private set; }

        [JsonProperty("runtime")]
        public string Runtime { get; private set; }

        [JsonProperty("deployment")]
        public string Deployment { get; private set; }

        [JsonProperty("vars")]
        public List<Variable> Vars { get; private set; }

        [JsonProperty("events")]
        public List<object> Events { get; private set; }

        [JsonProperty("schedule")]
        public string Schedule { get; private set; }

        [JsonProperty("timeout")]
        public long Timeout { get; private set; }

        [JsonProperty("entrypoint")]
        public string Entrypoint { get; private set; }

        [JsonProperty("commands")]
        public string Commands { get; private set; }

        [JsonProperty("version")]
        public string Version { get; private set; }

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

        public Function(
            string id,
            string createdAt,
            string updatedAt,
            List<object> execute,
            string name,
            bool enabled,
            bool live,
            bool logging,
            string runtime,
            string deployment,
            List<Variable> vars,
            List<object> events,
            string schedule,
            long timeout,
            string entrypoint,
            string commands,
            string version,
            string installationId,
            string providerRepositoryId,
            string providerBranch,
            string providerRootDirectory,
            bool providerSilentMode
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
            Deployment = deployment;
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
        }

        public static Function From(Dictionary<string, object> map) => new Function(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            execute: ((JArray)map["execute"]).ToObject<List<object>>(),
            name: map["name"].ToString(),
            enabled: (bool)map["enabled"],
            live: (bool)map["live"],
            logging: (bool)map["logging"],
            runtime: map["runtime"].ToString(),
            deployment: map["deployment"].ToString(),
            vars: ((JArray)map["vars"]).ToObject<List<Dictionary<string, object>>>().Select(it => Variable.From(map: it)).ToList(),
            events: ((JArray)map["events"]).ToObject<List<object>>(),
            schedule: map["schedule"].ToString(),
            timeout: Convert.ToInt64(map["timeout"]),
            entrypoint: map["entrypoint"].ToString(),
            commands: map["commands"].ToString(),
            version: map["version"].ToString(),
            installationId: map["installationId"].ToString(),
            providerRepositoryId: map["providerRepositoryId"].ToString(),
            providerBranch: map["providerBranch"].ToString(),
            providerRootDirectory: map["providerRootDirectory"].ToString(),
            providerSilentMode: (bool)map["providerSilentMode"]
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
            { "deployment", Deployment },
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
            { "providerSilentMode", ProviderSilentMode }
        };
    }
}