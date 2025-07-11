
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

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

        [JsonPropertyName("oAuthProviders")]
        public List<AuthProvider> OAuthProviders { get; private set; }

        [JsonPropertyName("platforms")]
        public List<Platform> Platforms { get; private set; }

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

        [JsonPropertyName("serviceStatusForLocale")]
        public bool ServiceStatusForLocale { get; private set; }

        [JsonPropertyName("serviceStatusForHealth")]
        public bool ServiceStatusForHealth { get; private set; }

        [JsonPropertyName("serviceStatusForStorage")]
        public bool ServiceStatusForStorage { get; private set; }

        [JsonPropertyName("serviceStatusForTeams")]
        public bool ServiceStatusForTeams { get; private set; }

        [JsonPropertyName("serviceStatusForUsers")]
        public bool ServiceStatusForUsers { get; private set; }

        [JsonPropertyName("serviceStatusForSites")]
        public bool ServiceStatusForSites { get; private set; }

        [JsonPropertyName("serviceStatusForFunctions")]
        public bool ServiceStatusForFunctions { get; private set; }

        [JsonPropertyName("serviceStatusForGraphql")]
        public bool ServiceStatusForGraphql { get; private set; }

        [JsonPropertyName("serviceStatusForMessaging")]
        public bool ServiceStatusForMessaging { get; private set; }

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
            List<MockNumber> authMockNumbers,
            bool authSessionAlerts,
            bool authMembershipsUserName,
            bool authMembershipsUserEmail,
            bool authMembershipsMfa,
            List<AuthProvider> oAuthProviders,
            List<Platform> platforms,
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
            bool serviceStatusForLocale,
            bool serviceStatusForHealth,
            bool serviceStatusForStorage,
            bool serviceStatusForTeams,
            bool serviceStatusForUsers,
            bool serviceStatusForSites,
            bool serviceStatusForFunctions,
            bool serviceStatusForGraphql,
            bool serviceStatusForMessaging
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
            AuthMockNumbers = authMockNumbers;
            AuthSessionAlerts = authSessionAlerts;
            AuthMembershipsUserName = authMembershipsUserName;
            AuthMembershipsUserEmail = authMembershipsUserEmail;
            AuthMembershipsMfa = authMembershipsMfa;
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
            ServiceStatusForLocale = serviceStatusForLocale;
            ServiceStatusForHealth = serviceStatusForHealth;
            ServiceStatusForStorage = serviceStatusForStorage;
            ServiceStatusForTeams = serviceStatusForTeams;
            ServiceStatusForUsers = serviceStatusForUsers;
            ServiceStatusForSites = serviceStatusForSites;
            ServiceStatusForFunctions = serviceStatusForFunctions;
            ServiceStatusForGraphql = serviceStatusForGraphql;
            ServiceStatusForMessaging = serviceStatusForMessaging;
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
            authMockNumbers: map["authMockNumbers"] is JsonElement jsonArray21 ? jsonArray21.Deserialize<List<Dictionary<string, object>>>()!.Select(it => MockNumber.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["authMockNumbers"]).Select(it => MockNumber.From(map: it)).ToList(),
            authSessionAlerts: (bool)map["authSessionAlerts"],
            authMembershipsUserName: (bool)map["authMembershipsUserName"],
            authMembershipsUserEmail: (bool)map["authMembershipsUserEmail"],
            authMembershipsMfa: (bool)map["authMembershipsMfa"],
            oAuthProviders: map["oAuthProviders"] is JsonElement jsonArray26 ? jsonArray26.Deserialize<List<Dictionary<string, object>>>()!.Select(it => AuthProvider.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["oAuthProviders"]).Select(it => AuthProvider.From(map: it)).ToList(),
            platforms: map["platforms"] is JsonElement jsonArray27 ? jsonArray27.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Platform.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["platforms"]).Select(it => Platform.From(map: it)).ToList(),
            webhooks: map["webhooks"] is JsonElement jsonArray28 ? jsonArray28.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Webhook.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["webhooks"]).Select(it => Webhook.From(map: it)).ToList(),
            keys: map["keys"] is JsonElement jsonArray29 ? jsonArray29.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Key.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["keys"]).Select(it => Key.From(map: it)).ToList(),
            devKeys: map["devKeys"] is JsonElement jsonArray30 ? jsonArray30.Deserialize<List<Dictionary<string, object>>>()!.Select(it => DevKey.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["devKeys"]).Select(it => DevKey.From(map: it)).ToList(),
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
            serviceStatusForLocale: (bool)map["serviceStatusForLocale"],
            serviceStatusForHealth: (bool)map["serviceStatusForHealth"],
            serviceStatusForStorage: (bool)map["serviceStatusForStorage"],
            serviceStatusForTeams: (bool)map["serviceStatusForTeams"],
            serviceStatusForUsers: (bool)map["serviceStatusForUsers"],
            serviceStatusForSites: (bool)map["serviceStatusForSites"],
            serviceStatusForFunctions: (bool)map["serviceStatusForFunctions"],
            serviceStatusForGraphql: (bool)map["serviceStatusForGraphql"],
            serviceStatusForMessaging: (bool)map["serviceStatusForMessaging"]
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
            { "authMockNumbers", AuthMockNumbers.Select(it => it.ToMap()) },
            { "authSessionAlerts", AuthSessionAlerts },
            { "authMembershipsUserName", AuthMembershipsUserName },
            { "authMembershipsUserEmail", AuthMembershipsUserEmail },
            { "authMembershipsMfa", AuthMembershipsMfa },
            { "oAuthProviders", OAuthProviders.Select(it => it.ToMap()) },
            { "platforms", Platforms.Select(it => it.ToMap()) },
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
            { "serviceStatusForLocale", ServiceStatusForLocale },
            { "serviceStatusForHealth", ServiceStatusForHealth },
            { "serviceStatusForStorage", ServiceStatusForStorage },
            { "serviceStatusForTeams", ServiceStatusForTeams },
            { "serviceStatusForUsers", ServiceStatusForUsers },
            { "serviceStatusForSites", ServiceStatusForSites },
            { "serviceStatusForFunctions", ServiceStatusForFunctions },
            { "serviceStatusForGraphql", ServiceStatusForGraphql },
            { "serviceStatusForMessaging", ServiceStatusForMessaging }
        };
    }
}
