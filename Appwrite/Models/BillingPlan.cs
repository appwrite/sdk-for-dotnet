
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class BillingPlan
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("desc")]
        public string Desc { get; private set; }

        [JsonPropertyName("order")]
        public long Order { get; private set; }

        [JsonPropertyName("price")]
        public double Price { get; private set; }

        [JsonPropertyName("trial")]
        public long Trial { get; private set; }

        [JsonPropertyName("bandwidth")]
        public long Bandwidth { get; private set; }

        [JsonPropertyName("storage")]
        public long Storage { get; private set; }

        [JsonPropertyName("imageTransformations")]
        public long ImageTransformations { get; private set; }

        [JsonPropertyName("screenshotsGenerated")]
        public long ScreenshotsGenerated { get; private set; }

        [JsonPropertyName("members")]
        public long? Members { get; private set; }

        [JsonPropertyName("webhooks")]
        public long Webhooks { get; private set; }

        [JsonPropertyName("wafRules")]
        public long WafRules { get; private set; }

        [JsonPropertyName("projects")]
        public long Projects { get; private set; }

        [JsonPropertyName("platforms")]
        public long Platforms { get; private set; }

        [JsonPropertyName("users")]
        public long Users { get; private set; }

        [JsonPropertyName("teams")]
        public long Teams { get; private set; }

        [JsonPropertyName("databases")]
        public long Databases { get; private set; }

        [JsonPropertyName("databasesReads")]
        public long DatabasesReads { get; private set; }

        [JsonPropertyName("databasesWrites")]
        public long DatabasesWrites { get; private set; }

        [JsonPropertyName("databasesBatchSize")]
        public long DatabasesBatchSize { get; private set; }

        [JsonPropertyName("buckets")]
        public long Buckets { get; private set; }

        [JsonPropertyName("fileSize")]
        public long FileSize { get; private set; }

        [JsonPropertyName("functions")]
        public long Functions { get; private set; }

        [JsonPropertyName("sites")]
        public long Sites { get; private set; }

        [JsonPropertyName("executions")]
        public long Executions { get; private set; }

        [JsonPropertyName("executionsRetentionCount")]
        public long ExecutionsRetentionCount { get; private set; }

        [JsonPropertyName("GBHours")]
        public long GBHours { get; private set; }

        [JsonPropertyName("realtime")]
        public long Realtime { get; private set; }

        [JsonPropertyName("realtimeMessages")]
        public long RealtimeMessages { get; private set; }

        [JsonPropertyName("messages")]
        public long Messages { get; private set; }

        [JsonPropertyName("topics")]
        public long Topics { get; private set; }

        [JsonPropertyName("authPhone")]
        public long AuthPhone { get; private set; }

        [JsonPropertyName("domains")]
        public long Domains { get; private set; }

        [JsonPropertyName("activityLogs")]
        public long? ActivityLogs { get; private set; }

        [JsonPropertyName("usageLogs")]
        public long UsageLogs { get; private set; }

        [JsonPropertyName("usageLogsIntervals")]
        public List<string>? UsageLogsIntervals { get; private set; }

        [JsonPropertyName("projectInactivityDays")]
        public long ProjectInactivityDays { get; private set; }

        [JsonPropertyName("alertLimit")]
        public long AlertLimit { get; private set; }

        [JsonPropertyName("usage")]
        public UsageBillingPlan Usage { get; private set; }

        [JsonPropertyName("addons")]
        public BillingPlanAddon Addons { get; private set; }

        [JsonPropertyName("budgetCapEnabled")]
        public bool BudgetCapEnabled { get; private set; }

        [JsonPropertyName("customSmtp")]
        public bool CustomSmtp { get; private set; }

        [JsonPropertyName("emailBranding")]
        public bool EmailBranding { get; private set; }

        [JsonPropertyName("requiresPaymentMethod")]
        public bool RequiresPaymentMethod { get; private set; }

        [JsonPropertyName("requiresBillingAddress")]
        public bool RequiresBillingAddress { get; private set; }

        [JsonPropertyName("isAvailable")]
        public bool IsAvailable { get; private set; }

        [JsonPropertyName("selfService")]
        public bool SelfService { get; private set; }

        [JsonPropertyName("premiumSupport")]
        public bool PremiumSupport { get; private set; }

        [JsonPropertyName("budgeting")]
        public bool Budgeting { get; private set; }

        [JsonPropertyName("supportsMockNumbers")]
        public bool SupportsMockNumbers { get; private set; }

        [JsonPropertyName("supportsOrganizationRoles")]
        public bool SupportsOrganizationRoles { get; private set; }

        [JsonPropertyName("supportsCredits")]
        public bool SupportsCredits { get; private set; }

        [JsonPropertyName("supportsDisposableEmailValidation")]
        public bool SupportsDisposableEmailValidation { get; private set; }

        [JsonPropertyName("supportsCanonicalEmailValidation")]
        public bool SupportsCanonicalEmailValidation { get; private set; }

        [JsonPropertyName("supportsFreeEmailValidation")]
        public bool SupportsFreeEmailValidation { get; private set; }

        [JsonPropertyName("supportsCorporateEmailValidation")]
        public bool SupportsCorporateEmailValidation { get; private set; }

        [JsonPropertyName("supportsProjectSpecificRoles")]
        public bool SupportsProjectSpecificRoles { get; private set; }

        [JsonPropertyName("backupsEnabled")]
        public bool? BackupsEnabled { get; private set; }

        [JsonPropertyName("usagePerProject")]
        public bool UsagePerProject { get; private set; }

        [JsonPropertyName("supportedAddons")]
        public BillingPlanSupportedAddons SupportedAddons { get; private set; }

        [JsonPropertyName("backupPolicies")]
        public long? BackupPolicies { get; private set; }

        [JsonPropertyName("deploymentSize")]
        public long DeploymentSize { get; private set; }

        [JsonPropertyName("buildSize")]
        public long BuildSize { get; private set; }

        [JsonPropertyName("databasesAllowEncrypt")]
        public bool DatabasesAllowEncrypt { get; private set; }

        [JsonPropertyName("limits")]
        public BillingPlanLimits? Limits { get; private set; }

        [JsonPropertyName("group")]
        public Appwrite.Enums.BillingPlanGroup Group { get; private set; }

        [JsonPropertyName("program")]
        public Program? Program { get; private set; }

        [JsonPropertyName("dedicatedDatabases")]
        public BillingPlanDedicatedDatabaseLimits? DedicatedDatabases { get; private set; }

        public BillingPlan(
            string id,
            string name,
            string desc,
            long order,
            double price,
            long trial,
            long bandwidth,
            long storage,
            long imageTransformations,
            long screenshotsGenerated,
            long? members,
            long webhooks,
            long wafRules,
            long projects,
            long platforms,
            long users,
            long teams,
            long databases,
            long databasesReads,
            long databasesWrites,
            long databasesBatchSize,
            long buckets,
            long fileSize,
            long functions,
            long sites,
            long executions,
            long executionsRetentionCount,
            long gBHours,
            long realtime,
            long realtimeMessages,
            long messages,
            long topics,
            long authPhone,
            long domains,
            long? activityLogs,
            long usageLogs,
            List<string>? usageLogsIntervals,
            long projectInactivityDays,
            long alertLimit,
            UsageBillingPlan usage,
            BillingPlanAddon addons,
            bool budgetCapEnabled,
            bool customSmtp,
            bool emailBranding,
            bool requiresPaymentMethod,
            bool requiresBillingAddress,
            bool isAvailable,
            bool selfService,
            bool premiumSupport,
            bool budgeting,
            bool supportsMockNumbers,
            bool supportsOrganizationRoles,
            bool supportsCredits,
            bool supportsDisposableEmailValidation,
            bool supportsCanonicalEmailValidation,
            bool supportsFreeEmailValidation,
            bool supportsCorporateEmailValidation,
            bool supportsProjectSpecificRoles,
            bool? backupsEnabled,
            bool usagePerProject,
            BillingPlanSupportedAddons supportedAddons,
            long? backupPolicies,
            long deploymentSize,
            long buildSize,
            bool databasesAllowEncrypt,
            BillingPlanLimits? limits,
            Appwrite.Enums.BillingPlanGroup @group,
            Program? program,
            BillingPlanDedicatedDatabaseLimits? dedicatedDatabases
        )
        {
            Id = id;
            Name = name;
            Desc = desc;
            Order = order;
            Price = price;
            Trial = trial;
            Bandwidth = bandwidth;
            Storage = storage;
            ImageTransformations = imageTransformations;
            ScreenshotsGenerated = screenshotsGenerated;
            Members = members;
            Webhooks = webhooks;
            WafRules = wafRules;
            Projects = projects;
            Platforms = platforms;
            Users = users;
            Teams = teams;
            Databases = databases;
            DatabasesReads = databasesReads;
            DatabasesWrites = databasesWrites;
            DatabasesBatchSize = databasesBatchSize;
            Buckets = buckets;
            FileSize = fileSize;
            Functions = functions;
            Sites = sites;
            Executions = executions;
            ExecutionsRetentionCount = executionsRetentionCount;
            GBHours = gBHours;
            Realtime = realtime;
            RealtimeMessages = realtimeMessages;
            Messages = messages;
            Topics = topics;
            AuthPhone = authPhone;
            Domains = domains;
            ActivityLogs = activityLogs;
            UsageLogs = usageLogs;
            UsageLogsIntervals = usageLogsIntervals;
            ProjectInactivityDays = projectInactivityDays;
            AlertLimit = alertLimit;
            Usage = usage;
            Addons = addons;
            BudgetCapEnabled = budgetCapEnabled;
            CustomSmtp = customSmtp;
            EmailBranding = emailBranding;
            RequiresPaymentMethod = requiresPaymentMethod;
            RequiresBillingAddress = requiresBillingAddress;
            IsAvailable = isAvailable;
            SelfService = selfService;
            PremiumSupport = premiumSupport;
            Budgeting = budgeting;
            SupportsMockNumbers = supportsMockNumbers;
            SupportsOrganizationRoles = supportsOrganizationRoles;
            SupportsCredits = supportsCredits;
            SupportsDisposableEmailValidation = supportsDisposableEmailValidation;
            SupportsCanonicalEmailValidation = supportsCanonicalEmailValidation;
            SupportsFreeEmailValidation = supportsFreeEmailValidation;
            SupportsCorporateEmailValidation = supportsCorporateEmailValidation;
            SupportsProjectSpecificRoles = supportsProjectSpecificRoles;
            BackupsEnabled = backupsEnabled;
            UsagePerProject = usagePerProject;
            SupportedAddons = supportedAddons;
            BackupPolicies = backupPolicies;
            DeploymentSize = deploymentSize;
            BuildSize = buildSize;
            DatabasesAllowEncrypt = databasesAllowEncrypt;
            Limits = limits;
            Group = @group;
            Program = program;
            DedicatedDatabases = dedicatedDatabases;
        }

        public static BillingPlan From(Dictionary<string, object> map) => new BillingPlan(
            id: map["$id"].ToString(),
            name: map["name"].ToString(),
            desc: map["desc"].ToString(),
            order: Convert.ToInt64(map["order"]),
            price: Convert.ToDouble(map["price"]),
            trial: Convert.ToInt64(map["trial"]),
            bandwidth: Convert.ToInt64(map["bandwidth"]),
            storage: Convert.ToInt64(map["storage"]),
            imageTransformations: Convert.ToInt64(map["imageTransformations"]),
            screenshotsGenerated: Convert.ToInt64(map["screenshotsGenerated"]),
            members: map.TryGetValue("members", out var numberRaw11) && numberRaw11 != null
                                    ? Convert.ToInt64(numberRaw11)
                                    : null,
            webhooks: Convert.ToInt64(map["webhooks"]),
            wafRules: Convert.ToInt64(map["wafRules"]),
            projects: Convert.ToInt64(map["projects"]),
            platforms: Convert.ToInt64(map["platforms"]),
            users: Convert.ToInt64(map["users"]),
            teams: Convert.ToInt64(map["teams"]),
            databases: Convert.ToInt64(map["databases"]),
            databasesReads: Convert.ToInt64(map["databasesReads"]),
            databasesWrites: Convert.ToInt64(map["databasesWrites"]),
            databasesBatchSize: Convert.ToInt64(map["databasesBatchSize"]),
            buckets: Convert.ToInt64(map["buckets"]),
            fileSize: Convert.ToInt64(map["fileSize"]),
            functions: Convert.ToInt64(map["functions"]),
            sites: Convert.ToInt64(map["sites"]),
            executions: Convert.ToInt64(map["executions"]),
            executionsRetentionCount: Convert.ToInt64(map["executionsRetentionCount"]),
            gBHours: Convert.ToInt64(map["GBHours"]),
            realtime: Convert.ToInt64(map["realtime"]),
            realtimeMessages: Convert.ToInt64(map["realtimeMessages"]),
            messages: Convert.ToInt64(map["messages"]),
            topics: Convert.ToInt64(map["topics"]),
            authPhone: Convert.ToInt64(map["authPhone"]),
            domains: Convert.ToInt64(map["domains"]),
            activityLogs: map.TryGetValue("activityLogs", out var numberRaw35) && numberRaw35 != null
                                    ? Convert.ToInt64(numberRaw35)
                                    : null,
            usageLogs: Convert.ToInt64(map["usageLogs"]),
            usageLogsIntervals: map.TryGetValue("usageLogsIntervals", out var arrayRaw37) && arrayRaw37 != null
                                ? arrayRaw37.ConvertToList<string>()
                                : null,
            projectInactivityDays: Convert.ToInt64(map["projectInactivityDays"]),
            alertLimit: Convert.ToInt64(map["alertLimit"]),
            usage: Appwrite.Models.UsageBillingPlan.From(map: map["usage"] is JsonElement jsonObj40 ? jsonObj40.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["usage"]),
            addons: Appwrite.Models.BillingPlanAddon.From(map: map["addons"] is JsonElement jsonObj41 ? jsonObj41.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["addons"]),
            budgetCapEnabled: (bool)map["budgetCapEnabled"],
            customSmtp: (bool)map["customSmtp"],
            emailBranding: (bool)map["emailBranding"],
            requiresPaymentMethod: (bool)map["requiresPaymentMethod"],
            requiresBillingAddress: (bool)map["requiresBillingAddress"],
            isAvailable: (bool)map["isAvailable"],
            selfService: (bool)map["selfService"],
            premiumSupport: (bool)map["premiumSupport"],
            budgeting: (bool)map["budgeting"],
            supportsMockNumbers: (bool)map["supportsMockNumbers"],
            supportsOrganizationRoles: (bool)map["supportsOrganizationRoles"],
            supportsCredits: (bool)map["supportsCredits"],
            supportsDisposableEmailValidation: (bool)map["supportsDisposableEmailValidation"],
            supportsCanonicalEmailValidation: (bool)map["supportsCanonicalEmailValidation"],
            supportsFreeEmailValidation: (bool)map["supportsFreeEmailValidation"],
            supportsCorporateEmailValidation: (bool)map["supportsCorporateEmailValidation"],
            supportsProjectSpecificRoles: (bool)map["supportsProjectSpecificRoles"],
            backupsEnabled: map.TryGetValue("backupsEnabled", out var boolRaw59) && boolRaw59 != null
                                        ? (bool?)boolRaw59
                                        : null,
            usagePerProject: (bool)map["usagePerProject"],
            supportedAddons: Appwrite.Models.BillingPlanSupportedAddons.From(map: map["supportedAddons"] is JsonElement jsonObj61 ? jsonObj61.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["supportedAddons"]),
            backupPolicies: map.TryGetValue("backupPolicies", out var numberRaw62) && numberRaw62 != null
                                    ? Convert.ToInt64(numberRaw62)
                                    : null,
            deploymentSize: Convert.ToInt64(map["deploymentSize"]),
            buildSize: Convert.ToInt64(map["buildSize"]),
            databasesAllowEncrypt: (bool)map["databasesAllowEncrypt"],
            limits: map.TryGetValue("limits", out var objectRaw66) && objectRaw66 != null
                                    ? Appwrite.Models.BillingPlanLimits.From(map: objectRaw66 is JsonElement jsonObj66 ? jsonObj66.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)objectRaw66)
                                    : null,
            @group: new Appwrite.Enums.BillingPlanGroup(map["group"].ToString()!),
            program: map.TryGetValue("program", out var objectRaw68) && objectRaw68 != null
                                    ? Appwrite.Models.Program.From(map: objectRaw68 is JsonElement jsonObj68 ? jsonObj68.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)objectRaw68)
                                    : null,
            dedicatedDatabases: map.TryGetValue("dedicatedDatabases", out var objectRaw69) && objectRaw69 != null
                                    ? Appwrite.Models.BillingPlanDedicatedDatabaseLimits.From(map: objectRaw69 is JsonElement jsonObj69 ? jsonObj69.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)objectRaw69)
                                    : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "name", Name },
            { "desc", Desc },
            { "order", Order },
            { "price", Price },
            { "trial", Trial },
            { "bandwidth", Bandwidth },
            { "storage", Storage },
            { "imageTransformations", ImageTransformations },
            { "screenshotsGenerated", ScreenshotsGenerated },
            { "members", Members },
            { "webhooks", Webhooks },
            { "wafRules", WafRules },
            { "projects", Projects },
            { "platforms", Platforms },
            { "users", Users },
            { "teams", Teams },
            { "databases", Databases },
            { "databasesReads", DatabasesReads },
            { "databasesWrites", DatabasesWrites },
            { "databasesBatchSize", DatabasesBatchSize },
            { "buckets", Buckets },
            { "fileSize", FileSize },
            { "functions", Functions },
            { "sites", Sites },
            { "executions", Executions },
            { "executionsRetentionCount", ExecutionsRetentionCount },
            { "GBHours", GBHours },
            { "realtime", Realtime },
            { "realtimeMessages", RealtimeMessages },
            { "messages", Messages },
            { "topics", Topics },
            { "authPhone", AuthPhone },
            { "domains", Domains },
            { "activityLogs", ActivityLogs },
            { "usageLogs", UsageLogs },
            { "usageLogsIntervals", UsageLogsIntervals },
            { "projectInactivityDays", ProjectInactivityDays },
            { "alertLimit", AlertLimit },
            { "usage", Usage?.ToMap() },
            { "addons", Addons?.ToMap() },
            { "budgetCapEnabled", BudgetCapEnabled },
            { "customSmtp", CustomSmtp },
            { "emailBranding", EmailBranding },
            { "requiresPaymentMethod", RequiresPaymentMethod },
            { "requiresBillingAddress", RequiresBillingAddress },
            { "isAvailable", IsAvailable },
            { "selfService", SelfService },
            { "premiumSupport", PremiumSupport },
            { "budgeting", Budgeting },
            { "supportsMockNumbers", SupportsMockNumbers },
            { "supportsOrganizationRoles", SupportsOrganizationRoles },
            { "supportsCredits", SupportsCredits },
            { "supportsDisposableEmailValidation", SupportsDisposableEmailValidation },
            { "supportsCanonicalEmailValidation", SupportsCanonicalEmailValidation },
            { "supportsFreeEmailValidation", SupportsFreeEmailValidation },
            { "supportsCorporateEmailValidation", SupportsCorporateEmailValidation },
            { "supportsProjectSpecificRoles", SupportsProjectSpecificRoles },
            { "backupsEnabled", BackupsEnabled },
            { "usagePerProject", UsagePerProject },
            { "supportedAddons", SupportedAddons?.ToMap() },
            { "backupPolicies", BackupPolicies },
            { "deploymentSize", DeploymentSize },
            { "buildSize", BuildSize },
            { "databasesAllowEncrypt", DatabasesAllowEncrypt },
            { "limits", Limits?.ToMap() },
            { "group", Group.Value },
            { "program", Program?.ToMap() },
            { "dedicatedDatabases", DedicatedDatabases?.ToMap() }
        };
    }
}
