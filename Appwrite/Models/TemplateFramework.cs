
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class TemplateFramework
    {
        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("installCommand")]
        public string InstallCommand { get; private set; }

        [JsonPropertyName("buildCommand")]
        public string BuildCommand { get; private set; }

        [JsonPropertyName("outputDirectory")]
        public string OutputDirectory { get; private set; }

        [JsonPropertyName("providerRootDirectory")]
        public string ProviderRootDirectory { get; private set; }

        [JsonPropertyName("buildRuntime")]
        public string BuildRuntime { get; private set; }

        [JsonPropertyName("adapter")]
        public string Adapter { get; private set; }

        [JsonPropertyName("fallbackFile")]
        public string FallbackFile { get; private set; }

        public TemplateFramework(
            string key,
            string name,
            string installCommand,
            string buildCommand,
            string outputDirectory,
            string providerRootDirectory,
            string buildRuntime,
            string adapter,
            string fallbackFile
        ) {
            Key = key;
            Name = name;
            InstallCommand = installCommand;
            BuildCommand = buildCommand;
            OutputDirectory = outputDirectory;
            ProviderRootDirectory = providerRootDirectory;
            BuildRuntime = buildRuntime;
            Adapter = adapter;
            FallbackFile = fallbackFile;
        }

        public static TemplateFramework From(Dictionary<string, object> map) => new TemplateFramework(
            key: map["key"].ToString(),
            name: map["name"].ToString(),
            installCommand: map["installCommand"].ToString(),
            buildCommand: map["buildCommand"].ToString(),
            outputDirectory: map["outputDirectory"].ToString(),
            providerRootDirectory: map["providerRootDirectory"].ToString(),
            buildRuntime: map["buildRuntime"].ToString(),
            adapter: map["adapter"].ToString(),
            fallbackFile: map["fallbackFile"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "name", Name },
            { "installCommand", InstallCommand },
            { "buildCommand", BuildCommand },
            { "outputDirectory", OutputDirectory },
            { "providerRootDirectory", ProviderRootDirectory },
            { "buildRuntime", BuildRuntime },
            { "adapter", Adapter },
            { "fallbackFile", FallbackFile }
        };
    }
}
