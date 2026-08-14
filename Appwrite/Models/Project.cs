
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

        [JsonPropertyName("region")]
        public string Region { get; private set; }

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

        [JsonPropertyName("onboarding")]
        public object Onboarding { get; private set; }

        [JsonPropertyName("authMethods")]
        public List<ProjectAuthMethod> AuthMethods { get; private set; }

        [JsonPropertyName("services")]
        public List<ProjectService> Services { get; private set; }

        [JsonPropertyName("protocols")]
        public List<ProjectProtocol> Protocols { get; private set; }

        [JsonPropertyName("blocks")]
        public List<Block> Blocks { get; private set; }

        [JsonPropertyName("consoleAccessedAt")]
        public string ConsoleAccessedAt { get; private set; }

        [JsonPropertyName("wafEnabled")]
        public bool WafEnabled { get; private set; }

        [JsonPropertyName("billingLimits")]
        public BillingLimits? BillingLimits { get; private set; }

        [JsonPropertyName("oAuth2ServerEnabled")]
        public bool? OAuth2ServerEnabled { get; private set; }

        [JsonPropertyName("oAuth2ServerAuthorizationUrl")]
        public string? OAuth2ServerAuthorizationUrl { get; private set; }

        [JsonPropertyName("oAuth2ServerScopes")]
        public List<string>? OAuth2ServerScopes { get; private set; }

        [JsonPropertyName("oAuth2ServerDefaultScopes")]
        public List<string>? OAuth2ServerDefaultScopes { get; private set; }

        [JsonPropertyName("oAuth2ServerInstallationScopes")]
        public List<string>? OAuth2ServerInstallationScopes { get; private set; }

        [JsonPropertyName("oAuth2ServerAuthorizationDetailsTypes")]
        public List<string>? OAuth2ServerAuthorizationDetailsTypes { get; private set; }

        [JsonPropertyName("oAuth2ServerAccessTokenDuration")]
        public long? OAuth2ServerAccessTokenDuration { get; private set; }

        [JsonPropertyName("oAuth2ServerRefreshTokenDuration")]
        public long? OAuth2ServerRefreshTokenDuration { get; private set; }

        [JsonPropertyName("oAuth2ServerPublicAccessTokenDuration")]
        public long? OAuth2ServerPublicAccessTokenDuration { get; private set; }

        [JsonPropertyName("oAuth2ServerPublicRefreshTokenDuration")]
        public long? OAuth2ServerPublicRefreshTokenDuration { get; private set; }

        [JsonPropertyName("oAuth2ServerInstallationAccessTokenDuration")]
        public long? OAuth2ServerInstallationAccessTokenDuration { get; private set; }

        [JsonPropertyName("oAuth2ServerConfidentialPkce")]
        public bool? OAuth2ServerConfidentialPkce { get; private set; }

        [JsonPropertyName("oAuth2ServerVerificationUrl")]
        public string? OAuth2ServerVerificationUrl { get; private set; }

        [JsonPropertyName("oAuth2ServerUserCodeLength")]
        public long? OAuth2ServerUserCodeLength { get; private set; }

        [JsonPropertyName("oAuth2ServerUserCodeFormat")]
        public string? OAuth2ServerUserCodeFormat { get; private set; }

        [JsonPropertyName("oAuth2ServerDeviceCodeDuration")]
        public long? OAuth2ServerDeviceCodeDuration { get; private set; }

        [JsonPropertyName("oAuth2ServerDiscoveryUrl")]
        public string? OAuth2ServerDiscoveryUrl { get; private set; }

        public Project(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            string teamId,
            string region,
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
            object onboarding,
            List<ProjectAuthMethod> authMethods,
            List<ProjectService> services,
            List<ProjectProtocol> protocols,
            List<Block> blocks,
            string consoleAccessedAt,
            bool wafEnabled,
            BillingLimits? billingLimits,
            bool? oAuth2ServerEnabled,
            string? oAuth2ServerAuthorizationUrl,
            List<string>? oAuth2ServerScopes,
            List<string>? oAuth2ServerDefaultScopes,
            List<string>? oAuth2ServerInstallationScopes,
            List<string>? oAuth2ServerAuthorizationDetailsTypes,
            long? oAuth2ServerAccessTokenDuration,
            long? oAuth2ServerRefreshTokenDuration,
            long? oAuth2ServerPublicAccessTokenDuration,
            long? oAuth2ServerPublicRefreshTokenDuration,
            long? oAuth2ServerInstallationAccessTokenDuration,
            bool? oAuth2ServerConfidentialPkce,
            string? oAuth2ServerVerificationUrl,
            long? oAuth2ServerUserCodeLength,
            string? oAuth2ServerUserCodeFormat,
            long? oAuth2ServerDeviceCodeDuration,
            string? oAuth2ServerDiscoveryUrl
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            TeamId = teamId;
            Region = region;
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
            Onboarding = onboarding;
            AuthMethods = authMethods;
            Services = services;
            Protocols = protocols;
            Blocks = blocks;
            ConsoleAccessedAt = consoleAccessedAt;
            WafEnabled = wafEnabled;
            BillingLimits = billingLimits;
            OAuth2ServerEnabled = oAuth2ServerEnabled;
            OAuth2ServerAuthorizationUrl = oAuth2ServerAuthorizationUrl;
            OAuth2ServerScopes = oAuth2ServerScopes;
            OAuth2ServerDefaultScopes = oAuth2ServerDefaultScopes;
            OAuth2ServerInstallationScopes = oAuth2ServerInstallationScopes;
            OAuth2ServerAuthorizationDetailsTypes = oAuth2ServerAuthorizationDetailsTypes;
            OAuth2ServerAccessTokenDuration = oAuth2ServerAccessTokenDuration;
            OAuth2ServerRefreshTokenDuration = oAuth2ServerRefreshTokenDuration;
            OAuth2ServerPublicAccessTokenDuration = oAuth2ServerPublicAccessTokenDuration;
            OAuth2ServerPublicRefreshTokenDuration = oAuth2ServerPublicRefreshTokenDuration;
            OAuth2ServerInstallationAccessTokenDuration = oAuth2ServerInstallationAccessTokenDuration;
            OAuth2ServerConfidentialPkce = oAuth2ServerConfidentialPkce;
            OAuth2ServerVerificationUrl = oAuth2ServerVerificationUrl;
            OAuth2ServerUserCodeLength = oAuth2ServerUserCodeLength;
            OAuth2ServerUserCodeFormat = oAuth2ServerUserCodeFormat;
            OAuth2ServerDeviceCodeDuration = oAuth2ServerDeviceCodeDuration;
            OAuth2ServerDiscoveryUrl = oAuth2ServerDiscoveryUrl;
        }

        public static Project From(Dictionary<string, object> map) => new Project(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            name: map["name"].ToString(),
            teamId: map["teamId"].ToString(),
            region: map["region"].ToString(),
            devKeys: map["devKeys"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.DevKey.From(map: it)).ToList(),
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
            onboarding: map["onboarding"],
            authMethods: map["authMethods"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.ProjectAuthMethod.From(map: it)).ToList(),
            services: map["services"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.ProjectService.From(map: it)).ToList(),
            protocols: map["protocols"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.ProjectProtocol.From(map: it)).ToList(),
            blocks: map["blocks"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Block.From(map: it)).ToList(),
            consoleAccessedAt: map["consoleAccessedAt"].ToString(),
            wafEnabled: (bool)map["wafEnabled"],
            billingLimits: map.TryGetValue("billingLimits", out var objectRaw29) && objectRaw29 != null
                                    ? Appwrite.Models.BillingLimits.From(map: objectRaw29 is JsonElement jsonObj29 ? jsonObj29.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)objectRaw29)
                                    : null,
            oAuth2ServerEnabled: map.TryGetValue("oAuth2ServerEnabled", out var boolRaw30) && boolRaw30 != null
                                        ? (bool?)boolRaw30
                                        : null,
            oAuth2ServerAuthorizationUrl: map.TryGetValue("oAuth2ServerAuthorizationUrl", out var oAuth2ServerAuthorizationUrl) ? oAuth2ServerAuthorizationUrl?.ToString() : null,
            oAuth2ServerScopes: map.TryGetValue("oAuth2ServerScopes", out var arrayRaw32) && arrayRaw32 != null
                                ? arrayRaw32.ConvertToList<string>()
                                : null,
            oAuth2ServerDefaultScopes: map.TryGetValue("oAuth2ServerDefaultScopes", out var arrayRaw33) && arrayRaw33 != null
                                ? arrayRaw33.ConvertToList<string>()
                                : null,
            oAuth2ServerInstallationScopes: map.TryGetValue("oAuth2ServerInstallationScopes", out var arrayRaw34) && arrayRaw34 != null
                                ? arrayRaw34.ConvertToList<string>()
                                : null,
            oAuth2ServerAuthorizationDetailsTypes: map.TryGetValue("oAuth2ServerAuthorizationDetailsTypes", out var arrayRaw35) && arrayRaw35 != null
                                ? arrayRaw35.ConvertToList<string>()
                                : null,
            oAuth2ServerAccessTokenDuration: map.TryGetValue("oAuth2ServerAccessTokenDuration", out var numberRaw36) && numberRaw36 != null
                                    ? Convert.ToInt64(numberRaw36)
                                    : null,
            oAuth2ServerRefreshTokenDuration: map.TryGetValue("oAuth2ServerRefreshTokenDuration", out var numberRaw37) && numberRaw37 != null
                                    ? Convert.ToInt64(numberRaw37)
                                    : null,
            oAuth2ServerPublicAccessTokenDuration: map.TryGetValue("oAuth2ServerPublicAccessTokenDuration", out var numberRaw38) && numberRaw38 != null
                                    ? Convert.ToInt64(numberRaw38)
                                    : null,
            oAuth2ServerPublicRefreshTokenDuration: map.TryGetValue("oAuth2ServerPublicRefreshTokenDuration", out var numberRaw39) && numberRaw39 != null
                                    ? Convert.ToInt64(numberRaw39)
                                    : null,
            oAuth2ServerInstallationAccessTokenDuration: map.TryGetValue("oAuth2ServerInstallationAccessTokenDuration", out var numberRaw40) && numberRaw40 != null
                                    ? Convert.ToInt64(numberRaw40)
                                    : null,
            oAuth2ServerConfidentialPkce: map.TryGetValue("oAuth2ServerConfidentialPkce", out var boolRaw41) && boolRaw41 != null
                                        ? (bool?)boolRaw41
                                        : null,
            oAuth2ServerVerificationUrl: map.TryGetValue("oAuth2ServerVerificationUrl", out var oAuth2ServerVerificationUrl) ? oAuth2ServerVerificationUrl?.ToString() : null,
            oAuth2ServerUserCodeLength: map.TryGetValue("oAuth2ServerUserCodeLength", out var numberRaw43) && numberRaw43 != null
                                    ? Convert.ToInt64(numberRaw43)
                                    : null,
            oAuth2ServerUserCodeFormat: map.TryGetValue("oAuth2ServerUserCodeFormat", out var oAuth2ServerUserCodeFormat) ? oAuth2ServerUserCodeFormat?.ToString() : null,
            oAuth2ServerDeviceCodeDuration: map.TryGetValue("oAuth2ServerDeviceCodeDuration", out var numberRaw45) && numberRaw45 != null
                                    ? Convert.ToInt64(numberRaw45)
                                    : null,
            oAuth2ServerDiscoveryUrl: map.TryGetValue("oAuth2ServerDiscoveryUrl", out var oAuth2ServerDiscoveryUrl) ? oAuth2ServerDiscoveryUrl?.ToString() : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "teamId", TeamId },
            { "region", Region },
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
            { "onboarding", Onboarding },
            { "authMethods", AuthMethods?.Select(it => it.ToMap()).ToList() },
            { "services", Services?.Select(it => it.ToMap()).ToList() },
            { "protocols", Protocols?.Select(it => it.ToMap()).ToList() },
            { "blocks", Blocks?.Select(it => it.ToMap()).ToList() },
            { "consoleAccessedAt", ConsoleAccessedAt },
            { "wafEnabled", WafEnabled },
            { "billingLimits", BillingLimits?.ToMap() },
            { "oAuth2ServerEnabled", OAuth2ServerEnabled },
            { "oAuth2ServerAuthorizationUrl", OAuth2ServerAuthorizationUrl },
            { "oAuth2ServerScopes", OAuth2ServerScopes },
            { "oAuth2ServerDefaultScopes", OAuth2ServerDefaultScopes },
            { "oAuth2ServerInstallationScopes", OAuth2ServerInstallationScopes },
            { "oAuth2ServerAuthorizationDetailsTypes", OAuth2ServerAuthorizationDetailsTypes },
            { "oAuth2ServerAccessTokenDuration", OAuth2ServerAccessTokenDuration },
            { "oAuth2ServerRefreshTokenDuration", OAuth2ServerRefreshTokenDuration },
            { "oAuth2ServerPublicAccessTokenDuration", OAuth2ServerPublicAccessTokenDuration },
            { "oAuth2ServerPublicRefreshTokenDuration", OAuth2ServerPublicRefreshTokenDuration },
            { "oAuth2ServerInstallationAccessTokenDuration", OAuth2ServerInstallationAccessTokenDuration },
            { "oAuth2ServerConfidentialPkce", OAuth2ServerConfidentialPkce },
            { "oAuth2ServerVerificationUrl", OAuth2ServerVerificationUrl },
            { "oAuth2ServerUserCodeLength", OAuth2ServerUserCodeLength },
            { "oAuth2ServerUserCodeFormat", OAuth2ServerUserCodeFormat },
            { "oAuth2ServerDeviceCodeDuration", OAuth2ServerDeviceCodeDuration },
            { "oAuth2ServerDiscoveryUrl", OAuth2ServerDiscoveryUrl }
        };
    }
}
