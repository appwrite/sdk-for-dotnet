
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class AttributeList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("attributes")]
        public List<object> Attributes { get; private set; }

        public AttributeList(
            long total,
            List<object> attributes
        ) {
            Total = total;
            Attributes = attributes;
        }

        public static AttributeList From(Dictionary<string, object> map) => new AttributeList(
            total: Convert.ToInt64(map["total"]),
            attributes: ((JArray)map["attributes"]).ToObject<List<object>>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "attributes", Attributes }
        };
    }
}