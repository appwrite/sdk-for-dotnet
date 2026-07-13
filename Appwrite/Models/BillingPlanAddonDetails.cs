
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
        public string Currency { get; private set; }

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
            string currency,
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
            supported: (bool)map["supported"],
            planIncluded: Convert.ToInt64(map["planIncluded"]),
            limit: Convert.ToInt64(map["limit"]),
            type: map["type"].ToString(),
            currency: map["currency"].ToString(),
            price: Convert.ToDouble(map["price"]),
            @value: Convert.ToInt64(map["value"]),
            invoiceDesc: map["invoiceDesc"].ToString()
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
