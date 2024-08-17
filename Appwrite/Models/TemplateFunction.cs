
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class TemplateFunction
    {
        [JsonProperty("icon")]
        public string Icon { get; private set; }

        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("tagline")]
        public string Tagline { get; private set; }

        [JsonProperty("permissions")]
        public List<object> Permissions { get; private set; }

        [JsonProperty("events")]
        public List<object> Events { get; private set; }

        [JsonProperty("cron")]
        public string Cron { get; private set; }

        [JsonProperty("timeout")]
        public long Timeout { get; private set; }

        [JsonProperty("useCases")]
        public List<object> UseCases { get; private set; }

        [JsonProperty("runtimes")]
        public List<TemplateRuntime> Runtimes { get; private set; }

        [JsonProperty("instructions")]
        public string Instructions { get; private set; }

        [JsonProperty("vcsProvider")]
        public string VcsProvider { get; private set; }

        [JsonProperty("providerRepositoryId")]
        public string ProviderRepositoryId { get; private set; }

        [JsonProperty("providerOwner")]
        public string ProviderOwner { get; private set; }

        [JsonProperty("providerVersion")]
        public string ProviderVersion { get; private set; }

        [JsonProperty("variables")]
        public List<TemplateVariable> Variables { get; private set; }

        [JsonProperty("scopes")]
        public List<object> Scopes { get; private set; }

        public TemplateFunction(
            string icon,
            string id,
            string name,
            string tagline,
            List<object> permissions,
            List<object> events,
            string cron,
            long timeout,
            List<object> useCases,
            List<TemplateRuntime> runtimes,
            string instructions,
            string vcsProvider,
            string providerRepositoryId,
            string providerOwner,
            string providerVersion,
            List<TemplateVariable> variables,
            List<object> scopes
        ) {
            Icon = icon;
            Id = id;
            Name = name;
            Tagline = tagline;
            Permissions = permissions;
            Events = events;
            Cron = cron;
            Timeout = timeout;
            UseCases = useCases;
            Runtimes = runtimes;
            Instructions = instructions;
            VcsProvider = vcsProvider;
            ProviderRepositoryId = providerRepositoryId;
            ProviderOwner = providerOwner;
            ProviderVersion = providerVersion;
            Variables = variables;
            Scopes = scopes;
        }

        public static TemplateFunction From(Dictionary<string, object> map) => new TemplateFunction(
            icon: map["icon"].ToString(),
            id: map["id"].ToString(),
            name: map["name"].ToString(),
            tagline: map["tagline"].ToString(),
            permissions: ((JArray)map["permissions"]).ToObject<List<object>>(),
            events: ((JArray)map["events"]).ToObject<List<object>>(),
            cron: map["cron"].ToString(),
            timeout: Convert.ToInt64(map["timeout"]),
            useCases: ((JArray)map["useCases"]).ToObject<List<object>>(),
            runtimes: ((JArray)map["runtimes"]).ToObject<List<Dictionary<string, object>>>().Select(it => TemplateRuntime.From(map: it)).ToList(),
            instructions: map["instructions"].ToString(),
            vcsProvider: map["vcsProvider"].ToString(),
            providerRepositoryId: map["providerRepositoryId"].ToString(),
            providerOwner: map["providerOwner"].ToString(),
            providerVersion: map["providerVersion"].ToString(),
            variables: ((JArray)map["variables"]).ToObject<List<Dictionary<string, object>>>().Select(it => TemplateVariable.From(map: it)).ToList(),
            scopes: ((JArray)map["scopes"]).ToObject<List<object>>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "icon", Icon },
            { "id", Id },
            { "name", Name },
            { "tagline", Tagline },
            { "permissions", Permissions },
            { "events", Events },
            { "cron", Cron },
            { "timeout", Timeout },
            { "useCases", UseCases },
            { "runtimes", Runtimes.Select(it => it.ToMap()) },
            { "instructions", Instructions },
            { "vcsProvider", VcsProvider },
            { "providerRepositoryId", ProviderRepositoryId },
            { "providerOwner", ProviderOwner },
            { "providerVersion", ProviderVersion },
            { "variables", Variables.Select(it => it.ToMap()) },
            { "scopes", Scopes }
        };
    }
}