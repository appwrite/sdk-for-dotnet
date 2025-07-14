
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class SpecificationList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("specifications")]
        public List<Specification> Specifications { get; private set; }

        public SpecificationList(
            long total,
            List<Specification> specifications
        ) {
            Total = total;
            Specifications = specifications;
        }

        public static SpecificationList From(Dictionary<string, object> map) => new SpecificationList(
            total: Convert.ToInt64(map["total"]),
            specifications: map["specifications"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Specification.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["specifications"]).Select(it => Specification.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "specifications", Specifications.Select(it => it.ToMap()) }
        };
    }
}
