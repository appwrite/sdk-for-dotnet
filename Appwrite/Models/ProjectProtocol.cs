
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class ProjectProtocol
    {
        [JsonPropertyName("$id")]
        public ProjectProtocolId Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        public ProjectProtocol(
            ProjectProtocolId id,
            bool enabled
        )
        {
            Id = id;
            Enabled = enabled;
        }

        public static ProjectProtocol From(Dictionary<string, object> map) => new ProjectProtocol(
            id: new ProjectProtocolId(map["$id"].ToString()!),
            enabled: (bool)map["enabled"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id.Value },
            { "enabled", Enabled }
        };
    }
}
