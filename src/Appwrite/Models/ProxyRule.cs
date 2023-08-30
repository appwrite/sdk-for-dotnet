
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class ProxyRule
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("domain")]
        public string Domain { get; private set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; private set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; private set; }

        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("logs")]
        public string Logs { get; private set; }

        [JsonProperty("renewAt")]
        public string RenewAt { get; private set; }

        public ProxyRule(
            string id,
            string createdAt,
            string updatedAt,
            string domain,
            string resourceType,
            string resourceId,
            string status,
            string logs,
            string renewAt
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Domain = domain;
            ResourceType = resourceType;
            ResourceId = resourceId;
            Status = status;
            Logs = logs;
            RenewAt = renewAt;
        }

        public static ProxyRule From(Dictionary<string, object> map) => new ProxyRule(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            domain: map["domain"].ToString(),
            resourceType: map["resourceType"].ToString(),
            resourceId: map["resourceId"].ToString(),
            status: map["status"].ToString(),
            logs: map["logs"].ToString(),
            renewAt: map["renewAt"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "domain", Domain },
            { "resourceType", ResourceType },
            { "resourceId", ResourceId },
            { "status", Status },
            { "logs", Logs },
            { "renewAt", RenewAt }
        };
    }
}