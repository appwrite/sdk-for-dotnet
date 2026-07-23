
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class ProjectService
    {
        [JsonPropertyName("$id")]
        public Appwrite.Enums.ProjectServiceId Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        public ProjectService(
            Appwrite.Enums.ProjectServiceId id,
            bool enabled
        )
        {
            Id = id;
            Enabled = enabled;
        }

        public static ProjectService From(Dictionary<string, object> map) => new ProjectService(
            id: new Appwrite.Enums.ProjectServiceId(map["$id"].ToString()!),
            enabled: (bool)map["enabled"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id.Value },
            { "enabled", Enabled }
        };
    }
}
