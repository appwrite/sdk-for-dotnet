
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class SpecificationList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("specifications")]
        public List<Specification> Specifications { get; private set; }

        public SpecificationList(
            long total,
            List<Specification> specifications
        ) {
            Total = total;
            Specifications = specifications;
        }

        public static SpecificationList From(Dictionary<string, object> map) => new SpecificationList(
            total: Convert.ToInt64(map["total"])
,
            specifications: 
                        ((JArray)map["specifications"])
                            .ToObject<List<Dictionary<string, object>>>()
                            .Select(it => Specification.From(map: it))
                            .ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "specifications", Specifications.Select(it => it.ToMap()) }
        };
    }
}