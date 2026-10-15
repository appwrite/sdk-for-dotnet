
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class BillingPlanAddonDetails
    {
        [JsonPropertyName("supported")]
        public bool Supported { get; private set; }

        [JsonPropertyName("planIncluded")]
        public long PlanIncluded { get; private set; }

        [JsonPropertyName("limit")]
        public long Limit { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("currency")]
        public string? Currency { get; private set; }

        [JsonPropertyName("price")]
        public double Price { get; private set; }

        [JsonPropertyName("value")]
        public long Value { get; private set; }

        [JsonPropertyName("invoiceDesc")]
        public string InvoiceDesc { get; private set; }

        public BillingPlanAddonDetails(
            bool supported,
            long planIncluded,
            long limit,
            string type,
            string? currency,
            double price,
            long @value,
            string invoiceDesc
        )
        {
            Supported = supported;
            PlanIncluded = planIncluded;
            Limit = limit;
            Type = type;
            Currency = currency;
            Price = price;
            Value = @value;
            InvoiceDesc = invoiceDesc;
        }

        public static BillingPlanAddonDetails From(Dictionary<string, object> map) => new BillingPlanAddonDetails(
            supported: (bool)(map.ContainsKey("supported") ? map["supported"] : false),
            planIncluded: Convert.ToInt64((map.ContainsKey("planIncluded") ? map["planIncluded"] : 0)),
            limit: Convert.ToInt64((map.ContainsKey("limit") ? map["limit"] : 0)),
            type: (map.ContainsKey("type") ? map["type"] : "numeric").ToString(),
            currency: map.TryGetValue("currency", out var currency) ? currency?.ToString() : null,
            price: Convert.ToDouble((map.ContainsKey("price") ? map["price"] : 0)),
            @value: Convert.ToInt64((map.ContainsKey("value") ? map["value"] : 0)),
            invoiceDesc: (map.ContainsKey("invoiceDesc") ? map["invoiceDesc"] : "").ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "supported", Supported },
            { "planIncluded", PlanIncluded },
            { "limit", Limit },
            { "type", Type },
            { "currency", Currency },
            { "price", Price },
            { "value", Value },
            { "invoiceDesc", InvoiceDesc }
        };
    }
}
