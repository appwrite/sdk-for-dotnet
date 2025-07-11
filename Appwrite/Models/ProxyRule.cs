
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class ProxyRule
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("domain")]
        public string Domain { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("trigger")]
        public string Trigger { get; private set; }

        [JsonPropertyName("redirectUrl")]
        public string RedirectUrl { get; private set; }

        [JsonPropertyName("redirectStatusCode")]
        public long RedirectStatusCode { get; private set; }

        [JsonPropertyName("deploymentId")]
        public string DeploymentId { get; private set; }

        [JsonPropertyName("deploymentResourceType")]
        public string DeploymentResourceType { get; private set; }

        [JsonPropertyName("deploymentResourceId")]
        public string DeploymentResourceId { get; private set; }

        [JsonPropertyName("deploymentVcsProviderBranch")]
        public string DeploymentVcsProviderBranch { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        [JsonPropertyName("logs")]
        public string Logs { get; private set; }

        [JsonPropertyName("renewAt")]
        public string RenewAt { get; private set; }

        public ProxyRule(
            string id,
            string createdAt,
            string updatedAt,
            string domain,
            string type,
            string trigger,
            string redirectUrl,
            long redirectStatusCode,
            string deploymentId,
            string deploymentResourceType,
            string deploymentResourceId,
            string deploymentVcsProviderBranch,
            string status,
            string logs,
            string renewAt
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Domain = domain;
            Type = type;
            Trigger = trigger;
            RedirectUrl = redirectUrl;
            RedirectStatusCode = redirectStatusCode;
            DeploymentId = deploymentId;
            DeploymentResourceType = deploymentResourceType;
            DeploymentResourceId = deploymentResourceId;
            DeploymentVcsProviderBranch = deploymentVcsProviderBranch;
            Status = status;
            Logs = logs;
            RenewAt = renewAt;
        }

        public static ProxyRule From(Dictionary<string, object> map) => new ProxyRule(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            domain: map["domain"].ToString(),
            type: map["type"].ToString(),
            trigger: map["trigger"].ToString(),
            redirectUrl: map["redirectUrl"].ToString(),
            redirectStatusCode: Convert.ToInt64(map["redirectStatusCode"]),
            deploymentId: map["deploymentId"].ToString(),
            deploymentResourceType: map["deploymentResourceType"].ToString(),
            deploymentResourceId: map["deploymentResourceId"].ToString(),
            deploymentVcsProviderBranch: map["deploymentVcsProviderBranch"].ToString(),
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
            { "type", Type },
            { "trigger", Trigger },
            { "redirectUrl", RedirectUrl },
            { "redirectStatusCode", RedirectStatusCode },
            { "deploymentId", DeploymentId },
            { "deploymentResourceType", DeploymentResourceType },
            { "deploymentResourceId", DeploymentResourceId },
            { "deploymentVcsProviderBranch", DeploymentVcsProviderBranch },
            { "status", Status },
            { "logs", Logs },
            { "renewAt", RenewAt }
        };
    }
}
