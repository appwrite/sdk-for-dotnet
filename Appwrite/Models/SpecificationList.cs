
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

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
            specifications: map["specifications"].ConvertToList<Dictionary<string, object>>().Select(it => Specification.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "specifications", Specifications.Select(it => it.ToMap()) }
        };
    }
}
