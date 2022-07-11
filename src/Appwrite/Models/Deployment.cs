
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Deployment
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        [JsonProperty("$createdAt")]
        public long CreatedAt { get; set; }

        [JsonProperty("$updatedAt")]
        public long UpdatedAt { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("entrypoint")]
        public string Entrypoint { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("buildId")]
        public string BuildId { get; set; }

        [JsonProperty("activate")]
        public bool Activate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("buildStdout")]
        public string BuildStdout { get; set; }

        [JsonProperty("buildStderr")]
        public string BuildStderr { get; set; }


        public Deployment(
            string id,
            long createdAt,
            long updatedAt,
            string resourceId,
            string resourceType,
            string entrypoint,
            long size,
            string buildId,
            bool activate,
            string status,
            string buildStdout,
            string buildStderr
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ResourceId = resourceId;
            ResourceType = resourceType;
            Entrypoint = entrypoint;
            Size = size;
            BuildId = buildId;
            Activate = activate;
            Status = status;
            BuildStdout = buildStdout;
            BuildStderr = buildStderr;
        }

        public static Deployment From(Dictionary<string, object> map) => new Deployment(
            id: (string)map["$id"],
            createdAt: Convert.ToInt64(map["$createdAt"]),
            updatedAt: Convert.ToInt64(map["$updatedAt"]),
            resourceId: (string)map["resourceId"],
            resourceType: (string)map["resourceType"],
            entrypoint: (string)map["entrypoint"],
            size: Convert.ToInt64(map["size"]),
            buildId: (string)map["buildId"],
            activate: (bool)map["activate"],
            status: (string)map["status"],
            buildStdout: (string)map["buildStdout"],
            buildStderr: (string)map["buildStderr"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "resourceId", ResourceId },
            { "resourceType", ResourceType },
            { "entrypoint", Entrypoint },
            { "size", Size },
            { "buildId", BuildId },
            { "activate", Activate },
            { "status", Status },
            { "buildStdout", BuildStdout },
            { "buildStderr", BuildStderr }
        };
    }
}