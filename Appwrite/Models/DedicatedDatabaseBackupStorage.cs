
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseBackupStorage
    {
        [JsonPropertyName("provider")]
        public string Provider { get; private set; }

        [JsonPropertyName("bucket")]
        public string Bucket { get; private set; }

        [JsonPropertyName("region")]
        public string Region { get; private set; }

        [JsonPropertyName("prefix")]
        public string Prefix { get; private set; }

        [JsonPropertyName("endpoint")]
        public string Endpoint { get; private set; }

        public DedicatedDatabaseBackupStorage(
            string provider,
            string bucket,
            string region,
            string prefix,
            string endpoint
        )
        {
            Provider = provider;
            Bucket = bucket;
            Region = region;
            Prefix = prefix;
            Endpoint = endpoint;
        }

        public static DedicatedDatabaseBackupStorage From(Dictionary<string, object> map) => new DedicatedDatabaseBackupStorage(
            provider: map["provider"].ToString(),
            bucket: map["bucket"].ToString(),
            region: map["region"].ToString(),
            prefix: map["prefix"].ToString(),
            endpoint: map["endpoint"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "provider", Provider },
            { "bucket", Bucket },
            { "region", Region },
            { "prefix", Prefix },
            { "endpoint", Endpoint }
        };
    }
}
