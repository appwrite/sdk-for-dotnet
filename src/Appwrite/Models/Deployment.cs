
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
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; private set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; private set; }

        [JsonProperty("entrypoint")]
        public string Entrypoint { get; private set; }

        [JsonProperty("size")]
        public long Size { get; private set; }

        [JsonProperty("buildId")]
        public string BuildId { get; private set; }

        [JsonProperty("activate")]
        public bool Activate { get; private set; }

        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("buildStdout")]
        public string BuildStdout { get; private set; }

        [JsonProperty("buildStderr")]
        public string BuildStderr { get; private set; }

        [JsonProperty("buildTime")]
        public long BuildTime { get; private set; }

        public Deployment(
            string id,
            string createdAt,
            string updatedAt,
            string resourceId,
            string resourceType,
            string entrypoint,
            long size,
            string buildId,
            bool activate,
            string status,
            string buildStdout,
            string buildStderr,
            long buildTime
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
            BuildTime = buildTime;
        }

        public static Deployment From(Dictionary<string, object> map) => new Deployment(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            resourceId: map["resourceId"].ToString(),
            resourceType: map["resourceType"].ToString(),
            entrypoint: map["entrypoint"].ToString(),
            size: Convert.ToInt64(map["size"]),
            buildId: map["buildId"].ToString(),
            activate: (bool)map["activate"],
            status: map["status"].ToString(),
            buildStdout: map["buildStdout"].ToString(),
            buildStderr: map["buildStderr"].ToString(),
            buildTime: Convert.ToInt64(map["buildTime"])
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
            { "buildStderr", BuildStderr },
            { "buildTime", BuildTime }
        };
    }
}