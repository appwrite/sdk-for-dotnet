
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DomainsList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("domains")]
        public List<XDomain> Domains { get; private set; }

        public DomainsList(
            long total,
            List<XDomain> domains
        )
        {
            Total = total;
            Domains = domains;
        }

        public static DomainsList From(Dictionary<string, object> map) => new DomainsList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            domains: (map.ContainsKey("domains") ? map["domains"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.XDomain.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "domains", Domains?.Select(it => it.ToMap()).ToList() }
        };
    }
}
