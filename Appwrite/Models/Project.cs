
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Project
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("teamId")]
        public string TeamId { get; private set; }

        [JsonPropertyName("devKeys")]
        public List<DevKey> DevKeys { get; private set; }

        [JsonPropertyName("smtpEnabled")]
        public bool SmtpEnabled { get; private set; }

        [JsonPropertyName("smtpSenderName")]
        public string SmtpSenderName { get; private set; }

        [JsonPropertyName("smtpSenderEmail")]
        public string SmtpSenderEmail { get; private set; }

        [JsonPropertyName("smtpReplyToName")]
        public string SmtpReplyToName { get; private set; }

        [JsonPropertyName("smtpReplyToEmail")]
        public string SmtpReplyToEmail { get; private set; }

        [JsonPropertyName("smtpHost")]
        public string SmtpHost { get; private set; }

        [JsonPropertyName("smtpPort")]
        public long SmtpPort { get; private set; }

        [JsonPropertyName("smtpUsername")]
        public string SmtpUsername { get; private set; }

        [JsonPropertyName("smtpPassword")]
        public string SmtpPassword { get; private set; }

        [JsonPropertyName("smtpSecure")]
        public string SmtpSecure { get; private set; }

        [JsonPropertyName("pingCount")]
        public long PingCount { get; private set; }

        [JsonPropertyName("pingedAt")]
        public string PingedAt { get; private set; }

        [JsonPropertyName("labels")]
        public List<string> Labels { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        [JsonPropertyName("authMethods")]
        public List<ProjectAuthMethod> AuthMethods { get; private set; }

        [JsonPropertyName("services")]
        public List<ProjectService> Services { get; private set; }

        [JsonPropertyName("protocols")]
        public List<ProjectProtocol> Protocols { get; private set; }

        [JsonPropertyName("region")]
        public string Region { get; private set; }

        [JsonPropertyName("billingLimits")]
        public BillingLimits BillingLimits { get; private set; }

        [JsonPropertyName("blocks")]
        public List<Block> Blocks { get; private set; }

        [JsonPropertyName("consoleAccessedAt")]
        public string ConsoleAccessedAt { get; private set; }

        public Project(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            string teamId,
            List<DevKey> devKeys,
            bool smtpEnabled,
            string smtpSenderName,
            string smtpSenderEmail,
            string smtpReplyToName,
            string smtpReplyToEmail,
            string smtpHost,
            long smtpPort,
            string smtpUsername,
            string smtpPassword,
            string smtpSecure,
            long pingCount,
            string pingedAt,
            List<string> labels,
            string status,
            List<ProjectAuthMethod> authMethods,
            List<ProjectService> services,
            List<ProjectProtocol> protocols,
            string region,
            BillingLimits billingLimits,
            List<Block> blocks,
            string consoleAccessedAt
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            TeamId = teamId;
            DevKeys = devKeys;
            SmtpEnabled = smtpEnabled;
            SmtpSenderName = smtpSenderName;
            SmtpSenderEmail = smtpSenderEmail;
            SmtpReplyToName = smtpReplyToName;
            SmtpReplyToEmail = smtpReplyToEmail;
            SmtpHost = smtpHost;
            SmtpPort = smtpPort;
            SmtpUsername = smtpUsername;
            SmtpPassword = smtpPassword;
            SmtpSecure = smtpSecure;
            PingCount = pingCount;
            PingedAt = pingedAt;
            Labels = labels;
            Status = status;
            AuthMethods = authMethods;
            Services = services;
            Protocols = protocols;
            Region = region;
            BillingLimits = billingLimits;
            Blocks = blocks;
            ConsoleAccessedAt = consoleAccessedAt;
        }

        public static Project From(Dictionary<string, object> map) => new Project(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            name: map["name"].ToString(),
            teamId: map["teamId"].ToString(),
            devKeys: map["devKeys"].ConvertToList<Dictionary<string, object>>().Select(it => DevKey.From(map: it)).ToList(),
            smtpEnabled: (bool)map["smtpEnabled"],
            smtpSenderName: map["smtpSenderName"].ToString(),
            smtpSenderEmail: map["smtpSenderEmail"].ToString(),
            smtpReplyToName: map["smtpReplyToName"].ToString(),
            smtpReplyToEmail: map["smtpReplyToEmail"].ToString(),
            smtpHost: map["smtpHost"].ToString(),
            smtpPort: Convert.ToInt64(map["smtpPort"]),
            smtpUsername: map["smtpUsername"].ToString(),
            smtpPassword: map["smtpPassword"].ToString(),
            smtpSecure: map["smtpSecure"].ToString(),
            pingCount: Convert.ToInt64(map["pingCount"]),
            pingedAt: map["pingedAt"].ToString(),
            labels: map["labels"].ConvertToList<string>(),
            status: map["status"].ToString(),
            authMethods: map["authMethods"].ConvertToList<Dictionary<string, object>>().Select(it => ProjectAuthMethod.From(map: it)).ToList(),
            services: map["services"].ConvertToList<Dictionary<string, object>>().Select(it => ProjectService.From(map: it)).ToList(),
            protocols: map["protocols"].ConvertToList<Dictionary<string, object>>().Select(it => ProjectProtocol.From(map: it)).ToList(),
            region: map["region"].ToString(),
            billingLimits: BillingLimits.From(map: map["billingLimits"] is JsonElement jsonObj25 ? jsonObj25.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["billingLimits"]),
            blocks: map["blocks"].ConvertToList<Dictionary<string, object>>().Select(it => Block.From(map: it)).ToList(),
            consoleAccessedAt: map["consoleAccessedAt"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "teamId", TeamId },
            { "devKeys", DevKeys?.Select(it => it.ToMap()).ToList() },
            { "smtpEnabled", SmtpEnabled },
            { "smtpSenderName", SmtpSenderName },
            { "smtpSenderEmail", SmtpSenderEmail },
            { "smtpReplyToName", SmtpReplyToName },
            { "smtpReplyToEmail", SmtpReplyToEmail },
            { "smtpHost", SmtpHost },
            { "smtpPort", SmtpPort },
            { "smtpUsername", SmtpUsername },
            { "smtpPassword", SmtpPassword },
            { "smtpSecure", SmtpSecure },
            { "pingCount", PingCount },
            { "pingedAt", PingedAt },
            { "labels", Labels },
            { "status", Status },
            { "authMethods", AuthMethods?.Select(it => it.ToMap()).ToList() },
            { "services", Services?.Select(it => it.ToMap()).ToList() },
            { "protocols", Protocols?.Select(it => it.ToMap()).ToList() },
            { "region", Region },
            { "billingLimits", BillingLimits?.ToMap() },
            { "blocks", Blocks?.Select(it => it.ToMap()).ToList() },
            { "consoleAccessedAt", ConsoleAccessedAt }
        };
    }
}
