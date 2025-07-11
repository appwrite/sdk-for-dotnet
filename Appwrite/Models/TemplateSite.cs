
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class TemplateSite
    {
        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("tagline")]
        public string Tagline { get; private set; }

        [JsonPropertyName("demoUrl")]
        public string DemoUrl { get; private set; }

        [JsonPropertyName("screenshotDark")]
        public string ScreenshotDark { get; private set; }

        [JsonPropertyName("screenshotLight")]
        public string ScreenshotLight { get; private set; }

        [JsonPropertyName("useCases")]
        public List<string> UseCases { get; private set; }

        [JsonPropertyName("frameworks")]
        public List<TemplateFramework> Frameworks { get; private set; }

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

        public TemplateSite(
            string key,
            string name,
            string tagline,
            string demoUrl,
            string screenshotDark,
            string screenshotLight,
            List<string> useCases,
            List<TemplateFramework> frameworks,
            string vcsProvider,
            string providerRepositoryId,
            string providerOwner,
            string providerVersion,
            List<TemplateVariable> variables
        ) {
            Key = key;
            Name = name;
            Tagline = tagline;
            DemoUrl = demoUrl;
            ScreenshotDark = screenshotDark;
            ScreenshotLight = screenshotLight;
            UseCases = useCases;
            Frameworks = frameworks;
            VcsProvider = vcsProvider;
            ProviderRepositoryId = providerRepositoryId;
            ProviderOwner = providerOwner;
            ProviderVersion = providerVersion;
            Variables = variables;
        }

        public static TemplateSite From(Dictionary<string, object> map) => new TemplateSite(
            key: map["key"].ToString(),
            name: map["name"].ToString(),
            tagline: map["tagline"].ToString(),
            demoUrl: map["demoUrl"].ToString(),
            screenshotDark: map["screenshotDark"].ToString(),
            screenshotLight: map["screenshotLight"].ToString(),
            useCases: map["useCases"] is JsonElement jsonArrayProp7 ? jsonArrayProp7.Deserialize<List<string>>()! : (List<string>)map["useCases"],
            frameworks: map["frameworks"] is JsonElement jsonArray8 ? jsonArray8.Deserialize<List<Dictionary<string, object>>>()!.Select(it => TemplateFramework.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["frameworks"]).Select(it => TemplateFramework.From(map: it)).ToList(),
            vcsProvider: map["vcsProvider"].ToString(),
            providerRepositoryId: map["providerRepositoryId"].ToString(),
            providerOwner: map["providerOwner"].ToString(),
            providerVersion: map["providerVersion"].ToString(),
            variables: map["variables"] is JsonElement jsonArray13 ? jsonArray13.Deserialize<List<Dictionary<string, object>>>()!.Select(it => TemplateVariable.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["variables"]).Select(it => TemplateVariable.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "name", Name },
            { "tagline", Tagline },
            { "demoUrl", DemoUrl },
            { "screenshotDark", ScreenshotDark },
            { "screenshotLight", ScreenshotLight },
            { "useCases", UseCases },
            { "frameworks", Frameworks.Select(it => it.ToMap()) },
            { "vcsProvider", VcsProvider },
            { "providerRepositoryId", ProviderRepositoryId },
            { "providerOwner", ProviderOwner },
            { "providerVersion", ProviderVersion },
            { "variables", Variables.Select(it => it.ToMap()) }
        };
    }
}
