
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

        public DedicatedDatabaseSpecificationList(
            List<DedicatedDatabaseSpecification> specifications,
            long total
        )
        {
            Specifications = specifications;
            Total = total;
        }

        public static DedicatedDatabaseSpecificationList From(Dictionary<string, object> map) => new DedicatedDatabaseSpecificationList(
            specifications: (map.ContainsKey("specifications") ? map["specifications"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.DedicatedDatabaseSpecification.From(map: it)).ToList(),
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0))
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "specifications", Specifications?.Select(it => it.ToMap()).ToList() },
            { "total", Total }
        };
    }
}
