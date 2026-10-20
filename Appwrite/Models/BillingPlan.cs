
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

        [JsonPropertyName("environments")]
        public long Environments { get; private set; }

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

        [JsonPropertyName("usageAggregateOnlyMetrics")]
        public List<string>? UsageAggregateOnlyMetrics { get; private set; }

        [JsonPropertyName("projectInactivityDays")]
        public long ProjectInactivityDays { get; private set; }

        [JsonPropertyName("alertLimit")]
        public long AlertLimit { get; private set; }

        [JsonPropertyName("usage")]
        public UsageBillingPlan? Usage { get; private set; }

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

        [JsonPropertyName("eligibleCountries")]
        public List<string>? EligibleCountries { get; private set; }

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

        [JsonPropertyName("supportsDedicatedDatabases")]
        public bool SupportsDedicatedDatabases { get; private set; }

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

        [JsonPropertyName("functionsIntervalMinimum")]
        public long FunctionsIntervalMinimum { get; private set; }

        [JsonPropertyName("functionsAllowCron")]
        public bool FunctionsAllowCron { get; private set; }

        [JsonPropertyName("databasesAllowEncrypt")]
        public bool DatabasesAllowEncrypt { get; private set; }

        [JsonPropertyName("limits")]
        public BillingPlanLimits? Limits { get; private set; }

        [JsonPropertyName("group")]
        public Appwrite.Enums.BillingPlanGroup Group { get; private set; }

        [JsonPropertyName("program")]
        public Program? Program { get; private set; }

        [JsonPropertyName("databaseComputeCredit")]
        public double DatabaseComputeCredit { get; private set; }

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
            long environments,
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
            List<string>? usageAggregateOnlyMetrics,
            long projectInactivityDays,
            long alertLimit,
            UsageBillingPlan? usage,
            BillingPlanAddon addons,
            bool budgetCapEnabled,
            bool customSmtp,
            bool emailBranding,
            bool requiresPaymentMethod,
            bool requiresBillingAddress,
            List<string>? eligibleCountries,
            bool isAvailable,
            bool selfService,
            bool premiumSupport,
            bool budgeting,
            bool supportsMockNumbers,
            bool supportsOrganizationRoles,
            bool supportsCredits,
            bool supportsDedicatedDatabases,
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
            long functionsIntervalMinimum,
            bool functionsAllowCron,
            bool databasesAllowEncrypt,
            BillingPlanLimits? limits,
            Appwrite.Enums.BillingPlanGroup @group,
            Program? program,
            double databaseComputeCredit,
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
            Environments = environments;
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
            UsageAggregateOnlyMetrics = usageAggregateOnlyMetrics;
            ProjectInactivityDays = projectInactivityDays;
            AlertLimit = alertLimit;
            Usage = usage;
            Addons = addons;
            BudgetCapEnabled = budgetCapEnabled;
            CustomSmtp = customSmtp;
            EmailBranding = emailBranding;
            RequiresPaymentMethod = requiresPaymentMethod;
            RequiresBillingAddress = requiresBillingAddress;
            EligibleCountries = eligibleCountries;
            IsAvailable = isAvailable;
            SelfService = selfService;
            PremiumSupport = premiumSupport;
            Budgeting = budgeting;
            SupportsMockNumbers = supportsMockNumbers;
            SupportsOrganizationRoles = supportsOrganizationRoles;
            SupportsCredits = supportsCredits;
            SupportsDedicatedDatabases = supportsDedicatedDatabases;
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
            FunctionsIntervalMinimum = functionsIntervalMinimum;
            FunctionsAllowCron = functionsAllowCron;
            DatabasesAllowEncrypt = databasesAllowEncrypt;
            Limits = limits;
            Group = @group;
            Program = program;
            DatabaseComputeCredit = databaseComputeCredit;
            DedicatedDatabases = dedicatedDatabases;
        }

        public static BillingPlan From(Dictionary<string, object> map) => new BillingPlan(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            desc: (map.ContainsKey("desc") ? map["desc"] : "").ToString(),
            order: Convert.ToInt64((map.ContainsKey("order") ? map["order"] : 0)),
            price: Convert.ToDouble((map.ContainsKey("price") ? map["price"] : 0)),
            trial: Convert.ToInt64((map.ContainsKey("trial") ? map["trial"] : 0)),
            bandwidth: Convert.ToInt64((map.ContainsKey("bandwidth") ? map["bandwidth"] : 0)),
            storage: Convert.ToInt64((map.ContainsKey("storage") ? map["storage"] : 0)),
            imageTransformations: Convert.ToInt64((map.ContainsKey("imageTransformations") ? map["imageTransformations"] : 0)),
            screenshotsGenerated: Convert.ToInt64((map.ContainsKey("screenshotsGenerated") ? map["screenshotsGenerated"] : 0)),
            members: map.TryGetValue("members", out var numberRaw11) && numberRaw11 != null
                                    ? Convert.ToInt64(numberRaw11)
                                    : null,
            webhooks: Convert.ToInt64((map.ContainsKey("webhooks") ? map["webhooks"] : 0)),
            wafRules: Convert.ToInt64((map.ContainsKey("wafRules") ? map["wafRules"] : 0)),
            environments: Convert.ToInt64((map.ContainsKey("environments") ? map["environments"] : 0)),
            projects: Convert.ToInt64((map.ContainsKey("projects") ? map["projects"] : 0)),
            platforms: Convert.ToInt64((map.ContainsKey("platforms") ? map["platforms"] : 0)),
            users: Convert.ToInt64((map.ContainsKey("users") ? map["users"] : 0)),
            teams: Convert.ToInt64((map.ContainsKey("teams") ? map["teams"] : 0)),
            databases: Convert.ToInt64((map.ContainsKey("databases") ? map["databases"] : 0)),
            databasesReads: Convert.ToInt64((map.ContainsKey("databasesReads") ? map["databasesReads"] : 0)),
            databasesWrites: Convert.ToInt64((map.ContainsKey("databasesWrites") ? map["databasesWrites"] : 0)),
            databasesBatchSize: Convert.ToInt64((map.ContainsKey("databasesBatchSize") ? map["databasesBatchSize"] : 0)),
            buckets: Convert.ToInt64((map.ContainsKey("buckets") ? map["buckets"] : 0)),
            fileSize: Convert.ToInt64((map.ContainsKey("fileSize") ? map["fileSize"] : 0)),
            functions: Convert.ToInt64((map.ContainsKey("functions") ? map["functions"] : 0)),
            sites: Convert.ToInt64((map.ContainsKey("sites") ? map["sites"] : 0)),
            executions: Convert.ToInt64((map.ContainsKey("executions") ? map["executions"] : 0)),
            executionsRetentionCount: Convert.ToInt64((map.ContainsKey("executionsRetentionCount") ? map["executionsRetentionCount"] : 1000)),
            gBHours: Convert.ToInt64((map.ContainsKey("GBHours") ? map["GBHours"] : 0)),
            realtime: Convert.ToInt64((map.ContainsKey("realtime") ? map["realtime"] : 0)),
            realtimeMessages: Convert.ToInt64((map.ContainsKey("realtimeMessages") ? map["realtimeMessages"] : 0)),
            messages: Convert.ToInt64((map.ContainsKey("messages") ? map["messages"] : 0)),
            topics: Convert.ToInt64((map.ContainsKey("topics") ? map["topics"] : 0)),
            authPhone: Convert.ToInt64((map.ContainsKey("authPhone") ? map["authPhone"] : 0)),
            domains: Convert.ToInt64((map.ContainsKey("domains") ? map["domains"] : 0)),
            activityLogs: map.TryGetValue("activityLogs", out var numberRaw36) && numberRaw36 != null
                                    ? Convert.ToInt64(numberRaw36)
                                    : null,
            usageLogs: Convert.ToInt64((map.ContainsKey("usageLogs") ? map["usageLogs"] : 0)),
            usageLogsIntervals: map.TryGetValue("usageLogsIntervals", out var arrayRaw38) && arrayRaw38 != null
                                ? arrayRaw38.ConvertToList<string>()
                                : null,
            usageAggregateOnlyMetrics: map.TryGetValue("usageAggregateOnlyMetrics", out var arrayRaw39) && arrayRaw39 != null
                                ? arrayRaw39.ConvertToList<string>()
                                : null,
            projectInactivityDays: Convert.ToInt64((map.ContainsKey("projectInactivityDays") ? map["projectInactivityDays"] : 0)),
            alertLimit: Convert.ToInt64((map.ContainsKey("alertLimit") ? map["alertLimit"] : 80)),
            usage: map.TryGetValue("usage", out var objectRaw42) && objectRaw42 != null
                                    ? Appwrite.Models.UsageBillingPlan.From(map: objectRaw42 is JsonElement jsonObj42 ? jsonObj42.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)objectRaw42)
                                    : null,
            addons: Appwrite.Models.BillingPlanAddon.From(map: map["addons"] is JsonElement jsonObj43 ? jsonObj43.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["addons"]),
            budgetCapEnabled: (bool)(map.ContainsKey("budgetCapEnabled") ? map["budgetCapEnabled"] : false),
            customSmtp: (bool)(map.ContainsKey("customSmtp") ? map["customSmtp"] : false),
            emailBranding: (bool)(map.ContainsKey("emailBranding") ? map["emailBranding"] : false),
            requiresPaymentMethod: (bool)(map.ContainsKey("requiresPaymentMethod") ? map["requiresPaymentMethod"] : true),
            requiresBillingAddress: (bool)(map.ContainsKey("requiresBillingAddress") ? map["requiresBillingAddress"] : false),
            eligibleCountries: map.TryGetValue("eligibleCountries", out var arrayRaw49) && arrayRaw49 != null
                                ? arrayRaw49.ConvertToList<string>()
                                : null,
            isAvailable: (bool)(map.ContainsKey("isAvailable") ? map["isAvailable"] : true),
            selfService: (bool)(map.ContainsKey("selfService") ? map["selfService"] : true),
            premiumSupport: (bool)(map.ContainsKey("premiumSupport") ? map["premiumSupport"] : true),
            budgeting: (bool)(map.ContainsKey("budgeting") ? map["budgeting"] : true),
            supportsMockNumbers: (bool)(map.ContainsKey("supportsMockNumbers") ? map["supportsMockNumbers"] : true),
            supportsOrganizationRoles: (bool)(map.ContainsKey("supportsOrganizationRoles") ? map["supportsOrganizationRoles"] : true),
            supportsCredits: (bool)(map.ContainsKey("supportsCredits") ? map["supportsCredits"] : false),
            supportsDedicatedDatabases: (bool)(map.ContainsKey("supportsDedicatedDatabases") ? map["supportsDedicatedDatabases"] : false),
            supportsDisposableEmailValidation: (bool)(map.ContainsKey("supportsDisposableEmailValidation") ? map["supportsDisposableEmailValidation"] : false),
            supportsCanonicalEmailValidation: (bool)(map.ContainsKey("supportsCanonicalEmailValidation") ? map["supportsCanonicalEmailValidation"] : false),
            supportsFreeEmailValidation: (bool)(map.ContainsKey("supportsFreeEmailValidation") ? map["supportsFreeEmailValidation"] : false),
            supportsCorporateEmailValidation: (bool)(map.ContainsKey("supportsCorporateEmailValidation") ? map["supportsCorporateEmailValidation"] : false),
            supportsProjectSpecificRoles: (bool)(map.ContainsKey("supportsProjectSpecificRoles") ? map["supportsProjectSpecificRoles"] : false),
            backupsEnabled: map.TryGetValue("backupsEnabled", out var boolRaw63) && boolRaw63 != null
                                        ? (bool?)boolRaw63
                                        : null,
            usagePerProject: (bool)(map.ContainsKey("usagePerProject") ? map["usagePerProject"] : true),
            supportedAddons: Appwrite.Models.BillingPlanSupportedAddons.From(map: map["supportedAddons"] is JsonElement jsonObj65 ? jsonObj65.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["supportedAddons"]),
            backupPolicies: map.TryGetValue("backupPolicies", out var numberRaw66) && numberRaw66 != null
                                    ? Convert.ToInt64(numberRaw66)
                                    : null,
            deploymentSize: Convert.ToInt64((map.ContainsKey("deploymentSize") ? map["deploymentSize"] : 0)),
            buildSize: Convert.ToInt64((map.ContainsKey("buildSize") ? map["buildSize"] : 0)),
            functionsIntervalMinimum: Convert.ToInt64((map.ContainsKey("functionsIntervalMinimum") ? map["functionsIntervalMinimum"] : 0)),
            functionsAllowCron: (bool)(map.ContainsKey("functionsAllowCron") ? map["functionsAllowCron"] : true),
            databasesAllowEncrypt: (bool)(map.ContainsKey("databasesAllowEncrypt") ? map["databasesAllowEncrypt"] : false),
            limits: map.TryGetValue("limits", out var objectRaw72) && objectRaw72 != null
                                    ? Appwrite.Models.BillingPlanLimits.From(map: objectRaw72 is JsonElement jsonObj72 ? jsonObj72.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)objectRaw72)
                                    : null,
            @group: new Appwrite.Enums.BillingPlanGroup(map["group"].ToString()!),
            program: map.TryGetValue("program", out var objectRaw74) && objectRaw74 != null
                                    ? Appwrite.Models.Program.From(map: objectRaw74 is JsonElement jsonObj74 ? jsonObj74.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)objectRaw74)
                                    : null,
            databaseComputeCredit: Convert.ToDouble((map.ContainsKey("databaseComputeCredit") ? map["databaseComputeCredit"] : 0)),
            dedicatedDatabases: map.TryGetValue("dedicatedDatabases", out var objectRaw76) && objectRaw76 != null
                                    ? Appwrite.Models.BillingPlanDedicatedDatabaseLimits.From(map: objectRaw76 is JsonElement jsonObj76 ? jsonObj76.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)objectRaw76)
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
            { "environments", Environments },
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
            { "usageAggregateOnlyMetrics", UsageAggregateOnlyMetrics },
            { "projectInactivityDays", ProjectInactivityDays },
            { "alertLimit", AlertLimit },
            { "usage", Usage?.ToMap() },
            { "addons", Addons?.ToMap() },
            { "budgetCapEnabled", BudgetCapEnabled },
            { "customSmtp", CustomSmtp },
            { "emailBranding", EmailBranding },
            { "requiresPaymentMethod", RequiresPaymentMethod },
            { "requiresBillingAddress", RequiresBillingAddress },
            { "eligibleCountries", EligibleCountries },
            { "isAvailable", IsAvailable },
            { "selfService", SelfService },
            { "premiumSupport", PremiumSupport },
            { "budgeting", Budgeting },
            { "supportsMockNumbers", SupportsMockNumbers },
            { "supportsOrganizationRoles", SupportsOrganizationRoles },
            { "supportsCredits", SupportsCredits },
            { "supportsDedicatedDatabases", SupportsDedicatedDatabases },
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
            { "functionsIntervalMinimum", FunctionsIntervalMinimum },
            { "functionsAllowCron", FunctionsAllowCron },
            { "databasesAllowEncrypt", DatabasesAllowEncrypt },
            { "limits", Limits?.ToMap() },
            { "group", Group.Value },
            { "program", Program?.ToMap() },
            { "databaseComputeCredit", DatabaseComputeCredit },
            { "dedicatedDatabases", DedicatedDatabases?.ToMap() }
        };
    }
}
