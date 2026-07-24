
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseReplicas
    {
        [JsonPropertyName("replicas")]
        public long Replicas { get; private set; }

        [JsonPropertyName("syncMode")]
        public string SyncMode { get; private set; }

        [JsonPropertyName("members")]
        public List<DedicatedDatabaseMember> Members { get; private set; }

        public DedicatedDatabaseReplicas(
            long replicas,
            string syncMode,
            List<DedicatedDatabaseMember> members
        )
        {
            Replicas = replicas;
            SyncMode = syncMode;
            Members = members;
        }

        public static DedicatedDatabaseReplicas From(Dictionary<string, object> map) => new DedicatedDatabaseReplicas(
            replicas: Convert.ToInt64(map["replicas"]),
            syncMode: map["syncMode"].ToString(),
            members: map["members"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.DedicatedDatabaseMember.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "replicas", Replicas },
            { "syncMode", SyncMode },
            { "members", Members?.Select(it => it.ToMap()).ToList() }
        };
    }
}
