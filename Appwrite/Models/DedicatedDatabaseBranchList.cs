
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseBranchList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("branches")]
        public List<DedicatedDatabaseBranch> Branches { get; private set; }

        public DedicatedDatabaseBranchList(
            long total,
            List<DedicatedDatabaseBranch> branches
        )
        {
            Total = total;
            Branches = branches;
        }

        public static DedicatedDatabaseBranchList From(Dictionary<string, object> map) => new DedicatedDatabaseBranchList(
            total: Convert.ToInt64(map["total"]),
            branches: map["branches"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.DedicatedDatabaseBranch.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "branches", Branches?.Select(it => it.ToMap()).ToList() }
        };
    }
}
