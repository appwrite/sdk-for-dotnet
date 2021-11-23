
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class MembershipList
    {
        [JsonProperty("sum")]
        public int Sum { get; set; }

        [JsonProperty("memberships")]
        public List<Membership> Memberships { get; set; }


        public MembershipList(
            int sum,
            List<Membership> memberships
        ) {
            Sum = sum;
            Memberships = memberships;
        }

        public static MembershipList From(Dictionary<string, object> map) => new MembershipList(
            sum: (int)map["sum"],
            memberships: ((JArray)map["memberships"]).ToObject<List<Membership>>()!
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "sum", Sum },
            { "memberships", Memberships.Select(it => it.ToMap()) }
        };
    }
}