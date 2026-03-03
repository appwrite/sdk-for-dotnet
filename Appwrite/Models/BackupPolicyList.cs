
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class BackupPolicyList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("policies")]
        public List<BackupPolicy> Policies { get; private set; }

        public BackupPolicyList(
            long total,
            List<BackupPolicy> policies
        ) {
            Total = total;
            Policies = policies;
        }

        public static BackupPolicyList From(Dictionary<string, object> map) => new BackupPolicyList(
            total: Convert.ToInt64(map["total"]),
            policies: map["policies"].ConvertToList<Dictionary<string, object>>().Select(it => BackupPolicy.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "policies", Policies.Select(it => it.ToMap()) }
        };
    }
}
