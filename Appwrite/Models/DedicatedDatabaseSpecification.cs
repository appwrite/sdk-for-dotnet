
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseSpecification
    {
        [JsonPropertyName("slug")]
        public string Slug { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("price")]
        public double Price { get; private set; }

        [JsonPropertyName("storageOverageRate")]
        public double? StorageOverageRate { get; private set; }

        [JsonPropertyName("bandwidthOverageRate")]
        public double? BandwidthOverageRate { get; private set; }

        [JsonPropertyName("replicaRate")]
        public double? ReplicaRate { get; private set; }

        [JsonPropertyName("pitrRate")]
        public double? PitrRate { get; private set; }

        [JsonPropertyName("cpu")]
        public long Cpu { get; private set; }

        [JsonPropertyName("memory")]
        public long Memory { get; private set; }

        [JsonPropertyName("maxConnections")]
        public long MaxConnections { get; private set; }

        [JsonPropertyName("includedStorage")]
        public long IncludedStorage { get; private set; }

        [JsonPropertyName("includedBandwidth")]
        public long IncludedBandwidth { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        public DedicatedDatabaseSpecification(
            string slug,
            string name,
            double price,
            long cpu,
            long memory,
            long maxConnections,
            long includedStorage,
            long includedBandwidth,
            bool enabled,
            double? storageOverageRate = null,
            double? bandwidthOverageRate = null,
            double? replicaRate = null,
            double? pitrRate = null
        )
        {
            Slug = slug;
            Name = name;
            Price = price;
            StorageOverageRate = storageOverageRate;
            BandwidthOverageRate = bandwidthOverageRate;
            ReplicaRate = replicaRate;
            PitrRate = pitrRate;
            Cpu = cpu;
            Memory = memory;
            MaxConnections = maxConnections;
            IncludedStorage = includedStorage;
            IncludedBandwidth = includedBandwidth;
            Enabled = enabled;
        }

        public static DedicatedDatabaseSpecification From(Dictionary<string, object> map) => new DedicatedDatabaseSpecification(
            slug: map["slug"].ToString(),
            name: map["name"].ToString(),
            price: Convert.ToDouble(map["price"]),
            cpu: Convert.ToInt64(map["cpu"]),
            memory: Convert.ToInt64(map["memory"]),
            maxConnections: Convert.ToInt64(map["maxConnections"]),
            includedStorage: Convert.ToInt64(map["includedStorage"]),
            includedBandwidth: Convert.ToInt64(map["includedBandwidth"]),
            enabled: (bool)map["enabled"],
            storageOverageRate: map.TryGetValue("storageOverageRate", out var numberRaw4Added) && numberRaw4Added != null
                                    ? Convert.ToDouble(numberRaw4Added)
                                    : null,
            bandwidthOverageRate: map.TryGetValue("bandwidthOverageRate", out var numberRaw5Added) && numberRaw5Added != null
                                    ? Convert.ToDouble(numberRaw5Added)
                                    : null,
            replicaRate: map.TryGetValue("replicaRate", out var numberRaw6Added) && numberRaw6Added != null
                                    ? Convert.ToDouble(numberRaw6Added)
                                    : null,
            pitrRate: map.TryGetValue("pitrRate", out var numberRaw7Added) && numberRaw7Added != null
                                    ? Convert.ToDouble(numberRaw7Added)
                                    : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "slug", Slug },
            { "name", Name },
            { "price", Price },
            { "storageOverageRate", StorageOverageRate },
            { "bandwidthOverageRate", BandwidthOverageRate },
            { "replicaRate", ReplicaRate },
            { "pitrRate", PitrRate },
            { "cpu", Cpu },
            { "memory", Memory },
            { "maxConnections", MaxConnections },
            { "includedStorage", IncludedStorage },
            { "includedBandwidth", IncludedBandwidth },
            { "enabled", Enabled }
        };
    }
}
