
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class UsageResources
    {
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("value")]
        public long Value { get; private set; }

        [JsonPropertyName("amount")]
        public double Amount { get; private set; }

        [JsonPropertyName("rate")]
        public double Rate { get; private set; }

        [JsonPropertyName("desc")]
        public string Desc { get; private set; }

        [JsonPropertyName("resourceId")]
        public string ResourceId { get; private set; }

        public UsageResources(
            string name,
            long xvalue,
            double amount,
            double rate,
            string desc,
            string resourceId
        ) {
            Name = name;
            Value = xvalue;
            Amount = amount;
            Rate = rate;
            Desc = desc;
            ResourceId = resourceId;
        }

        public static UsageResources From(Dictionary<string, object> map) => new UsageResources(
            name: map["name"].ToString(),
            xvalue: Convert.ToInt64(map["value"]),
            amount: Convert.ToDouble(map["amount"]),
            rate: Convert.ToDouble(map["rate"]),
            desc: map["desc"].ToString(),
            resourceId: map["resourceId"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "name", Name },
            { "value", Value },
            { "amount", Amount },
            { "rate", Rate },
            { "desc", Desc },
            { "resourceId", ResourceId }
        };
    }
}
