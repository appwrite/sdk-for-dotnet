
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class DetectionFramework
    {
        [JsonPropertyName("framework")]
        public string Framework { get; private set; }

        [JsonPropertyName("installCommand")]
        public string InstallCommand { get; private set; }

        [JsonPropertyName("buildCommand")]
        public string BuildCommand { get; private set; }

        [JsonPropertyName("outputDirectory")]
        public string OutputDirectory { get; private set; }

        public DetectionFramework(
            string framework,
            string installCommand,
            string buildCommand,
            string outputDirectory
        ) {
            Framework = framework;
            InstallCommand = installCommand;
            BuildCommand = buildCommand;
            OutputDirectory = outputDirectory;
        }

        public static DetectionFramework From(Dictionary<string, object> map) => new DetectionFramework(
            framework: map["framework"].ToString(),
            installCommand: map["installCommand"].ToString(),
            buildCommand: map["buildCommand"].ToString(),
            outputDirectory: map["outputDirectory"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "framework", Framework },
            { "installCommand", InstallCommand },
            { "buildCommand", BuildCommand },
            { "outputDirectory", OutputDirectory }
        };
    }
}
