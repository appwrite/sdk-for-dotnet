
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseExtensions
    {
        [JsonPropertyName("installed")]
        public List<string> Installed { get; private set; }

        [JsonPropertyName("available")]
        public List<string> Available { get; private set; }

        [JsonPropertyName("metadata")]
        public List<PostgresExtension> Metadata { get; private set; }

        public DedicatedDatabaseExtensions(
            List<string> installed,
            List<string> available,
            List<PostgresExtension> metadata
        )
        {
            Installed = installed;
            Available = available;
            Metadata = metadata;
        }

        public static DedicatedDatabaseExtensions From(Dictionary<string, object> map) => new DedicatedDatabaseExtensions(
            installed: map["installed"].ConvertToList<string>(),
            available: map["available"].ConvertToList<string>(),
            metadata: map["metadata"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.PostgresExtension.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "installed", Installed },
            { "available", Available },
            { "metadata", Metadata?.Select(it => it.ToMap()).ToList() }
        };
    }
}
