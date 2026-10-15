
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Organization
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("prefs")]
        public Preferences Prefs { get; private set; }

        [JsonPropertyName("billingBudget")]
        public long? BillingBudget { get; private set; }

        [JsonPropertyName("budgetAlerts")]
        public List<long> BudgetAlerts { get; private set; }

        [JsonPropertyName("billingPlan")]
        public string BillingPlan { get; private set; }

        [JsonPropertyName("billingPlanId")]
        public string BillingPlanId { get; private set; }

        [JsonPropertyName("billingPlanDetails")]
        public BillingPlan BillingPlanDetails { get; private set; }

        [JsonPropertyName("billingEmail")]
        public string BillingEmail { get; private set; }

        [JsonPropertyName("billingStartDate")]
        public string? BillingStartDate { get; private set; }

        [JsonPropertyName("billingCurrentInvoiceDate")]
        public string? BillingCurrentInvoiceDate { get; private set; }

        [JsonPropertyName("billingNextInvoiceDate")]
        public string? BillingNextInvoiceDate { get; private set; }

        [JsonPropertyName("billingTrialStartDate")]
        public string? BillingTrialStartDate { get; private set; }

        [JsonPropertyName("billingTrialDays")]
        public long? BillingTrialDays { get; private set; }

        [JsonPropertyName("billingAggregationId")]
        public string? BillingAggregationId { get; private set; }

        [JsonPropertyName("billingInvoiceId")]
        public string? BillingInvoiceId { get; private set; }

        [JsonPropertyName("paymentMethodId")]
        public string? PaymentMethodId { get; private set; }

        [JsonPropertyName("billingAddressId")]
        public string? BillingAddressId { get; private set; }

        [JsonPropertyName("backupPaymentMethodId")]
        public string? BackupPaymentMethodId { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        [JsonPropertyName("remarks")]
        public string? Remarks { get; private set; }

        [JsonPropertyName("agreementBAA")]
        public string? AgreementBAA { get; private set; }

        [JsonPropertyName("programManagerName")]
        public string? ProgramManagerName { get; private set; }

        [JsonPropertyName("programManagerCalendar")]
        public string? ProgramManagerCalendar { get; private set; }

        [JsonPropertyName("programDiscordChannelName")]
        public string? ProgramDiscordChannelName { get; private set; }

        [JsonPropertyName("programDiscordChannelUrl")]
        public string? ProgramDiscordChannelUrl { get; private set; }

        [JsonPropertyName("billingLimits")]
        public BillingLimits? BillingLimits { get; private set; }

        [JsonPropertyName("billingPlanDowngrade")]
        public string? BillingPlanDowngrade { get; private set; }

        [JsonPropertyName("billingTaxId")]
        public string? BillingTaxId { get; private set; }

        [JsonPropertyName("markedForDeletion")]
        public bool MarkedForDeletion { get; private set; }

        [JsonPropertyName("platform")]
        public string Platform { get; private set; }

        [JsonPropertyName("projects")]
        public List<string> Projects { get; private set; }

        public Organization(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            long total,
            Preferences prefs,
            long? billingBudget,
            List<long> budgetAlerts,
            string billingPlan,
            string billingPlanId,
            BillingPlan billingPlanDetails,
            string billingEmail,
            string? billingStartDate,
            string? billingCurrentInvoiceDate,
            string? billingNextInvoiceDate,
            string? billingTrialStartDate,
            long? billingTrialDays,
            string? billingAggregationId,
            string? billingInvoiceId,
            string? paymentMethodId,
            string? billingAddressId,
            string? backupPaymentMethodId,
            string status,
            string? remarks,
            string? agreementBAA,
            string? programManagerName,
            string? programManagerCalendar,
            string? programDiscordChannelName,
            string? programDiscordChannelUrl,
            BillingLimits? billingLimits,
            string? billingPlanDowngrade,
            string? billingTaxId,
            bool markedForDeletion,
            string platform,
            List<string> projects
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Total = total;
            Prefs = prefs;
            BillingBudget = billingBudget;
            BudgetAlerts = budgetAlerts;
            BillingPlan = billingPlan;
            BillingPlanId = billingPlanId;
            BillingPlanDetails = billingPlanDetails;
            BillingEmail = billingEmail;
            BillingStartDate = billingStartDate;
            BillingCurrentInvoiceDate = billingCurrentInvoiceDate;
            BillingNextInvoiceDate = billingNextInvoiceDate;
            BillingTrialStartDate = billingTrialStartDate;
            BillingTrialDays = billingTrialDays;
            BillingAggregationId = billingAggregationId;
            BillingInvoiceId = billingInvoiceId;
            PaymentMethodId = paymentMethodId;
            BillingAddressId = billingAddressId;
            BackupPaymentMethodId = backupPaymentMethodId;
            Status = status;
            Remarks = remarks;
            AgreementBAA = agreementBAA;
            ProgramManagerName = programManagerName;
            ProgramManagerCalendar = programManagerCalendar;
            ProgramDiscordChannelName = programDiscordChannelName;
            ProgramDiscordChannelUrl = programDiscordChannelUrl;
            BillingLimits = billingLimits;
            BillingPlanDowngrade = billingPlanDowngrade;
            BillingTaxId = billingTaxId;
            MarkedForDeletion = markedForDeletion;
            Platform = platform;
            Projects = projects;
        }

        public static Organization From(Dictionary<string, object> map) => new Organization(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            prefs: Appwrite.Models.Preferences.From(map: map["prefs"] is JsonElement jsonObj6 ? jsonObj6.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["prefs"]),
            billingBudget: map.TryGetValue("billingBudget", out var numberRaw7) && numberRaw7 != null
                                    ? Convert.ToInt64(numberRaw7)
                                    : null,
            budgetAlerts: (map.ContainsKey("budgetAlerts") ? map["budgetAlerts"] : new List<object> { 75 }).ConvertToList<long>(),
            billingPlan: (map.ContainsKey("billingPlan") ? map["billingPlan"] : "tier-0").ToString(),
            billingPlanId: (map.ContainsKey("billingPlanId") ? map["billingPlanId"] : "tier-0").ToString(),
            billingPlanDetails: Appwrite.Models.BillingPlan.From(map: map["billingPlanDetails"] is JsonElement jsonObj11 ? jsonObj11.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["billingPlanDetails"]),
            billingEmail: (map.ContainsKey("billingEmail") ? map["billingEmail"] : "").ToString(),
            billingStartDate: map.TryGetValue("billingStartDate", out var billingStartDate) ? billingStartDate?.ToString() : null,
            billingCurrentInvoiceDate: map.TryGetValue("billingCurrentInvoiceDate", out var billingCurrentInvoiceDate) ? billingCurrentInvoiceDate?.ToString() : null,
            billingNextInvoiceDate: map.TryGetValue("billingNextInvoiceDate", out var billingNextInvoiceDate) ? billingNextInvoiceDate?.ToString() : null,
            billingTrialStartDate: map.TryGetValue("billingTrialStartDate", out var billingTrialStartDate) ? billingTrialStartDate?.ToString() : null,
            billingTrialDays: map.TryGetValue("billingTrialDays", out var numberRaw17) && numberRaw17 != null
                                    ? Convert.ToInt64(numberRaw17)
                                    : null,
            billingAggregationId: map.TryGetValue("billingAggregationId", out var billingAggregationId) ? billingAggregationId?.ToString() : null,
            billingInvoiceId: map.TryGetValue("billingInvoiceId", out var billingInvoiceId) ? billingInvoiceId?.ToString() : null,
            paymentMethodId: map.TryGetValue("paymentMethodId", out var paymentMethodId) ? paymentMethodId?.ToString() : null,
            billingAddressId: map.TryGetValue("billingAddressId", out var billingAddressId) ? billingAddressId?.ToString() : null,
            backupPaymentMethodId: map.TryGetValue("backupPaymentMethodId", out var backupPaymentMethodId) ? backupPaymentMethodId?.ToString() : null,
            status: (map.ContainsKey("status") ? map["status"] : "draft").ToString(),
            remarks: map.TryGetValue("remarks", out var remarks) ? remarks?.ToString() : null,
            agreementBAA: map.TryGetValue("agreementBAA", out var agreementBAA) ? agreementBAA?.ToString() : null,
            programManagerName: map.TryGetValue("programManagerName", out var programManagerName) ? programManagerName?.ToString() : null,
            programManagerCalendar: map.TryGetValue("programManagerCalendar", out var programManagerCalendar) ? programManagerCalendar?.ToString() : null,
            programDiscordChannelName: map.TryGetValue("programDiscordChannelName", out var programDiscordChannelName) ? programDiscordChannelName?.ToString() : null,
            programDiscordChannelUrl: map.TryGetValue("programDiscordChannelUrl", out var programDiscordChannelUrl) ? programDiscordChannelUrl?.ToString() : null,
            billingLimits: map.TryGetValue("billingLimits", out var objectRaw30) && objectRaw30 != null
                                    ? Appwrite.Models.BillingLimits.From(map: objectRaw30 is JsonElement jsonObj30 ? jsonObj30.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)objectRaw30)
                                    : null,
            billingPlanDowngrade: map.TryGetValue("billingPlanDowngrade", out var billingPlanDowngrade) ? billingPlanDowngrade?.ToString() : null,
            billingTaxId: map.TryGetValue("billingTaxId", out var billingTaxId) ? billingTaxId?.ToString() : null,
            markedForDeletion: (bool)(map.ContainsKey("markedForDeletion") ? map["markedForDeletion"] : false),
            platform: (map.ContainsKey("platform") ? map["platform"] : "appwrite").ToString(),
            projects: (map.ContainsKey("projects") ? map["projects"] : new List<object>()).ConvertToList<string>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "total", Total },
            { "prefs", Prefs?.ToMap() },
            { "billingBudget", BillingBudget },
            { "budgetAlerts", BudgetAlerts },
            { "billingPlan", BillingPlan },
            { "billingPlanId", BillingPlanId },
            { "billingPlanDetails", BillingPlanDetails?.ToMap() },
            { "billingEmail", BillingEmail },
            { "billingStartDate", BillingStartDate },
            { "billingCurrentInvoiceDate", BillingCurrentInvoiceDate },
            { "billingNextInvoiceDate", BillingNextInvoiceDate },
            { "billingTrialStartDate", BillingTrialStartDate },
            { "billingTrialDays", BillingTrialDays },
            { "billingAggregationId", BillingAggregationId },
            { "billingInvoiceId", BillingInvoiceId },
            { "paymentMethodId", PaymentMethodId },
            { "billingAddressId", BillingAddressId },
            { "backupPaymentMethodId", BackupPaymentMethodId },
            { "status", Status },
            { "remarks", Remarks },
            { "agreementBAA", AgreementBAA },
            { "programManagerName", ProgramManagerName },
            { "programManagerCalendar", ProgramManagerCalendar },
            { "programDiscordChannelName", ProgramDiscordChannelName },
            { "programDiscordChannelUrl", ProgramDiscordChannelUrl },
            { "billingLimits", BillingLimits?.ToMap() },
            { "billingPlanDowngrade", BillingPlanDowngrade },
            { "billingTaxId", BillingTaxId },
            { "markedForDeletion", MarkedForDeletion },
            { "platform", Platform },
            { "projects", Projects }
        };
    }
}
