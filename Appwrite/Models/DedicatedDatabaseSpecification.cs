
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
            bool enabled
        )
        {
            Slug = slug;
            Name = name;
            Price = price;
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
            enabled: (bool)map["enabled"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "slug", Slug },
            { "name", Name },
            { "price", Price },
            { "cpu", Cpu },
            { "memory", Memory },
            { "maxConnections", MaxConnections },
            { "includedStorage", IncludedStorage },
            { "includedBandwidth", IncludedBandwidth },
            { "enabled", Enabled }
        };
    }
}
