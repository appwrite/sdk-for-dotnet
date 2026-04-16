
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

        [JsonPropertyName("description")]
        public string Description { get; private set; }

        [JsonPropertyName("teamId")]
        public string TeamId { get; private set; }

        [JsonPropertyName("logo")]
        public string Logo { get; private set; }

        [JsonPropertyName("url")]
        public string Url { get; private set; }

        [JsonPropertyName("legalName")]
        public string LegalName { get; private set; }

        [JsonPropertyName("legalCountry")]
        public string LegalCountry { get; private set; }

        [JsonPropertyName("legalState")]
        public string LegalState { get; private set; }

        [JsonPropertyName("legalCity")]
        public string LegalCity { get; private set; }

        [JsonPropertyName("legalAddress")]
        public string LegalAddress { get; private set; }

        [JsonPropertyName("legalTaxId")]
        public string LegalTaxId { get; private set; }

        [JsonPropertyName("authDuration")]
        public long AuthDuration { get; private set; }

        [JsonPropertyName("authLimit")]
        public long AuthLimit { get; private set; }

        [JsonPropertyName("authSessionsLimit")]
        public long AuthSessionsLimit { get; private set; }

        [JsonPropertyName("authPasswordHistory")]
        public long AuthPasswordHistory { get; private set; }

        [JsonPropertyName("authPasswordDictionary")]
        public bool AuthPasswordDictionary { get; private set; }

        [JsonPropertyName("authPersonalDataCheck")]
        public bool AuthPersonalDataCheck { get; private set; }

        [JsonPropertyName("authDisposableEmails")]
        public bool AuthDisposableEmails { get; private set; }

        [JsonPropertyName("authCanonicalEmails")]
        public bool AuthCanonicalEmails { get; private set; }

        [JsonPropertyName("authFreeEmails")]
        public bool AuthFreeEmails { get; private set; }

        [JsonPropertyName("authMockNumbers")]
        public List<MockNumber> AuthMockNumbers { get; private set; }

        [JsonPropertyName("authSessionAlerts")]
        public bool AuthSessionAlerts { get; private set; }

        [JsonPropertyName("authMembershipsUserName")]
        public bool AuthMembershipsUserName { get; private set; }

        [JsonPropertyName("authMembershipsUserEmail")]
        public bool AuthMembershipsUserEmail { get; private set; }

        [JsonPropertyName("authMembershipsMfa")]
        public bool AuthMembershipsMfa { get; private set; }

        [JsonPropertyName("authInvalidateSessions")]
        public bool AuthInvalidateSessions { get; private set; }

        [JsonPropertyName("oAuthProviders")]
        public List<AuthProvider> OAuthProviders { get; private set; }

        [JsonPropertyName("platforms")]
        public List<object> Platforms { get; private set; }

        [JsonPropertyName("webhooks")]
        public List<Webhook> Webhooks { get; private set; }

        [JsonPropertyName("keys")]
        public List<Key> Keys { get; private set; }

        [JsonPropertyName("devKeys")]
        public List<DevKey> DevKeys { get; private set; }

        [JsonPropertyName("smtpEnabled")]
        public bool SmtpEnabled { get; private set; }

        [JsonPropertyName("smtpSenderName")]
        public string SmtpSenderName { get; private set; }

        [JsonPropertyName("smtpSenderEmail")]
        public string SmtpSenderEmail { get; private set; }

        [JsonPropertyName("smtpReplyTo")]
        public string SmtpReplyTo { get; private set; }

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

        [JsonPropertyName("authEmailPassword")]
        public bool AuthEmailPassword { get; private set; }

        [JsonPropertyName("authUsersAuthMagicURL")]
        public bool AuthUsersAuthMagicURL { get; private set; }

        [JsonPropertyName("authEmailOtp")]
        public bool AuthEmailOtp { get; private set; }

        [JsonPropertyName("authAnonymous")]
        public bool AuthAnonymous { get; private set; }

        [JsonPropertyName("authInvites")]
        public bool AuthInvites { get; private set; }

        [JsonPropertyName("authJWT")]
        public bool AuthJWT { get; private set; }

        [JsonPropertyName("authPhone")]
        public bool AuthPhone { get; private set; }

        [JsonPropertyName("serviceStatusForAccount")]
        public bool ServiceStatusForAccount { get; private set; }

        [JsonPropertyName("serviceStatusForAvatars")]
        public bool ServiceStatusForAvatars { get; private set; }

        [JsonPropertyName("serviceStatusForDatabases")]
        public bool ServiceStatusForDatabases { get; private set; }

        [JsonPropertyName("serviceStatusForTablesdb")]
        public bool ServiceStatusForTablesdb { get; private set; }

        [JsonPropertyName("serviceStatusForLocale")]
        public bool ServiceStatusForLocale { get; private set; }

        [JsonPropertyName("serviceStatusForHealth")]
        public bool ServiceStatusForHealth { get; private set; }

        [JsonPropertyName("serviceStatusForProject")]
        public bool ServiceStatusForProject { get; private set; }

        [JsonPropertyName("serviceStatusForStorage")]
        public bool ServiceStatusForStorage { get; private set; }

        [JsonPropertyName("serviceStatusForTeams")]
        public bool ServiceStatusForTeams { get; private set; }

        [JsonPropertyName("serviceStatusForUsers")]
        public bool ServiceStatusForUsers { get; private set; }

        [JsonPropertyName("serviceStatusForVcs")]
        public bool ServiceStatusForVcs { get; private set; }

        [JsonPropertyName("serviceStatusForSites")]
        public bool ServiceStatusForSites { get; private set; }

        [JsonPropertyName("serviceStatusForFunctions")]
        public bool ServiceStatusForFunctions { get; private set; }

        [JsonPropertyName("serviceStatusForProxy")]
        public bool ServiceStatusForProxy { get; private set; }

        [JsonPropertyName("serviceStatusForGraphql")]
        public bool ServiceStatusForGraphql { get; private set; }

        [JsonPropertyName("serviceStatusForMigrations")]
        public bool ServiceStatusForMigrations { get; private set; }

        [JsonPropertyName("serviceStatusForMessaging")]
        public bool ServiceStatusForMessaging { get; private set; }

        [JsonPropertyName("protocolStatusForRest")]
        public bool ProtocolStatusForRest { get; private set; }

        [JsonPropertyName("protocolStatusForGraphql")]
        public bool ProtocolStatusForGraphql { get; private set; }

        [JsonPropertyName("protocolStatusForWebsocket")]
        public bool ProtocolStatusForWebsocket { get; private set; }

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
            string description,
            string teamId,
            string logo,
            string url,
            string legalName,
            string legalCountry,
            string legalState,
            string legalCity,
            string legalAddress,
            string legalTaxId,
            long authDuration,
            long authLimit,
            long authSessionsLimit,
            long authPasswordHistory,
            bool authPasswordDictionary,
            bool authPersonalDataCheck,
            bool authDisposableEmails,
            bool authCanonicalEmails,
            bool authFreeEmails,
            List<MockNumber> authMockNumbers,
            bool authSessionAlerts,
            bool authMembershipsUserName,
            bool authMembershipsUserEmail,
            bool authMembershipsMfa,
            bool authInvalidateSessions,
            List<AuthProvider> oAuthProviders,
            List<object> platforms,
            List<Webhook> webhooks,
            List<Key> keys,
            List<DevKey> devKeys,
            bool smtpEnabled,
            string smtpSenderName,
            string smtpSenderEmail,
            string smtpReplyTo,
            string smtpHost,
            long smtpPort,
            string smtpUsername,
            string smtpPassword,
            string smtpSecure,
            long pingCount,
            string pingedAt,
            List<string> labels,
            string status,
            bool authEmailPassword,
            bool authUsersAuthMagicURL,
            bool authEmailOtp,
            bool authAnonymous,
            bool authInvites,
            bool authJWT,
            bool authPhone,
            bool serviceStatusForAccount,
            bool serviceStatusForAvatars,
            bool serviceStatusForDatabases,
            bool serviceStatusForTablesdb,
            bool serviceStatusForLocale,
            bool serviceStatusForHealth,
            bool serviceStatusForProject,
            bool serviceStatusForStorage,
            bool serviceStatusForTeams,
            bool serviceStatusForUsers,
            bool serviceStatusForVcs,
            bool serviceStatusForSites,
            bool serviceStatusForFunctions,
            bool serviceStatusForProxy,
            bool serviceStatusForGraphql,
            bool serviceStatusForMigrations,
            bool serviceStatusForMessaging,
            bool protocolStatusForRest,
            bool protocolStatusForGraphql,
            bool protocolStatusForWebsocket,
            string region,
            BillingLimits billingLimits,
            List<Block> blocks,
            string consoleAccessedAt
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Description = description;
            TeamId = teamId;
            Logo = logo;
            Url = url;
            LegalName = legalName;
            LegalCountry = legalCountry;
            LegalState = legalState;
            LegalCity = legalCity;
            LegalAddress = legalAddress;
            LegalTaxId = legalTaxId;
            AuthDuration = authDuration;
            AuthLimit = authLimit;
            AuthSessionsLimit = authSessionsLimit;
            AuthPasswordHistory = authPasswordHistory;
            AuthPasswordDictionary = authPasswordDictionary;
            AuthPersonalDataCheck = authPersonalDataCheck;
            AuthDisposableEmails = authDisposableEmails;
            AuthCanonicalEmails = authCanonicalEmails;
            AuthFreeEmails = authFreeEmails;
            AuthMockNumbers = authMockNumbers;
            AuthSessionAlerts = authSessionAlerts;
            AuthMembershipsUserName = authMembershipsUserName;
            AuthMembershipsUserEmail = authMembershipsUserEmail;
            AuthMembershipsMfa = authMembershipsMfa;
            AuthInvalidateSessions = authInvalidateSessions;
            OAuthProviders = oAuthProviders;
            Platforms = platforms;
            Webhooks = webhooks;
            Keys = keys;
            DevKeys = devKeys;
            SmtpEnabled = smtpEnabled;
            SmtpSenderName = smtpSenderName;
            SmtpSenderEmail = smtpSenderEmail;
            SmtpReplyTo = smtpReplyTo;
            SmtpHost = smtpHost;
            SmtpPort = smtpPort;
            SmtpUsername = smtpUsername;
            SmtpPassword = smtpPassword;
            SmtpSecure = smtpSecure;
            PingCount = pingCount;
            PingedAt = pingedAt;
            Labels = labels;
            Status = status;
            AuthEmailPassword = authEmailPassword;
            AuthUsersAuthMagicURL = authUsersAuthMagicURL;
            AuthEmailOtp = authEmailOtp;
            AuthAnonymous = authAnonymous;
            AuthInvites = authInvites;
            AuthJWT = authJWT;
            AuthPhone = authPhone;
            ServiceStatusForAccount = serviceStatusForAccount;
            ServiceStatusForAvatars = serviceStatusForAvatars;
            ServiceStatusForDatabases = serviceStatusForDatabases;
            ServiceStatusForTablesdb = serviceStatusForTablesdb;
            ServiceStatusForLocale = serviceStatusForLocale;
            ServiceStatusForHealth = serviceStatusForHealth;
            ServiceStatusForProject = serviceStatusForProject;
            ServiceStatusForStorage = serviceStatusForStorage;
            ServiceStatusForTeams = serviceStatusForTeams;
            ServiceStatusForUsers = serviceStatusForUsers;
            ServiceStatusForVcs = serviceStatusForVcs;
            ServiceStatusForSites = serviceStatusForSites;
            ServiceStatusForFunctions = serviceStatusForFunctions;
            ServiceStatusForProxy = serviceStatusForProxy;
            ServiceStatusForGraphql = serviceStatusForGraphql;
            ServiceStatusForMigrations = serviceStatusForMigrations;
            ServiceStatusForMessaging = serviceStatusForMessaging;
            ProtocolStatusForRest = protocolStatusForRest;
            ProtocolStatusForGraphql = protocolStatusForGraphql;
            ProtocolStatusForWebsocket = protocolStatusForWebsocket;
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
            description: map["description"].ToString(),
            teamId: map["teamId"].ToString(),
            logo: map["logo"].ToString(),
            url: map["url"].ToString(),
            legalName: map["legalName"].ToString(),
            legalCountry: map["legalCountry"].ToString(),
            legalState: map["legalState"].ToString(),
            legalCity: map["legalCity"].ToString(),
            legalAddress: map["legalAddress"].ToString(),
            legalTaxId: map["legalTaxId"].ToString(),
            authDuration: Convert.ToInt64(map["authDuration"]),
            authLimit: Convert.ToInt64(map["authLimit"]),
            authSessionsLimit: Convert.ToInt64(map["authSessionsLimit"]),
            authPasswordHistory: Convert.ToInt64(map["authPasswordHistory"]),
            authPasswordDictionary: (bool)map["authPasswordDictionary"],
            authPersonalDataCheck: (bool)map["authPersonalDataCheck"],
            authDisposableEmails: (bool)map["authDisposableEmails"],
            authCanonicalEmails: (bool)map["authCanonicalEmails"],
            authFreeEmails: (bool)map["authFreeEmails"],
            authMockNumbers: map["authMockNumbers"].ConvertToList<Dictionary<string, object>>().Select(it => MockNumber.From(map: it)).ToList(),
            authSessionAlerts: (bool)map["authSessionAlerts"],
            authMembershipsUserName: (bool)map["authMembershipsUserName"],
            authMembershipsUserEmail: (bool)map["authMembershipsUserEmail"],
            authMembershipsMfa: (bool)map["authMembershipsMfa"],
            authInvalidateSessions: (bool)map["authInvalidateSessions"],
            oAuthProviders: map["oAuthProviders"].ConvertToList<Dictionary<string, object>>().Select(it => AuthProvider.From(map: it)).ToList(),
            platforms: map["platforms"].ConvertToList<object>(),
            webhooks: map["webhooks"].ConvertToList<Dictionary<string, object>>().Select(it => Webhook.From(map: it)).ToList(),
            keys: map["keys"].ConvertToList<Dictionary<string, object>>().Select(it => Key.From(map: it)).ToList(),
            devKeys: map["devKeys"].ConvertToList<Dictionary<string, object>>().Select(it => DevKey.From(map: it)).ToList(),
            smtpEnabled: (bool)map["smtpEnabled"],
            smtpSenderName: map["smtpSenderName"].ToString(),
            smtpSenderEmail: map["smtpSenderEmail"].ToString(),
            smtpReplyTo: map["smtpReplyTo"].ToString(),
            smtpHost: map["smtpHost"].ToString(),
            smtpPort: Convert.ToInt64(map["smtpPort"]),
            smtpUsername: map["smtpUsername"].ToString(),
            smtpPassword: map["smtpPassword"].ToString(),
            smtpSecure: map["smtpSecure"].ToString(),
            pingCount: Convert.ToInt64(map["pingCount"]),
            pingedAt: map["pingedAt"].ToString(),
            labels: map["labels"].ConvertToList<string>(),
            status: map["status"].ToString(),
            authEmailPassword: (bool)map["authEmailPassword"],
            authUsersAuthMagicURL: (bool)map["authUsersAuthMagicURL"],
            authEmailOtp: (bool)map["authEmailOtp"],
            authAnonymous: (bool)map["authAnonymous"],
            authInvites: (bool)map["authInvites"],
            authJWT: (bool)map["authJWT"],
            authPhone: (bool)map["authPhone"],
            serviceStatusForAccount: (bool)map["serviceStatusForAccount"],
            serviceStatusForAvatars: (bool)map["serviceStatusForAvatars"],
            serviceStatusForDatabases: (bool)map["serviceStatusForDatabases"],
            serviceStatusForTablesdb: (bool)map["serviceStatusForTablesdb"],
            serviceStatusForLocale: (bool)map["serviceStatusForLocale"],
            serviceStatusForHealth: (bool)map["serviceStatusForHealth"],
            serviceStatusForProject: (bool)map["serviceStatusForProject"],
            serviceStatusForStorage: (bool)map["serviceStatusForStorage"],
            serviceStatusForTeams: (bool)map["serviceStatusForTeams"],
            serviceStatusForUsers: (bool)map["serviceStatusForUsers"],
            serviceStatusForVcs: (bool)map["serviceStatusForVcs"],
            serviceStatusForSites: (bool)map["serviceStatusForSites"],
            serviceStatusForFunctions: (bool)map["serviceStatusForFunctions"],
            serviceStatusForProxy: (bool)map["serviceStatusForProxy"],
            serviceStatusForGraphql: (bool)map["serviceStatusForGraphql"],
            serviceStatusForMigrations: (bool)map["serviceStatusForMigrations"],
            serviceStatusForMessaging: (bool)map["serviceStatusForMessaging"],
            protocolStatusForRest: (bool)map["protocolStatusForRest"],
            protocolStatusForGraphql: (bool)map["protocolStatusForGraphql"],
            protocolStatusForWebsocket: (bool)map["protocolStatusForWebsocket"],
            region: map["region"].ToString(),
            billingLimits: BillingLimits.From(map: map["billingLimits"] is JsonElement jsonObj76 ? jsonObj76.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["billingLimits"]),
            blocks: map["blocks"].ConvertToList<Dictionary<string, object>>().Select(it => Block.From(map: it)).ToList(),
            consoleAccessedAt: map["consoleAccessedAt"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "description", Description },
            { "teamId", TeamId },
            { "logo", Logo },
            { "url", Url },
            { "legalName", LegalName },
            { "legalCountry", LegalCountry },
            { "legalState", LegalState },
            { "legalCity", LegalCity },
            { "legalAddress", LegalAddress },
            { "legalTaxId", LegalTaxId },
            { "authDuration", AuthDuration },
            { "authLimit", AuthLimit },
            { "authSessionsLimit", AuthSessionsLimit },
            { "authPasswordHistory", AuthPasswordHistory },
            { "authPasswordDictionary", AuthPasswordDictionary },
            { "authPersonalDataCheck", AuthPersonalDataCheck },
            { "authDisposableEmails", AuthDisposableEmails },
            { "authCanonicalEmails", AuthCanonicalEmails },
            { "authFreeEmails", AuthFreeEmails },
            { "authMockNumbers", AuthMockNumbers.Select(it => it.ToMap()) },
            { "authSessionAlerts", AuthSessionAlerts },
            { "authMembershipsUserName", AuthMembershipsUserName },
            { "authMembershipsUserEmail", AuthMembershipsUserEmail },
            { "authMembershipsMfa", AuthMembershipsMfa },
            { "authInvalidateSessions", AuthInvalidateSessions },
            { "oAuthProviders", OAuthProviders.Select(it => it.ToMap()) },
            { "platforms", Platforms },
            { "webhooks", Webhooks.Select(it => it.ToMap()) },
            { "keys", Keys.Select(it => it.ToMap()) },
            { "devKeys", DevKeys.Select(it => it.ToMap()) },
            { "smtpEnabled", SmtpEnabled },
            { "smtpSenderName", SmtpSenderName },
            { "smtpSenderEmail", SmtpSenderEmail },
            { "smtpReplyTo", SmtpReplyTo },
            { "smtpHost", SmtpHost },
            { "smtpPort", SmtpPort },
            { "smtpUsername", SmtpUsername },
            { "smtpPassword", SmtpPassword },
            { "smtpSecure", SmtpSecure },
            { "pingCount", PingCount },
            { "pingedAt", PingedAt },
            { "labels", Labels },
            { "status", Status },
            { "authEmailPassword", AuthEmailPassword },
            { "authUsersAuthMagicURL", AuthUsersAuthMagicURL },
            { "authEmailOtp", AuthEmailOtp },
            { "authAnonymous", AuthAnonymous },
            { "authInvites", AuthInvites },
            { "authJWT", AuthJWT },
            { "authPhone", AuthPhone },
            { "serviceStatusForAccount", ServiceStatusForAccount },
            { "serviceStatusForAvatars", ServiceStatusForAvatars },
            { "serviceStatusForDatabases", ServiceStatusForDatabases },
            { "serviceStatusForTablesdb", ServiceStatusForTablesdb },
            { "serviceStatusForLocale", ServiceStatusForLocale },
            { "serviceStatusForHealth", ServiceStatusForHealth },
            { "serviceStatusForProject", ServiceStatusForProject },
            { "serviceStatusForStorage", ServiceStatusForStorage },
            { "serviceStatusForTeams", ServiceStatusForTeams },
            { "serviceStatusForUsers", ServiceStatusForUsers },
            { "serviceStatusForVcs", ServiceStatusForVcs },
            { "serviceStatusForSites", ServiceStatusForSites },
            { "serviceStatusForFunctions", ServiceStatusForFunctions },
            { "serviceStatusForProxy", ServiceStatusForProxy },
            { "serviceStatusForGraphql", ServiceStatusForGraphql },
            { "serviceStatusForMigrations", ServiceStatusForMigrations },
            { "serviceStatusForMessaging", ServiceStatusForMessaging },
            { "protocolStatusForRest", ProtocolStatusForRest },
            { "protocolStatusForGraphql", ProtocolStatusForGraphql },
            { "protocolStatusForWebsocket", ProtocolStatusForWebsocket },
            { "region", Region },
            { "billingLimits", BillingLimits.ToMap() },
            { "blocks", Blocks.Select(it => it.ToMap()) },
            { "consoleAccessedAt", ConsoleAccessedAt }
        };
    }
}
