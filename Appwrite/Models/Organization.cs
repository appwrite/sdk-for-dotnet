
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
        public long BillingBudget { get; private set; }

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
        public string BillingStartDate { get; private set; }

        [JsonPropertyName("billingCurrentInvoiceDate")]
        public string BillingCurrentInvoiceDate { get; private set; }

        [JsonPropertyName("billingNextInvoiceDate")]
        public string BillingNextInvoiceDate { get; private set; }

        [JsonPropertyName("billingTrialStartDate")]
        public string BillingTrialStartDate { get; private set; }

        [JsonPropertyName("billingTrialDays")]
        public long BillingTrialDays { get; private set; }

        [JsonPropertyName("billingAggregationId")]
        public string BillingAggregationId { get; private set; }

        [JsonPropertyName("billingInvoiceId")]
        public string BillingInvoiceId { get; private set; }

        [JsonPropertyName("paymentMethodId")]
        public string PaymentMethodId { get; private set; }

        [JsonPropertyName("billingAddressId")]
        public string BillingAddressId { get; private set; }

        [JsonPropertyName("backupPaymentMethodId")]
        public string BackupPaymentMethodId { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; private set; }

        [JsonPropertyName("agreementBAA")]
        public string AgreementBAA { get; private set; }

        [JsonPropertyName("programManagerName")]
        public string ProgramManagerName { get; private set; }

        [JsonPropertyName("programManagerCalendar")]
        public string ProgramManagerCalendar { get; private set; }

        [JsonPropertyName("programDiscordChannelName")]
        public string ProgramDiscordChannelName { get; private set; }

        [JsonPropertyName("programDiscordChannelUrl")]
        public string ProgramDiscordChannelUrl { get; private set; }

        [JsonPropertyName("billingLimits")]
        public BillingLimits? BillingLimits { get; private set; }

        [JsonPropertyName("billingPlanDowngrade")]
        public string BillingPlanDowngrade { get; private set; }

        [JsonPropertyName("billingTaxId")]
        public string BillingTaxId { get; private set; }

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
            long billingBudget,
            List<long> budgetAlerts,
            string billingPlan,
            string billingPlanId,
            BillingPlan billingPlanDetails,
            string billingEmail,
            string billingStartDate,
            string billingCurrentInvoiceDate,
            string billingNextInvoiceDate,
            string billingTrialStartDate,
            long billingTrialDays,
            string billingAggregationId,
            string billingInvoiceId,
            string paymentMethodId,
            string billingAddressId,
            string backupPaymentMethodId,
            string status,
            string remarks,
            string agreementBAA,
            string programManagerName,
            string programManagerCalendar,
            string programDiscordChannelName,
            string programDiscordChannelUrl,
            BillingLimits? billingLimits,
            string billingPlanDowngrade,
            string billingTaxId,
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
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            name: map["name"].ToString(),
            total: Convert.ToInt64(map["total"]),
            prefs: Appwrite.Models.Preferences.From(map: map["prefs"] is JsonElement jsonObj6 ? jsonObj6.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["prefs"]),
            billingBudget: Convert.ToInt64(map["billingBudget"]),
            budgetAlerts: map["budgetAlerts"].ConvertToList<long>(),
            billingPlan: map["billingPlan"].ToString(),
            billingPlanId: map["billingPlanId"].ToString(),
            billingPlanDetails: Appwrite.Models.BillingPlan.From(map: map["billingPlanDetails"] is JsonElement jsonObj11 ? jsonObj11.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["billingPlanDetails"]),
            billingEmail: map["billingEmail"].ToString(),
            billingStartDate: map["billingStartDate"].ToString(),
            billingCurrentInvoiceDate: map["billingCurrentInvoiceDate"].ToString(),
            billingNextInvoiceDate: map["billingNextInvoiceDate"].ToString(),
            billingTrialStartDate: map["billingTrialStartDate"].ToString(),
            billingTrialDays: Convert.ToInt64(map["billingTrialDays"]),
            billingAggregationId: map["billingAggregationId"].ToString(),
            billingInvoiceId: map["billingInvoiceId"].ToString(),
            paymentMethodId: map["paymentMethodId"].ToString(),
            billingAddressId: map["billingAddressId"].ToString(),
            backupPaymentMethodId: map["backupPaymentMethodId"].ToString(),
            status: map["status"].ToString(),
            remarks: map["remarks"].ToString(),
            agreementBAA: map["agreementBAA"].ToString(),
            programManagerName: map["programManagerName"].ToString(),
            programManagerCalendar: map["programManagerCalendar"].ToString(),
            programDiscordChannelName: map["programDiscordChannelName"].ToString(),
            programDiscordChannelUrl: map["programDiscordChannelUrl"].ToString(),
            billingLimits: map.TryGetValue("billingLimits", out var objectRaw30) && objectRaw30 != null
                                    ? Appwrite.Models.BillingLimits.From(map: objectRaw30 is JsonElement jsonObj30 ? jsonObj30.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)objectRaw30)
                                    : null,
            billingPlanDowngrade: map["billingPlanDowngrade"].ToString(),
            billingTaxId: map["billingTaxId"].ToString(),
            markedForDeletion: (bool)map["markedForDeletion"],
            platform: map["platform"].ToString(),
            projects: map["projects"].ConvertToList<string>()
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
