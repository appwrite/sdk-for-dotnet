
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class TemplateRuntime
    {
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("commands")]
        public string Commands { get; private set; }

        [JsonPropertyName("entrypoint")]
        public string Entrypoint { get; private set; }

        [JsonPropertyName("providerRootDirectory")]
        public string ProviderRootDirectory { get; private set; }

        public TemplateRuntime(
            string name,
            string commands,
            string entrypoint,
            string providerRootDirectory
        ) {
            Name = name;
            Commands = commands;
            Entrypoint = entrypoint;
            ProviderRootDirectory = providerRootDirectory;
        }

        public static TemplateRuntime From(Dictionary<string, object> map) => new TemplateRuntime(
            name: map["name"].ToString(),
            commands: map["commands"].ToString(),
            entrypoint: map["entrypoint"].ToString(),
            providerRootDirectory: map["providerRootDirectory"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "name", Name },
            { "commands", Commands },
            { "entrypoint", Entrypoint },
            { "providerRootDirectory", ProviderRootDirectory }
        };
    }
}
