
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class ProjectAuthMethod
    {
        [JsonPropertyName("$id")]
        public ProjectAuthMethodId Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        public ProjectAuthMethod(
            ProjectAuthMethodId id,
            bool enabled
        )
        {
            Id = id;
            Enabled = enabled;
        }

        public static ProjectAuthMethod From(Dictionary<string, object> map) => new ProjectAuthMethod(
            id: new ProjectAuthMethodId(map["$id"].ToString()!),
            enabled: (bool)map["enabled"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id.Value },
            { "enabled", Enabled }
        };
    }
}
