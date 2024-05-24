
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class IdentityList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("identities")]
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
            identities: ((JArray)map["identities"]).ToObject<List<Dictionary<string, object>>>().Select(it => Identity.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "identities", Identities.Select(it => it.ToMap()) }
        };
    }
}