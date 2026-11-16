
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

        [JsonPropertyName("ldapEnabled")]
        public bool LdapEnabled { get; private set; }

        [JsonPropertyName("ldapHosts")]
        public List<string> LdapHosts { get; private set; }

        [JsonPropertyName("ldapPort")]
        public long LdapPort { get; private set; }

        [JsonPropertyName("ldapEncryption")]
        public string LdapEncryption { get; private set; }

        [JsonPropertyName("ldapVerification")]
        public bool LdapVerification { get; private set; }

        [JsonPropertyName("ldapCertificate")]
        public string LdapCertificate { get; private set; }

        [JsonPropertyName("ldapTimeout")]
        public long LdapTimeout { get; private set; }

        [JsonPropertyName("ldapBaseDn")]
        public string LdapBaseDn { get; private set; }

        [JsonPropertyName("ldapBindDn")]
        public string LdapBindDn { get; private set; }

        [JsonPropertyName("ldapBindPassword")]
        public string LdapBindPassword { get; private set; }

        [JsonPropertyName("ldapUserFilter")]
        public string LdapUserFilter { get; private set; }

        [JsonPropertyName("ldapRequiredGroupDn")]
        public string LdapRequiredGroupDn { get; private set; }

        [JsonPropertyName("ldapIdAttribute")]
        public string LdapIdAttribute { get; private set; }

        [JsonPropertyName("ldapEmailAttribute")]
        public string LdapEmailAttribute { get; private set; }

        [JsonPropertyName("ldapNameAttribute")]
        public string LdapNameAttribute { get; private set; }

        [JsonPropertyName("ldapPhoneAttribute")]
        public string LdapPhoneAttribute { get; private set; }

        [JsonPropertyName("pingCount")]
        public long PingCount { get; private set; }

        [JsonPropertyName("pingedAt")]
        public string PingedAt { get; private set; }

        [JsonPropertyName("labels")]
        public List<string> Labels { get; private set; }

        [JsonPropertyName("prefs")]
        public Preferences? Prefs { get; private set; }

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
        public bool? WafEnabled { get; private set; }

        [JsonPropertyName("parentId")]
        public string? ParentId { get; private set; }

        [JsonPropertyName("environmentId")]
        public string? EnvironmentId { get; private set; }

        [JsonPropertyName("billingLimits")]
        public BillingLimits? BillingLimits { get; private set; }

        [JsonPropertyName("firstAccessedAt")]
        public string? FirstAccessedAt { get; private set; }

        [JsonPropertyName("mcpAccessedAt")]
        public string? McpAccessedAt { get; private set; }

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
            bool ldapEnabled,
            List<string> ldapHosts,
            long ldapPort,
            string ldapEncryption,
            bool ldapVerification,
            string ldapCertificate,
            long ldapTimeout,
            string ldapBaseDn,
            string ldapBindDn,
            string ldapBindPassword,
            string ldapUserFilter,
            string ldapRequiredGroupDn,
            string ldapIdAttribute,
            string ldapEmailAttribute,
            string ldapNameAttribute,
            string ldapPhoneAttribute,
            long pingCount,
            string pingedAt,
            List<string> labels,
            Preferences? prefs,
            string status,
            object onboarding,
            List<ProjectAuthMethod> authMethods,
            List<ProjectService> services,
            List<ProjectProtocol> protocols,
            List<Block> blocks,
            string consoleAccessedAt,
            bool? wafEnabled,
            string? parentId,
            string? environmentId,
            BillingLimits? billingLimits,
            string? firstAccessedAt,
            string? mcpAccessedAt,
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
            LdapEnabled = ldapEnabled;
            LdapHosts = ldapHosts;
            LdapPort = ldapPort;
            LdapEncryption = ldapEncryption;
            LdapVerification = ldapVerification;
            LdapCertificate = ldapCertificate;
            LdapTimeout = ldapTimeout;
            LdapBaseDn = ldapBaseDn;
            LdapBindDn = ldapBindDn;
            LdapBindPassword = ldapBindPassword;
            LdapUserFilter = ldapUserFilter;
            LdapRequiredGroupDn = ldapRequiredGroupDn;
            LdapIdAttribute = ldapIdAttribute;
            LdapEmailAttribute = ldapEmailAttribute;
            LdapNameAttribute = ldapNameAttribute;
            LdapPhoneAttribute = ldapPhoneAttribute;
            PingCount = pingCount;
            PingedAt = pingedAt;
            Labels = labels;
            Prefs = prefs;
            Status = status;
            Onboarding = onboarding;
            AuthMethods = authMethods;
            Services = services;
            Protocols = protocols;
            Blocks = blocks;
            ConsoleAccessedAt = consoleAccessedAt;
            WafEnabled = wafEnabled;
            ParentId = parentId;
            EnvironmentId = environmentId;
            BillingLimits = billingLimits;
            FirstAccessedAt = firstAccessedAt;
            McpAccessedAt = mcpAccessedAt;
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
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            teamId: (map.ContainsKey("teamId") ? map["teamId"] : "").ToString(),
            region: (map.ContainsKey("region") ? map["region"] : "fra").ToString(),
            smtpEnabled: (bool)(map.ContainsKey("smtpEnabled") ? map["smtpEnabled"] : false),
            smtpSenderName: (map.ContainsKey("smtpSenderName") ? map["smtpSenderName"] : "").ToString(),
            smtpSenderEmail: (map.ContainsKey("smtpSenderEmail") ? map["smtpSenderEmail"] : "").ToString(),
            smtpReplyToName: (map.ContainsKey("smtpReplyToName") ? map["smtpReplyToName"] : "").ToString(),
            smtpReplyToEmail: (map.ContainsKey("smtpReplyToEmail") ? map["smtpReplyToEmail"] : "").ToString(),
            smtpHost: (map.ContainsKey("smtpHost") ? map["smtpHost"] : "").ToString(),
            smtpPort: Convert.ToInt64((map.ContainsKey("smtpPort") ? map["smtpPort"] : 0)),
            smtpUsername: (map.ContainsKey("smtpUsername") ? map["smtpUsername"] : "").ToString(),
            smtpPassword: (map.ContainsKey("smtpPassword") ? map["smtpPassword"] : "").ToString(),
            smtpSecure: (map.ContainsKey("smtpSecure") ? map["smtpSecure"] : "").ToString(),
            ldapEnabled: (bool)(map.ContainsKey("ldapEnabled") ? map["ldapEnabled"] : false),
            ldapHosts: (map.ContainsKey("ldapHosts") ? map["ldapHosts"] : new List<object>()).ConvertToList<string>(),
            ldapPort: Convert.ToInt64((map.ContainsKey("ldapPort") ? map["ldapPort"] : 636)),
            ldapEncryption: (map.ContainsKey("ldapEncryption") ? map["ldapEncryption"] : "ldaps").ToString(),
            ldapVerification: (bool)(map.ContainsKey("ldapVerification") ? map["ldapVerification"] : true),
            ldapCertificate: (map.ContainsKey("ldapCertificate") ? map["ldapCertificate"] : "").ToString(),
            ldapTimeout: Convert.ToInt64((map.ContainsKey("ldapTimeout") ? map["ldapTimeout"] : 10)),
            ldapBaseDn: (map.ContainsKey("ldapBaseDn") ? map["ldapBaseDn"] : "").ToString(),
            ldapBindDn: (map.ContainsKey("ldapBindDn") ? map["ldapBindDn"] : "").ToString(),
            ldapBindPassword: (map.ContainsKey("ldapBindPassword") ? map["ldapBindPassword"] : "").ToString(),
            ldapUserFilter: (map.ContainsKey("ldapUserFilter") ? map["ldapUserFilter"] : "(uid={username})").ToString(),
            ldapRequiredGroupDn: (map.ContainsKey("ldapRequiredGroupDn") ? map["ldapRequiredGroupDn"] : "").ToString(),
            ldapIdAttribute: (map.ContainsKey("ldapIdAttribute") ? map["ldapIdAttribute"] : "entryUUID").ToString(),
            ldapEmailAttribute: (map.ContainsKey("ldapEmailAttribute") ? map["ldapEmailAttribute"] : "mail").ToString(),
            ldapNameAttribute: (map.ContainsKey("ldapNameAttribute") ? map["ldapNameAttribute"] : "cn").ToString(),
            ldapPhoneAttribute: (map.ContainsKey("ldapPhoneAttribute") ? map["ldapPhoneAttribute"] : "").ToString(),
            pingCount: Convert.ToInt64((map.ContainsKey("pingCount") ? map["pingCount"] : 0)),
            pingedAt: (map.ContainsKey("pingedAt") ? map["pingedAt"] : "").ToString(),
            labels: (map.ContainsKey("labels") ? map["labels"] : new List<object>()).ConvertToList<string>(),
            prefs: map.TryGetValue("prefs", out var objectRaw36) && objectRaw36 != null
                                    ? Appwrite.Models.Preferences.From(map: objectRaw36 is JsonElement jsonObj36 ? jsonObj36.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)objectRaw36)
                                    : null,
            status: (map.ContainsKey("status") ? map["status"] : "active").ToString(),
            onboarding: (map.ContainsKey("onboarding") ? map["onboarding"] : new Dictionary<string, object>()),
            authMethods: (map.ContainsKey("authMethods") ? map["authMethods"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.ProjectAuthMethod.From(map: it)).ToList(),
            services: (map.ContainsKey("services") ? map["services"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.ProjectService.From(map: it)).ToList(),
            protocols: (map.ContainsKey("protocols") ? map["protocols"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.ProjectProtocol.From(map: it)).ToList(),
            blocks: (map.ContainsKey("blocks") ? map["blocks"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Block.From(map: it)).ToList(),
            consoleAccessedAt: (map.ContainsKey("consoleAccessedAt") ? map["consoleAccessedAt"] : "").ToString(),
            wafEnabled: map.TryGetValue("wafEnabled", out var boolRaw44) && boolRaw44 != null
                                        ? (bool?)boolRaw44
                                        : null,
            parentId: map.TryGetValue("parentId", out var parentId) ? parentId?.ToString() : null,
            environmentId: map.TryGetValue("environmentId", out var environmentId) ? environmentId?.ToString() : null,
            billingLimits: map.TryGetValue("billingLimits", out var objectRaw47) && objectRaw47 != null
                                    ? Appwrite.Models.BillingLimits.From(map: objectRaw47 is JsonElement jsonObj47 ? jsonObj47.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)objectRaw47)
                                    : null,
            firstAccessedAt: map.TryGetValue("firstAccessedAt", out var firstAccessedAt) ? firstAccessedAt?.ToString() : null,
            mcpAccessedAt: map.TryGetValue("mcpAccessedAt", out var mcpAccessedAt) ? mcpAccessedAt?.ToString() : null,
            oAuth2ServerEnabled: map.TryGetValue("oAuth2ServerEnabled", out var boolRaw50) && boolRaw50 != null
                                        ? (bool?)boolRaw50
                                        : null,
            oAuth2ServerAuthorizationUrl: map.TryGetValue("oAuth2ServerAuthorizationUrl", out var oAuth2ServerAuthorizationUrl) ? oAuth2ServerAuthorizationUrl?.ToString() : null,
            oAuth2ServerScopes: map.TryGetValue("oAuth2ServerScopes", out var arrayRaw52) && arrayRaw52 != null
                                ? arrayRaw52.ConvertToList<string>()
                                : null,
            oAuth2ServerDefaultScopes: map.TryGetValue("oAuth2ServerDefaultScopes", out var arrayRaw53) && arrayRaw53 != null
                                ? arrayRaw53.ConvertToList<string>()
                                : null,
            oAuth2ServerInstallationScopes: map.TryGetValue("oAuth2ServerInstallationScopes", out var arrayRaw54) && arrayRaw54 != null
                                ? arrayRaw54.ConvertToList<string>()
                                : null,
            oAuth2ServerAuthorizationDetailsTypes: map.TryGetValue("oAuth2ServerAuthorizationDetailsTypes", out var arrayRaw55) && arrayRaw55 != null
                                ? arrayRaw55.ConvertToList<string>()
                                : null,
            oAuth2ServerAccessTokenDuration: map.TryGetValue("oAuth2ServerAccessTokenDuration", out var numberRaw56) && numberRaw56 != null
                                    ? Convert.ToInt64(numberRaw56)
                                    : null,
            oAuth2ServerRefreshTokenDuration: map.TryGetValue("oAuth2ServerRefreshTokenDuration", out var numberRaw57) && numberRaw57 != null
                                    ? Convert.ToInt64(numberRaw57)
                                    : null,
            oAuth2ServerPublicAccessTokenDuration: map.TryGetValue("oAuth2ServerPublicAccessTokenDuration", out var numberRaw58) && numberRaw58 != null
                                    ? Convert.ToInt64(numberRaw58)
                                    : null,
            oAuth2ServerPublicRefreshTokenDuration: map.TryGetValue("oAuth2ServerPublicRefreshTokenDuration", out var numberRaw59) && numberRaw59 != null
                                    ? Convert.ToInt64(numberRaw59)
                                    : null,
            oAuth2ServerInstallationAccessTokenDuration: map.TryGetValue("oAuth2ServerInstallationAccessTokenDuration", out var numberRaw60) && numberRaw60 != null
                                    ? Convert.ToInt64(numberRaw60)
                                    : null,
            oAuth2ServerConfidentialPkce: map.TryGetValue("oAuth2ServerConfidentialPkce", out var boolRaw61) && boolRaw61 != null
                                        ? (bool?)boolRaw61
                                        : null,
            oAuth2ServerVerificationUrl: map.TryGetValue("oAuth2ServerVerificationUrl", out var oAuth2ServerVerificationUrl) ? oAuth2ServerVerificationUrl?.ToString() : null,
            oAuth2ServerUserCodeLength: map.TryGetValue("oAuth2ServerUserCodeLength", out var numberRaw63) && numberRaw63 != null
                                    ? Convert.ToInt64(numberRaw63)
                                    : null,
            oAuth2ServerUserCodeFormat: map.TryGetValue("oAuth2ServerUserCodeFormat", out var oAuth2ServerUserCodeFormat) ? oAuth2ServerUserCodeFormat?.ToString() : null,
            oAuth2ServerDeviceCodeDuration: map.TryGetValue("oAuth2ServerDeviceCodeDuration", out var numberRaw65) && numberRaw65 != null
                                    ? Convert.ToInt64(numberRaw65)
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
            { "ldapEnabled", LdapEnabled },
            { "ldapHosts", LdapHosts },
            { "ldapPort", LdapPort },
            { "ldapEncryption", LdapEncryption },
            { "ldapVerification", LdapVerification },
            { "ldapCertificate", LdapCertificate },
            { "ldapTimeout", LdapTimeout },
            { "ldapBaseDn", LdapBaseDn },
            { "ldapBindDn", LdapBindDn },
            { "ldapBindPassword", LdapBindPassword },
            { "ldapUserFilter", LdapUserFilter },
            { "ldapRequiredGroupDn", LdapRequiredGroupDn },
            { "ldapIdAttribute", LdapIdAttribute },
            { "ldapEmailAttribute", LdapEmailAttribute },
            { "ldapNameAttribute", LdapNameAttribute },
            { "ldapPhoneAttribute", LdapPhoneAttribute },
            { "pingCount", PingCount },
            { "pingedAt", PingedAt },
            { "labels", Labels },
            { "prefs", Prefs?.ToMap() },
            { "status", Status },
            { "onboarding", Onboarding },
            { "authMethods", AuthMethods?.Select(it => it.ToMap()).ToList() },
            { "services", Services?.Select(it => it.ToMap()).ToList() },
            { "protocols", Protocols?.Select(it => it.ToMap()).ToList() },
            { "blocks", Blocks?.Select(it => it.ToMap()).ToList() },
            { "consoleAccessedAt", ConsoleAccessedAt },
            { "wafEnabled", WafEnabled },
            { "parentId", ParentId },
            { "environmentId", EnvironmentId },
            { "billingLimits", BillingLimits?.ToMap() },
            { "firstAccessedAt", FirstAccessedAt },
            { "mcpAccessedAt", McpAccessedAt },
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
