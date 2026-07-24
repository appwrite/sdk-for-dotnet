
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseSpecificationPricing
    {
        [JsonPropertyName("storageOverageRate")]
        public double StorageOverageRate { get; private set; }

        [JsonPropertyName("bandwidthOverageRate")]
        public double BandwidthOverageRate { get; private set; }

        [JsonPropertyName("replicaRate")]
        public double ReplicaRate { get; private set; }

        [JsonPropertyName("crossRegionReplicaRate")]
        public double CrossRegionReplicaRate { get; private set; }

        [JsonPropertyName("pitrRate")]
        public double PitrRate { get; private set; }

        public DedicatedDatabaseSpecificationPricing(
            double storageOverageRate,
            double bandwidthOverageRate,
            double replicaRate,
            double crossRegionReplicaRate,
            double pitrRate
        )
        {
            StorageOverageRate = storageOverageRate;
            BandwidthOverageRate = bandwidthOverageRate;
            ReplicaRate = replicaRate;
            CrossRegionReplicaRate = crossRegionReplicaRate;
            PitrRate = pitrRate;
        }

        public static DedicatedDatabaseSpecificationPricing From(Dictionary<string, object> map) => new DedicatedDatabaseSpecificationPricing(
            storageOverageRate: Convert.ToDouble(map["storageOverageRate"]),
            bandwidthOverageRate: Convert.ToDouble(map["bandwidthOverageRate"]),
            replicaRate: Convert.ToDouble(map["replicaRate"]),
            crossRegionReplicaRate: Convert.ToDouble(map["crossRegionReplicaRate"]),
            pitrRate: Convert.ToDouble(map["pitrRate"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "storageOverageRate", StorageOverageRate },
            { "bandwidthOverageRate", BandwidthOverageRate },
            { "replicaRate", ReplicaRate },
            { "crossRegionReplicaRate", CrossRegionReplicaRate },
            { "pitrRate", PitrRate }
        };
    }
}
