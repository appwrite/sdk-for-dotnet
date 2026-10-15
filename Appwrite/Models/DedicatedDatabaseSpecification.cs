
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
        public double StorageOverageRate { get; private set; }

        [JsonPropertyName("bandwidthOverageRate")]
        public double BandwidthOverageRate { get; private set; }

        [JsonPropertyName("replicaRate")]
        public double ReplicaRate { get; private set; }

        [JsonPropertyName("pitrRate")]
        public double PitrRate { get; private set; }

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
            double storageOverageRate,
            double bandwidthOverageRate,
            double replicaRate,
            double pitrRate,
            long cpu,
            long memory,
            long maxConnections,
            long includedStorage,
            long includedBandwidth,
            bool enabled
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
            slug: (map.ContainsKey("slug") ? map["slug"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            price: Convert.ToDouble((map.ContainsKey("price") ? map["price"] : 0)),
            storageOverageRate: Convert.ToDouble((map.ContainsKey("storageOverageRate") ? map["storageOverageRate"] : 0)),
            bandwidthOverageRate: Convert.ToDouble((map.ContainsKey("bandwidthOverageRate") ? map["bandwidthOverageRate"] : 0)),
            replicaRate: Convert.ToDouble((map.ContainsKey("replicaRate") ? map["replicaRate"] : 0)),
            pitrRate: Convert.ToDouble((map.ContainsKey("pitrRate") ? map["pitrRate"] : 0)),
            cpu: Convert.ToInt64((map.ContainsKey("cpu") ? map["cpu"] : 0)),
            memory: Convert.ToInt64((map.ContainsKey("memory") ? map["memory"] : 0)),
            maxConnections: Convert.ToInt64((map.ContainsKey("maxConnections") ? map["maxConnections"] : 0)),
            includedStorage: Convert.ToInt64((map.ContainsKey("includedStorage") ? map["includedStorage"] : 0)),
            includedBandwidth: Convert.ToInt64((map.ContainsKey("includedBandwidth") ? map["includedBandwidth"] : 0)),
            enabled: (bool)(map.ContainsKey("enabled") ? map["enabled"] : false)
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
