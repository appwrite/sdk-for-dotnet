
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabasePooler
    {
        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("mode")]
        public string Mode { get; private set; }

        [JsonPropertyName("maxConnections")]
        public long MaxConnections { get; private set; }

        [JsonPropertyName("defaultPoolSize")]
        public long DefaultPoolSize { get; private set; }

        [JsonPropertyName("port")]
        public long Port { get; private set; }

        [JsonPropertyName("readWriteSplitting")]
        public bool ReadWriteSplitting { get; private set; }

        [JsonPropertyName("poolerCpuRequest")]
        public string PoolerCpuRequest { get; private set; }

        [JsonPropertyName("poolerCpuLimit")]
        public string PoolerCpuLimit { get; private set; }

        [JsonPropertyName("poolerMemoryRequest")]
        public string PoolerMemoryRequest { get; private set; }

        [JsonPropertyName("poolerMemoryLimit")]
        public string PoolerMemoryLimit { get; private set; }

        public DedicatedDatabasePooler(
            bool enabled,
            string mode,
            long maxConnections,
            long defaultPoolSize,
            long port,
            bool readWriteSplitting,
            string poolerCpuRequest,
            string poolerCpuLimit,
            string poolerMemoryRequest,
            string poolerMemoryLimit
        )
        {
            Enabled = enabled;
            Mode = mode;
            MaxConnections = maxConnections;
            DefaultPoolSize = defaultPoolSize;
            Port = port;
            ReadWriteSplitting = readWriteSplitting;
            PoolerCpuRequest = poolerCpuRequest;
            PoolerCpuLimit = poolerCpuLimit;
            PoolerMemoryRequest = poolerMemoryRequest;
            PoolerMemoryLimit = poolerMemoryLimit;
        }

        public static DedicatedDatabasePooler From(Dictionary<string, object> map) => new DedicatedDatabasePooler(
            enabled: (bool)map["enabled"],
            mode: map["mode"].ToString(),
            maxConnections: Convert.ToInt64(map["maxConnections"]),
            defaultPoolSize: Convert.ToInt64(map["defaultPoolSize"]),
            port: Convert.ToInt64(map["port"]),
            readWriteSplitting: (bool)map["readWriteSplitting"],
            poolerCpuRequest: map["poolerCpuRequest"].ToString(),
            poolerCpuLimit: map["poolerCpuLimit"].ToString(),
            poolerMemoryRequest: map["poolerMemoryRequest"].ToString(),
            poolerMemoryLimit: map["poolerMemoryLimit"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "enabled", Enabled },
            { "mode", Mode },
            { "maxConnections", MaxConnections },
            { "defaultPoolSize", DefaultPoolSize },
            { "port", Port },
            { "readWriteSplitting", ReadWriteSplitting },
            { "poolerCpuRequest", PoolerCpuRequest },
            { "poolerCpuLimit", PoolerCpuLimit },
            { "poolerMemoryRequest", PoolerMemoryRequest },
            { "poolerMemoryLimit", PoolerMemoryLimit }
        };
    }
}
