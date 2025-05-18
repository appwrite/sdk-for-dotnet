
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class FrameworkAdapter
    {
        [JsonProperty("key")]
        public string Key { get; private set; }

        [JsonProperty("installCommand")]
        public string InstallCommand { get; private set; }

        [JsonProperty("buildCommand")]
        public string BuildCommand { get; private set; }

        [JsonProperty("outputDirectory")]
        public string OutputDirectory { get; private set; }

        [JsonProperty("fallbackFile")]
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
