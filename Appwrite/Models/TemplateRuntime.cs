
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class TemplateRuntime
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("commands")]
        public string Commands { get; private set; }

        [JsonProperty("entrypoint")]
        public string Entrypoint { get; private set; }

        [JsonProperty("providerRootDirectory")]
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