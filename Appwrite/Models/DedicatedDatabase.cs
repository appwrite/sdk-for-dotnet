
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabase
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("projectId")]
        public string ProjectId { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("api")]
        public string Api { get; private set; }

        [JsonPropertyName("engine")]
        public string Engine { get; private set; }

        [JsonPropertyName("version")]
        public string Version { get; private set; }

        [JsonPropertyName("specification")]
        public string Specification { get; private set; }

        [JsonPropertyName("backend")]
        public string Backend { get; private set; }

        [JsonPropertyName("hostname")]
        public string Hostname { get; private set; }

        [JsonPropertyName("connectionPort")]
        public long ConnectionPort { get; private set; }

        [JsonPropertyName("connectionUser")]
        public string ConnectionUser { get; private set; }

        [JsonPropertyName("connectionPassword")]
        public string ConnectionPassword { get; private set; }

        [JsonPropertyName("credentialGeneration")]
        public long CredentialGeneration { get; private set; }

        [JsonPropertyName("connectionString")]
        public string ConnectionString { get; private set; }

        [JsonPropertyName("ssl")]
        public bool Ssl { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        [JsonPropertyName("containerStatus")]
        public string ContainerStatus { get; private set; }

        [JsonPropertyName("lastAccessedAt")]
        public string? LastAccessedAt { get; private set; }

        [JsonPropertyName("idleUntil")]
        public string? IdleUntil { get; private set; }

        [JsonPropertyName("lifecycleState")]
        public string LifecycleState { get; private set; }

        [JsonPropertyName("idleTimeoutMinutes")]
        public long IdleTimeoutMinutes { get; private set; }

        [JsonPropertyName("cpu")]
        public long Cpu { get; private set; }

        [JsonPropertyName("memory")]
        public long Memory { get; private set; }

        [JsonPropertyName("storage")]
        public long Storage { get; private set; }

        [JsonPropertyName("storageClass")]
        public string StorageClass { get; private set; }

        [JsonPropertyName("storageMaxGb")]
        public long StorageMaxGb { get; private set; }

        [JsonPropertyName("nodePool")]
        public string NodePool { get; private set; }

        [JsonPropertyName("replicas")]
        public long Replicas { get; private set; }

        [JsonPropertyName("syncMode")]
        public string SyncMode { get; private set; }

        [JsonPropertyName("networkMaxConnections")]
        public long NetworkMaxConnections { get; private set; }

        [JsonPropertyName("networkIdleTimeoutSeconds")]
        public long NetworkIdleTimeoutSeconds { get; private set; }

        [JsonPropertyName("networkIPAllowlist")]
        public List<string> NetworkIPAllowlist { get; private set; }

        [JsonPropertyName("backupEnabled")]
        public bool BackupEnabled { get; private set; }

        [JsonPropertyName("pitr")]
        public bool Pitr { get; private set; }

        [JsonPropertyName("pitrRetentionDays")]
        public long PitrRetentionDays { get; private set; }

        [JsonPropertyName("storageAutoscaling")]
        public bool StorageAutoscaling { get; private set; }

        [JsonPropertyName("storageAutoscalingThresholdPercent")]
        public long StorageAutoscalingThresholdPercent { get; private set; }

        [JsonPropertyName("storageAutoscalingMaxGb")]
        public long StorageAutoscalingMaxGb { get; private set; }

        [JsonPropertyName("maintenanceWindowDay")]
        public string MaintenanceWindowDay { get; private set; }

        [JsonPropertyName("maintenanceWindowHourUtc")]
        public long MaintenanceWindowHourUtc { get; private set; }

        [JsonPropertyName("metricsEnabled")]
        public bool MetricsEnabled { get; private set; }

        [JsonPropertyName("sqlApiEnabled")]
        public bool SqlApiEnabled { get; private set; }

        [JsonPropertyName("sqlApiAllowedStatements")]
        public List<string> SqlApiAllowedStatements { get; private set; }

        [JsonPropertyName("sqlApiMaxRows")]
        public long SqlApiMaxRows { get; private set; }

        [JsonPropertyName("sqlApiMaxBytes")]
        public long SqlApiMaxBytes { get; private set; }

        [JsonPropertyName("sqlApiTimeoutSeconds")]
        public long SqlApiTimeoutSeconds { get; private set; }

        [JsonPropertyName("error")]
        public string Error { get; private set; }

        public DedicatedDatabase(
            string id,
            string createdAt,
            string updatedAt,
            string projectId,
            string name,
            string api,
            string engine,
            string version,
            string specification,
            string backend,
            string hostname,
            long connectionPort,
            string connectionUser,
            string connectionPassword,
            long credentialGeneration,
            string connectionString,
            bool ssl,
            string status,
            string containerStatus,
            string? lastAccessedAt,
            string? idleUntil,
            string lifecycleState,
            long idleTimeoutMinutes,
            long cpu,
            long memory,
            long storage,
            string storageClass,
            long storageMaxGb,
            string nodePool,
            long replicas,
            string syncMode,
            long networkMaxConnections,
            long networkIdleTimeoutSeconds,
            List<string> networkIPAllowlist,
            bool backupEnabled,
            bool pitr,
            long pitrRetentionDays,
            bool storageAutoscaling,
            long storageAutoscalingThresholdPercent,
            long storageAutoscalingMaxGb,
            string maintenanceWindowDay,
            long maintenanceWindowHourUtc,
            bool metricsEnabled,
            bool sqlApiEnabled,
            List<string> sqlApiAllowedStatements,
            long sqlApiMaxRows,
            long sqlApiMaxBytes,
            long sqlApiTimeoutSeconds,
            string error
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ProjectId = projectId;
            Name = name;
            Api = api;
            Engine = engine;
            Version = version;
            Specification = specification;
            Backend = backend;
            Hostname = hostname;
            ConnectionPort = connectionPort;
            ConnectionUser = connectionUser;
            ConnectionPassword = connectionPassword;
            CredentialGeneration = credentialGeneration;
            ConnectionString = connectionString;
            Ssl = ssl;
            Status = status;
            ContainerStatus = containerStatus;
            LastAccessedAt = lastAccessedAt;
            IdleUntil = idleUntil;
            LifecycleState = lifecycleState;
            IdleTimeoutMinutes = idleTimeoutMinutes;
            Cpu = cpu;
            Memory = memory;
            Storage = storage;
            StorageClass = storageClass;
            StorageMaxGb = storageMaxGb;
            NodePool = nodePool;
            Replicas = replicas;
            SyncMode = syncMode;
            NetworkMaxConnections = networkMaxConnections;
            NetworkIdleTimeoutSeconds = networkIdleTimeoutSeconds;
            NetworkIPAllowlist = networkIPAllowlist;
            BackupEnabled = backupEnabled;
            Pitr = pitr;
            PitrRetentionDays = pitrRetentionDays;
            StorageAutoscaling = storageAutoscaling;
            StorageAutoscalingThresholdPercent = storageAutoscalingThresholdPercent;
            StorageAutoscalingMaxGb = storageAutoscalingMaxGb;
            MaintenanceWindowDay = maintenanceWindowDay;
            MaintenanceWindowHourUtc = maintenanceWindowHourUtc;
            MetricsEnabled = metricsEnabled;
            SqlApiEnabled = sqlApiEnabled;
            SqlApiAllowedStatements = sqlApiAllowedStatements;
            SqlApiMaxRows = sqlApiMaxRows;
            SqlApiMaxBytes = sqlApiMaxBytes;
            SqlApiTimeoutSeconds = sqlApiTimeoutSeconds;
            Error = error;
        }

        public static DedicatedDatabase From(Dictionary<string, object> map) => new DedicatedDatabase(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            projectId: map["projectId"].ToString(),
            name: map["name"].ToString(),
            api: map["api"].ToString(),
            engine: map["engine"].ToString(),
            version: map["version"].ToString(),
            specification: map["specification"].ToString(),
            backend: map["backend"].ToString(),
            hostname: map["hostname"].ToString(),
            connectionPort: Convert.ToInt64(map["connectionPort"]),
            connectionUser: map["connectionUser"].ToString(),
            connectionPassword: map["connectionPassword"].ToString(),
            credentialGeneration: Convert.ToInt64(map["credentialGeneration"]),
            connectionString: map["connectionString"].ToString(),
            ssl: (bool)map["ssl"],
            status: map["status"].ToString(),
            containerStatus: map["containerStatus"].ToString(),
            lastAccessedAt: map.TryGetValue("lastAccessedAt", out var lastAccessedAt) ? lastAccessedAt?.ToString() : null,
            idleUntil: map.TryGetValue("idleUntil", out var idleUntil) ? idleUntil?.ToString() : null,
            lifecycleState: map["lifecycleState"].ToString(),
            idleTimeoutMinutes: Convert.ToInt64(map["idleTimeoutMinutes"]),
            cpu: Convert.ToInt64(map["cpu"]),
            memory: Convert.ToInt64(map["memory"]),
            storage: Convert.ToInt64(map["storage"]),
            storageClass: map["storageClass"].ToString(),
            storageMaxGb: Convert.ToInt64(map["storageMaxGb"]),
            nodePool: map["nodePool"].ToString(),
            replicas: Convert.ToInt64(map["replicas"]),
            syncMode: map["syncMode"].ToString(),
            networkMaxConnections: Convert.ToInt64(map["networkMaxConnections"]),
            networkIdleTimeoutSeconds: Convert.ToInt64(map["networkIdleTimeoutSeconds"]),
            networkIPAllowlist: map["networkIPAllowlist"].ConvertToList<string>(),
            backupEnabled: (bool)map["backupEnabled"],
            pitr: (bool)map["pitr"],
            pitrRetentionDays: Convert.ToInt64(map["pitrRetentionDays"]),
            storageAutoscaling: (bool)map["storageAutoscaling"],
            storageAutoscalingThresholdPercent: Convert.ToInt64(map["storageAutoscalingThresholdPercent"]),
            storageAutoscalingMaxGb: Convert.ToInt64(map["storageAutoscalingMaxGb"]),
            maintenanceWindowDay: map["maintenanceWindowDay"].ToString(),
            maintenanceWindowHourUtc: Convert.ToInt64(map["maintenanceWindowHourUtc"]),
            metricsEnabled: (bool)map["metricsEnabled"],
            sqlApiEnabled: (bool)map["sqlApiEnabled"],
            sqlApiAllowedStatements: map["sqlApiAllowedStatements"].ConvertToList<string>(),
            sqlApiMaxRows: Convert.ToInt64(map["sqlApiMaxRows"]),
            sqlApiMaxBytes: Convert.ToInt64(map["sqlApiMaxBytes"]),
            sqlApiTimeoutSeconds: Convert.ToInt64(map["sqlApiTimeoutSeconds"]),
            error: map["error"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "projectId", ProjectId },
            { "name", Name },
            { "api", Api },
            { "engine", Engine },
            { "version", Version },
            { "specification", Specification },
            { "backend", Backend },
            { "hostname", Hostname },
            { "connectionPort", ConnectionPort },
            { "connectionUser", ConnectionUser },
            { "connectionPassword", ConnectionPassword },
            { "credentialGeneration", CredentialGeneration },
            { "connectionString", ConnectionString },
            { "ssl", Ssl },
            { "status", Status },
            { "containerStatus", ContainerStatus },
            { "lastAccessedAt", LastAccessedAt },
            { "idleUntil", IdleUntil },
            { "lifecycleState", LifecycleState },
            { "idleTimeoutMinutes", IdleTimeoutMinutes },
            { "cpu", Cpu },
            { "memory", Memory },
            { "storage", Storage },
            { "storageClass", StorageClass },
            { "storageMaxGb", StorageMaxGb },
            { "nodePool", NodePool },
            { "replicas", Replicas },
            { "syncMode", SyncMode },
            { "networkMaxConnections", NetworkMaxConnections },
            { "networkIdleTimeoutSeconds", NetworkIdleTimeoutSeconds },
            { "networkIPAllowlist", NetworkIPAllowlist },
            { "backupEnabled", BackupEnabled },
            { "pitr", Pitr },
            { "pitrRetentionDays", PitrRetentionDays },
            { "storageAutoscaling", StorageAutoscaling },
            { "storageAutoscalingThresholdPercent", StorageAutoscalingThresholdPercent },
            { "storageAutoscalingMaxGb", StorageAutoscalingMaxGb },
            { "maintenanceWindowDay", MaintenanceWindowDay },
            { "maintenanceWindowHourUtc", MaintenanceWindowHourUtc },
            { "metricsEnabled", MetricsEnabled },
            { "sqlApiEnabled", SqlApiEnabled },
            { "sqlApiAllowedStatements", SqlApiAllowedStatements },
            { "sqlApiMaxRows", SqlApiMaxRows },
            { "sqlApiMaxBytes", SqlApiMaxBytes },
            { "sqlApiTimeoutSeconds", SqlApiTimeoutSeconds },
            { "error", Error }
        };
    }
}
