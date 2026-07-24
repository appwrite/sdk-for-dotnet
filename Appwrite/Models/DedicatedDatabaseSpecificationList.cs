
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseSpecificationList
    {
        [JsonPropertyName("specifications")]
        public List<DedicatedDatabaseSpecification> Specifications { get; private set; }

        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("pricing")]
        public DedicatedDatabaseSpecificationPricing Pricing { get; private set; }

        public DedicatedDatabaseSpecificationList(
            List<DedicatedDatabaseSpecification> specifications,
            long total,
            DedicatedDatabaseSpecificationPricing pricing
        )
        {
            Specifications = specifications;
            Total = total;
            Pricing = pricing;
        }

        public static DedicatedDatabaseSpecificationList From(Dictionary<string, object> map) => new DedicatedDatabaseSpecificationList(
            specifications: map["specifications"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.DedicatedDatabaseSpecification.From(map: it)).ToList(),
            total: Convert.ToInt64(map["total"]),
            pricing: Appwrite.Models.DedicatedDatabaseSpecificationPricing.From(map: map["pricing"] is JsonElement jsonObj3 ? jsonObj3.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["pricing"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "specifications", Specifications?.Select(it => it.ToMap()).ToList() },
            { "total", Total },
            { "pricing", Pricing?.ToMap() }
        };
    }
}
