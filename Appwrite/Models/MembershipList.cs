
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class MembershipList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("memberships")]
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
            memberships: map["memberships"].ConvertToList<Dictionary<string, object>>().Select(it => Membership.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "memberships", Memberships.Select(it => it.ToMap()) }
        };
    }
}
