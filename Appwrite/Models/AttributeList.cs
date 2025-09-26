using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class AttributeList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("attributes")]
        public List&lt;object&gt; Attributes { get; private set; }

        public AttributeList(
            long total,
            List&lt;object&gt; attributes
        ) {
            Total = total;
            Attributes = attributes;
        }

        public static AttributeList From(Dictionary<string, object> map) => new AttributeList(
            total: Convert.ToInt64(map["total"]),
            attributes: map["attributes"] is JsonElement jsonArrayProp2 ? jsonArrayProp2.Deserialize<List<object>>()! : (List<object>)map["attributes"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "attributes", Attributes }
        };
    }
}
