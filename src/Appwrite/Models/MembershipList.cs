
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class MembershipList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("memberships")]
        public List<Membership> Memberships { get; private set; }

        public MembershipList(
            long total,
            List<Membership> memberships
        ) {
            Total = total;
            Memberships = memberships;
        }

        public static MembershipList From(Dictionary<string, object> map) => new MembershipList(
            total: Convert.ToInt64(map["total"]),
            memberships: ((JArray)map["memberships"]).ToObject<List<Dictionary<string, object>>>().Select(it => Membership.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "memberships", Memberships.Select(it => it.ToMap()) }
        };
    }
}