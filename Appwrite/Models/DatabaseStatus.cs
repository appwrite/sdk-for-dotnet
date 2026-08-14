
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DatabaseStatus
    {
        [JsonPropertyName("health")]
        public string Health { get; private set; }

        [JsonPropertyName("ready")]
        public bool Ready { get; private set; }

        [JsonPropertyName("engine")]
        public string Engine { get; private set; }

        [JsonPropertyName("version")]
        public string Version { get; private set; }

        [JsonPropertyName("uptime")]
        public long Uptime { get; private set; }

        [JsonPropertyName("connections")]
        public DatabaseStatusConnections Connections { get; private set; }

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

        [JsonPropertyName("replicas")]
        public List<DatabaseStatusReplica> Replicas { get; private set; }

        [JsonPropertyName("volumes")]
        public List<DatabaseStatusVolume> Volumes { get; private set; }

        public DatabaseStatus(
            string health,
            bool ready,
            string engine,
            string version,
            long uptime,
            DatabaseStatusConnections connections,
            string syncMode,
            string? effectiveSyncMode,
            bool syncDegraded,
            long syncAcknowledgements,
            long syncStandbyCount,
            bool? syncStateConfirmed,
            List<DatabaseStatusReplica> replicas,
            List<DatabaseStatusVolume> volumes
        )
        {
            Health = health;
            Ready = ready;
            Engine = engine;
            Version = version;
            Uptime = uptime;
            Connections = connections;
            SyncMode = syncMode;
            EffectiveSyncMode = effectiveSyncMode;
            SyncDegraded = syncDegraded;
            SyncAcknowledgements = syncAcknowledgements;
            SyncStandbyCount = syncStandbyCount;
            SyncStateConfirmed = syncStateConfirmed;
            Replicas = replicas;
            Volumes = volumes;
        }

        public static DatabaseStatus From(Dictionary<string, object> map) => new DatabaseStatus(
            health: map["health"].ToString(),
            ready: (bool)map["ready"],
            engine: map["engine"].ToString(),
            version: map["version"].ToString(),
            uptime: Convert.ToInt64(map["uptime"]),
            connections: Appwrite.Models.DatabaseStatusConnections.From(map: map["connections"] is JsonElement jsonObj6 ? jsonObj6.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["connections"]),
            syncMode: map["syncMode"].ToString(),
            effectiveSyncMode: map.TryGetValue("effectiveSyncMode", out var effectiveSyncMode) ? effectiveSyncMode?.ToString() : null,
            syncDegraded: (bool)map["syncDegraded"],
            syncAcknowledgements: Convert.ToInt64(map["syncAcknowledgements"]),
            syncStandbyCount: Convert.ToInt64(map["syncStandbyCount"]),
            syncStateConfirmed: map.TryGetValue("syncStateConfirmed", out var boolRaw12) && boolRaw12 != null
                                        ? (bool?)boolRaw12
                                        : null,
            replicas: map["replicas"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.DatabaseStatusReplica.From(map: it)).ToList(),
            volumes: map["volumes"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.DatabaseStatusVolume.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "health", Health },
            { "ready", Ready },
            { "engine", Engine },
            { "version", Version },
            { "uptime", Uptime },
            { "connections", Connections?.ToMap() },
            { "syncMode", SyncMode },
            { "effectiveSyncMode", EffectiveSyncMode },
            { "syncDegraded", SyncDegraded },
            { "syncAcknowledgements", SyncAcknowledgements },
            { "syncStandbyCount", SyncStandbyCount },
            { "syncStateConfirmed", SyncStateConfirmed },
            { "replicas", Replicas?.Select(it => it.ToMap()).ToList() },
            { "volumes", Volumes?.Select(it => it.ToMap()).ToList() }
        };
    }
}
