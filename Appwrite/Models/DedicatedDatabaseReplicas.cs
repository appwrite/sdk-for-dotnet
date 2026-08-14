
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

        [JsonPropertyName("effectiveSyncMode")]
        public string? EffectiveSyncMode { get; private set; }

        [JsonPropertyName("syncDegraded")]
        public bool SyncDegraded { get; private set; }

        [JsonPropertyName("syncAcknowledgements")]
        public long SyncAcknowledgements { get; private set; }

        [JsonPropertyName("syncStandbyCount")]
        public long SyncStandbyCount { get; private set; }

        [JsonPropertyName("syncStateConfirmed")]
        public bool? SyncStateConfirmed { get; private set; }

        [JsonPropertyName("members")]
        public List<DedicatedDatabaseMember> Members { get; private set; }

        public DedicatedDatabaseReplicas(
            long replicas,
            string syncMode,
            string? effectiveSyncMode,
            bool syncDegraded,
            long syncAcknowledgements,
            long syncStandbyCount,
            bool? syncStateConfirmed,
            List<DedicatedDatabaseMember> members
        )
        {
            Replicas = replicas;
            SyncMode = syncMode;
            EffectiveSyncMode = effectiveSyncMode;
            SyncDegraded = syncDegraded;
            SyncAcknowledgements = syncAcknowledgements;
            SyncStandbyCount = syncStandbyCount;
            SyncStateConfirmed = syncStateConfirmed;
            Members = members;
        }

        public static DedicatedDatabaseReplicas From(Dictionary<string, object> map) => new DedicatedDatabaseReplicas(
            replicas: Convert.ToInt64(map["replicas"]),
            syncMode: map["syncMode"].ToString(),
            effectiveSyncMode: map.TryGetValue("effectiveSyncMode", out var effectiveSyncMode) ? effectiveSyncMode?.ToString() : null,
            syncDegraded: (bool)map["syncDegraded"],
            syncAcknowledgements: Convert.ToInt64(map["syncAcknowledgements"]),
            syncStandbyCount: Convert.ToInt64(map["syncStandbyCount"]),
            syncStateConfirmed: map.TryGetValue("syncStateConfirmed", out var boolRaw7) && boolRaw7 != null
                                        ? (bool?)boolRaw7
                                        : null,
            members: map["members"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.DedicatedDatabaseMember.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "replicas", Replicas },
            { "syncMode", SyncMode },
            { "effectiveSyncMode", EffectiveSyncMode },
            { "syncDegraded", SyncDegraded },
            { "syncAcknowledgements", SyncAcknowledgements },
            { "syncStandbyCount", SyncStandbyCount },
            { "syncStateConfirmed", SyncStateConfirmed },
            { "members", Members?.Select(it => it.ToMap()).ToList() }
        };
    }
}
