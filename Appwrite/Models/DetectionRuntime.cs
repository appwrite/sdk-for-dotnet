
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class DetectionRuntime
    {
        [JsonPropertyName("runtime")]
        public string Runtime { get; private set; }

        [JsonPropertyName("entrypoint")]
        public string Entrypoint { get; private set; }

        [JsonPropertyName("commands")]
        public string Commands { get; private set; }

        public DetectionRuntime(
            string runtime,
            string entrypoint,
            string commands
        ) {
            Runtime = runtime;
            Entrypoint = entrypoint;
            Commands = commands;
        }

        public static DetectionRuntime From(Dictionary<string, object> map) => new DetectionRuntime(
            runtime: map["runtime"].ToString(),
            entrypoint: map["entrypoint"].ToString(),
            commands: map["commands"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "runtime", Runtime },
            { "entrypoint", Entrypoint },
            { "commands", Commands }
        };
    }
}
