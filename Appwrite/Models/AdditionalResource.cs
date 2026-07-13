
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AdditionalResource
    {
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("unit")]
        public string Unit { get; private set; }

        [JsonPropertyName("currency")]
        public string Currency { get; private set; }

        [JsonPropertyName("price")]
        public double Price { get; private set; }

        [JsonPropertyName("value")]
        public long Value { get; private set; }

        [JsonPropertyName("invoiceDesc")]
        public string InvoiceDesc { get; private set; }

        public AdditionalResource(
            string name,
            string unit,
            string currency,
            double price,
            long @value,
            string invoiceDesc
        )
        {
            Name = name;
            Unit = unit;
            Currency = currency;
            Price = price;
            Value = @value;
            InvoiceDesc = invoiceDesc;
        }

        public static AdditionalResource From(Dictionary<string, object> map) => new AdditionalResource(
            name: map["name"].ToString(),
            unit: map["unit"].ToString(),
            currency: map["currency"].ToString(),
            price: Convert.ToDouble(map["price"]),
            @value: Convert.ToInt64(map["value"]),
            invoiceDesc: map["invoiceDesc"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "name", Name },
            { "unit", Unit },
            { "currency", Currency },
            { "price", Price },
            { "value", Value },
            { "invoiceDesc", InvoiceDesc }
        };
    }
}
