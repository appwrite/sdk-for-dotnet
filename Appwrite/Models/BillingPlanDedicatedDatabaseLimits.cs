
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class BillingPlanDedicatedDatabaseLimits
    {
        [JsonPropertyName("minCpu")]
        public long? MinCpu { get; private set; }

        [JsonPropertyName("maxCpu")]
        public long? MaxCpu { get; private set; }

        [JsonPropertyName("minMemoryMb")]
        public long? MinMemoryMb { get; private set; }

        [JsonPropertyName("maxMemoryMb")]
        public long? MaxMemoryMb { get; private set; }

        [JsonPropertyName("minStorageGb")]
        public long? MinStorageGb { get; private set; }

        [JsonPropertyName("maxStorageGb")]
        public long? MaxStorageGb { get; private set; }

        [JsonPropertyName("maxReplicas")]
        public long? MaxReplicas { get; private set; }

        [JsonPropertyName("maxConnections")]
        public long? MaxConnections { get; private set; }

        [JsonPropertyName("maxIpAllowlistSize")]
        public long? MaxIpAllowlistSize { get; private set; }

        [JsonPropertyName("maxExtensions")]
        public long? MaxExtensions { get; private set; }

        [JsonPropertyName("maxBackupRetentionDays")]
        public long? MaxBackupRetentionDays { get; private set; }

        [JsonPropertyName("maxPitrRetentionDays")]
        public long? MaxPitrRetentionDays { get; private set; }

        [JsonPropertyName("maxSqlApiMaxRows")]
        public long? MaxSqlApiMaxRows { get; private set; }

        [JsonPropertyName("maxSqlApiMaxBytes")]
        public long? MaxSqlApiMaxBytes { get; private set; }

        [JsonPropertyName("maxSqlApiTimeoutSeconds")]
        public long? MaxSqlApiTimeoutSeconds { get; private set; }

        [JsonPropertyName("maxSqlApiAllowedStatements")]
        public long? MaxSqlApiAllowedStatements { get; private set; }

        [JsonPropertyName("allowedSqlStatements")]
        public List<string>? AllowedSqlStatements { get; private set; }

        [JsonPropertyName("allowedStorageClasses")]
        public List<string>? AllowedStorageClasses { get; private set; }

        [JsonPropertyName("allowedSyncModes")]
        public List<string>? AllowedSyncModes { get; private set; }

        public BillingPlanDedicatedDatabaseLimits(
            long? minCpu,
            long? maxCpu,
            long? minMemoryMb,
            long? maxMemoryMb,
            long? minStorageGb,
            long? maxStorageGb,
            long? maxReplicas,
            long? maxConnections,
            long? maxIpAllowlistSize,
            long? maxExtensions,
            long? maxBackupRetentionDays,
            long? maxPitrRetentionDays,
            long? maxSqlApiMaxRows,
            long? maxSqlApiMaxBytes,
            long? maxSqlApiTimeoutSeconds,
            long? maxSqlApiAllowedStatements,
            List<string>? allowedSqlStatements,
            List<string>? allowedStorageClasses,
            List<string>? allowedSyncModes
        )
        {
            MinCpu = minCpu;
            MaxCpu = maxCpu;
            MinMemoryMb = minMemoryMb;
            MaxMemoryMb = maxMemoryMb;
            MinStorageGb = minStorageGb;
            MaxStorageGb = maxStorageGb;
            MaxReplicas = maxReplicas;
            MaxConnections = maxConnections;
            MaxIpAllowlistSize = maxIpAllowlistSize;
            MaxExtensions = maxExtensions;
            MaxBackupRetentionDays = maxBackupRetentionDays;
            MaxPitrRetentionDays = maxPitrRetentionDays;
            MaxSqlApiMaxRows = maxSqlApiMaxRows;
            MaxSqlApiMaxBytes = maxSqlApiMaxBytes;
            MaxSqlApiTimeoutSeconds = maxSqlApiTimeoutSeconds;
            MaxSqlApiAllowedStatements = maxSqlApiAllowedStatements;
            AllowedSqlStatements = allowedSqlStatements;
            AllowedStorageClasses = allowedStorageClasses;
            AllowedSyncModes = allowedSyncModes;
        }

        public static BillingPlanDedicatedDatabaseLimits From(Dictionary<string, object> map) => new BillingPlanDedicatedDatabaseLimits(
            minCpu: map.TryGetValue("minCpu", out var numberRaw1) && numberRaw1 != null
                                    ? Convert.ToInt64(numberRaw1)
                                    : null,
            maxCpu: map.TryGetValue("maxCpu", out var numberRaw2) && numberRaw2 != null
                                    ? Convert.ToInt64(numberRaw2)
                                    : null,
            minMemoryMb: map.TryGetValue("minMemoryMb", out var numberRaw3) && numberRaw3 != null
                                    ? Convert.ToInt64(numberRaw3)
                                    : null,
            maxMemoryMb: map.TryGetValue("maxMemoryMb", out var numberRaw4) && numberRaw4 != null
                                    ? Convert.ToInt64(numberRaw4)
                                    : null,
            minStorageGb: map.TryGetValue("minStorageGb", out var numberRaw5) && numberRaw5 != null
                                    ? Convert.ToInt64(numberRaw5)
                                    : null,
            maxStorageGb: map.TryGetValue("maxStorageGb", out var numberRaw6) && numberRaw6 != null
                                    ? Convert.ToInt64(numberRaw6)
                                    : null,
            maxReplicas: map.TryGetValue("maxReplicas", out var numberRaw7) && numberRaw7 != null
                                    ? Convert.ToInt64(numberRaw7)
                                    : null,
            maxConnections: map.TryGetValue("maxConnections", out var numberRaw8) && numberRaw8 != null
                                    ? Convert.ToInt64(numberRaw8)
                                    : null,
            maxIpAllowlistSize: map.TryGetValue("maxIpAllowlistSize", out var numberRaw9) && numberRaw9 != null
                                    ? Convert.ToInt64(numberRaw9)
                                    : null,
            maxExtensions: map.TryGetValue("maxExtensions", out var numberRaw10) && numberRaw10 != null
                                    ? Convert.ToInt64(numberRaw10)
                                    : null,
            maxBackupRetentionDays: map.TryGetValue("maxBackupRetentionDays", out var numberRaw11) && numberRaw11 != null
                                    ? Convert.ToInt64(numberRaw11)
                                    : null,
            maxPitrRetentionDays: map.TryGetValue("maxPitrRetentionDays", out var numberRaw12) && numberRaw12 != null
                                    ? Convert.ToInt64(numberRaw12)
                                    : null,
            maxSqlApiMaxRows: map.TryGetValue("maxSqlApiMaxRows", out var numberRaw13) && numberRaw13 != null
                                    ? Convert.ToInt64(numberRaw13)
                                    : null,
            maxSqlApiMaxBytes: map.TryGetValue("maxSqlApiMaxBytes", out var numberRaw14) && numberRaw14 != null
                                    ? Convert.ToInt64(numberRaw14)
                                    : null,
            maxSqlApiTimeoutSeconds: map.TryGetValue("maxSqlApiTimeoutSeconds", out var numberRaw15) && numberRaw15 != null
                                    ? Convert.ToInt64(numberRaw15)
                                    : null,
            maxSqlApiAllowedStatements: map.TryGetValue("maxSqlApiAllowedStatements", out var numberRaw16) && numberRaw16 != null
                                    ? Convert.ToInt64(numberRaw16)
                                    : null,
            allowedSqlStatements: map.TryGetValue("allowedSqlStatements", out var arrayRaw17) && arrayRaw17 != null
                                ? arrayRaw17.ConvertToList<string>()
                                : null,
            allowedStorageClasses: map.TryGetValue("allowedStorageClasses", out var arrayRaw18) && arrayRaw18 != null
                                ? arrayRaw18.ConvertToList<string>()
                                : null,
            allowedSyncModes: map.TryGetValue("allowedSyncModes", out var arrayRaw19) && arrayRaw19 != null
                                ? arrayRaw19.ConvertToList<string>()
                                : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "minCpu", MinCpu },
            { "maxCpu", MaxCpu },
            { "minMemoryMb", MinMemoryMb },
            { "maxMemoryMb", MaxMemoryMb },
            { "minStorageGb", MinStorageGb },
            { "maxStorageGb", MaxStorageGb },
            { "maxReplicas", MaxReplicas },
            { "maxConnections", MaxConnections },
            { "maxIpAllowlistSize", MaxIpAllowlistSize },
            { "maxExtensions", MaxExtensions },
            { "maxBackupRetentionDays", MaxBackupRetentionDays },
            { "maxPitrRetentionDays", MaxPitrRetentionDays },
            { "maxSqlApiMaxRows", MaxSqlApiMaxRows },
            { "maxSqlApiMaxBytes", MaxSqlApiMaxBytes },
            { "maxSqlApiTimeoutSeconds", MaxSqlApiTimeoutSeconds },
            { "maxSqlApiAllowedStatements", MaxSqlApiAllowedStatements },
            { "allowedSqlStatements", AllowedSqlStatements },
            { "allowedStorageClasses", AllowedStorageClasses },
            { "allowedSyncModes", AllowedSyncModes }
        };
    }
}
