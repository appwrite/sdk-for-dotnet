
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class IdentityList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("identities")]
        public List<Identity> Identities { get; private set; }

        public IdentityList(
            long total,
            List<Identity> identities
        ) {
            Total = total;
            Identities = identities;
        }

        public static IdentityList From(Dictionary<string, object> map) => new IdentityList(
            total: Convert.ToInt64(map["total"]),
            identities: map["identities"].ConvertToList<Dictionary<string, object>>().Select(it => Identity.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "identities", Identities.Select(it => it.ToMap()) }
        };
    }
}
