
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class FrameworkAdapter
    {
        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("installCommand")]
        public string InstallCommand { get; private set; }

        [JsonPropertyName("buildCommand")]
        public string BuildCommand { get; private set; }

        [JsonPropertyName("outputDirectory")]
        public string OutputDirectory { get; private set; }

        [JsonPropertyName("fallbackFile")]
        public string FallbackFile { get; private set; }

        public FrameworkAdapter(
            string key,
            string installCommand,
            string buildCommand,
            string outputDirectory,
            string fallbackFile
        ) {
            Key = key;
            InstallCommand = installCommand;
            BuildCommand = buildCommand;
            OutputDirectory = outputDirectory;
            FallbackFile = fallbackFile;
        }

        public static FrameworkAdapter From(Dictionary<string, object> map) => new FrameworkAdapter(
            key: map["key"].ToString(),
            installCommand: map["installCommand"].ToString(),
            buildCommand: map["buildCommand"].ToString(),
            outputDirectory: map["outputDirectory"].ToString(),
            fallbackFile: map["fallbackFile"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "installCommand", InstallCommand },
            { "buildCommand", BuildCommand },
            { "outputDirectory", OutputDirectory },
            { "fallbackFile", FallbackFile }
        };
    }
}
