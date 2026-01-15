
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Invoice
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("$permissions")]
        public List<string> Permissions { get; private set; }

        [JsonPropertyName("teamId")]
        public string TeamId { get; private set; }

        [JsonPropertyName("aggregationId")]
        public string AggregationId { get; private set; }

        [JsonPropertyName("plan")]
        public string Plan { get; private set; }

        [JsonPropertyName("usage")]
        public List<UsageResources> Usage { get; private set; }

        [JsonPropertyName("amount")]
        public double Amount { get; private set; }

        [JsonPropertyName("tax")]
        public double Tax { get; private set; }

        [JsonPropertyName("taxAmount")]
        public double TaxAmount { get; private set; }

        [JsonPropertyName("vat")]
        public double Vat { get; private set; }

        [JsonPropertyName("vatAmount")]
        public double VatAmount { get; private set; }

        [JsonPropertyName("grossAmount")]
        public double GrossAmount { get; private set; }

        [JsonPropertyName("creditsUsed")]
        public double CreditsUsed { get; private set; }

        [JsonPropertyName("currency")]
        public string Currency { get; private set; }

        [JsonPropertyName("clientSecret")]
        public string ClientSecret { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        [JsonPropertyName("lastError")]
        public string LastError { get; private set; }

        [JsonPropertyName("dueAt")]
        public string DueAt { get; private set; }

        [JsonPropertyName("from")]
        public string From { get; private set; }

        [JsonPropertyName("to")]
        public string To { get; private set; }

        public Invoice(
            string id,
            string createdAt,
            string updatedAt,
            List<string> permissions,
            string teamId,
            string aggregationId,
            string plan,
            List<UsageResources> usage,
            double amount,
            double tax,
            double taxAmount,
            double vat,
            double vatAmount,
            double grossAmount,
            double creditsUsed,
            string currency,
            string clientSecret,
            string status,
            string lastError,
            string dueAt,
            string xfrom,
            string to
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Permissions = permissions;
            TeamId = teamId;
            AggregationId = aggregationId;
            Plan = plan;
            Usage = usage;
            Amount = amount;
            Tax = tax;
            TaxAmount = taxAmount;
            Vat = vat;
            VatAmount = vatAmount;
            GrossAmount = grossAmount;
            CreditsUsed = creditsUsed;
            Currency = currency;
            ClientSecret = clientSecret;
            Status = status;
            LastError = lastError;
            DueAt = dueAt;
            From = xfrom;
            To = to;
        }

        public static Invoice From(Dictionary<string, object> map) => new Invoice(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            permissions: map["$permissions"].ConvertToList<string>(),
            teamId: map["teamId"].ToString(),
            aggregationId: map["aggregationId"].ToString(),
            plan: map["plan"].ToString(),
            usage: map["usage"].ConvertToList<Dictionary<string, object>>().Select(it => UsageResources.From(map: it)).ToList(),
            amount: Convert.ToDouble(map["amount"]),
            tax: Convert.ToDouble(map["tax"]),
            taxAmount: Convert.ToDouble(map["taxAmount"]),
            vat: Convert.ToDouble(map["vat"]),
            vatAmount: Convert.ToDouble(map["vatAmount"]),
            grossAmount: Convert.ToDouble(map["grossAmount"]),
            creditsUsed: Convert.ToDouble(map["creditsUsed"]),
            currency: map["currency"].ToString(),
            clientSecret: map["clientSecret"].ToString(),
            status: map["status"].ToString(),
            lastError: map["lastError"].ToString(),
            dueAt: map["dueAt"].ToString(),
            xfrom: map["from"].ToString(),
            to: map["to"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "$permissions", Permissions },
            { "teamId", TeamId },
            { "aggregationId", AggregationId },
            { "plan", Plan },
            { "usage", Usage.Select(it => it.ToMap()) },
            { "amount", Amount },
            { "tax", Tax },
            { "taxAmount", TaxAmount },
            { "vat", Vat },
            { "vatAmount", VatAmount },
            { "grossAmount", GrossAmount },
            { "creditsUsed", CreditsUsed },
            { "currency", Currency },
            { "clientSecret", ClientSecret },
            { "status", Status },
            { "lastError", LastError },
            { "dueAt", DueAt },
            { "from", From },
            { "to", To }
        };
    }
}
