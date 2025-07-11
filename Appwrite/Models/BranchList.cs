
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class BranchList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("branches")]
        public List<Branch> Branches { get; private set; }

        public BranchList(
            long total,
            List<Branch> branches
        ) {
            Total = total;
            Branches = branches;
        }

        public static BranchList From(Dictionary<string, object> map) => new BranchList(
            total: Convert.ToInt64(map["total"]),
            branches: map["branches"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Branch.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["branches"]).Select(it => Branch.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "branches", Branches.Select(it => it.ToMap()) }
        };
    }
}
