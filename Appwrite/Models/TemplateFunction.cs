
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class TemplateFunction
    {
        [JsonPropertyName("icon")]
        public string Icon { get; private set; }

        [JsonPropertyName("id")]
        public string Id { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("tagline")]
        public string Tagline { get; private set; }

        [JsonPropertyName("permissions")]
        public List<string> Permissions { get; private set; }

        [JsonPropertyName("events")]
        public List<string> Events { get; private set; }

        [JsonPropertyName("cron")]
        public string Cron { get; private set; }

        [JsonPropertyName("timeout")]
        public long Timeout { get; private set; }

        [JsonPropertyName("useCases")]
        public List<string> UseCases { get; private set; }

        [JsonPropertyName("runtimes")]
        public List<TemplateRuntime> Runtimes { get; private set; }

        [JsonPropertyName("instructions")]
        public string Instructions { get; private set; }

        [JsonPropertyName("vcsProvider")]
        public string VcsProvider { get; private set; }

        [JsonPropertyName("providerRepositoryId")]
        public string ProviderRepositoryId { get; private set; }

        [JsonPropertyName("providerOwner")]
        public string ProviderOwner { get; private set; }

        [JsonPropertyName("providerVersion")]
        public string ProviderVersion { get; private set; }

        [JsonPropertyName("variables")]
        public List<TemplateVariable> Variables { get; private set; }

        [JsonPropertyName("scopes")]
        public List<string> Scopes { get; private set; }

        public TemplateFunction(
            string icon,
            string id,
            string name,
            string tagline,
            List<string> permissions,
            List<string> events,
            string cron,
            long timeout,
            List<string> useCases,
            List<TemplateRuntime> runtimes,
            string instructions,
            string vcsProvider,
            string providerRepositoryId,
            string providerOwner,
            string providerVersion,
            List<TemplateVariable> variables,
            List<string> scopes
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
            permissions: map["permissions"] is JsonElement jsonArrayProp5 ? jsonArrayProp5.Deserialize<List<string>>()! : (List<string>)map["permissions"],
            events: map["events"] is JsonElement jsonArrayProp6 ? jsonArrayProp6.Deserialize<List<string>>()! : (List<string>)map["events"],
            cron: map["cron"].ToString(),
            timeout: Convert.ToInt64(map["timeout"]),
            useCases: map["useCases"] is JsonElement jsonArrayProp9 ? jsonArrayProp9.Deserialize<List<string>>()! : (List<string>)map["useCases"],
            runtimes: map["runtimes"] is JsonElement jsonArray10 ? jsonArray10.Deserialize<List<Dictionary<string, object>>>()!.Select(it => TemplateRuntime.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["runtimes"]).Select(it => TemplateRuntime.From(map: it)).ToList(),
            instructions: map["instructions"].ToString(),
            vcsProvider: map["vcsProvider"].ToString(),
            providerRepositoryId: map["providerRepositoryId"].ToString(),
            providerOwner: map["providerOwner"].ToString(),
            providerVersion: map["providerVersion"].ToString(),
            variables: map["variables"] is JsonElement jsonArray16 ? jsonArray16.Deserialize<List<Dictionary<string, object>>>()!.Select(it => TemplateVariable.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["variables"]).Select(it => TemplateVariable.From(map: it)).ToList(),
            scopes: map["scopes"] is JsonElement jsonArrayProp17 ? jsonArrayProp17.Deserialize<List<string>>()! : (List<string>)map["scopes"]
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
