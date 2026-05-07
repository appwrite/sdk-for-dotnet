
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PolicySessionLimit
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("total")]
        public long Total { get; private set; }

        public PolicySessionLimit(
            string id,
            long total
        )
        {
            Id = id;
            Total = total;
        }

        public static PolicySessionLimit From(Dictionary<string, object> map) => new PolicySessionLimit(
            id: map["$id"].ToString(),
            total: Convert.ToInt64(map["total"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "total", Total }
        };
    }
}
