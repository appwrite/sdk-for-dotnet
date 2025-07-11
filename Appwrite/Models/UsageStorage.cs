
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class UsageStorage
    {
        [JsonPropertyName("range")]
        public string Range { get; private set; }

        [JsonPropertyName("bucketsTotal")]
        public long BucketsTotal { get; private set; }

        [JsonPropertyName("filesTotal")]
        public long FilesTotal { get; private set; }

        [JsonPropertyName("filesStorageTotal")]
        public long FilesStorageTotal { get; private set; }

        [JsonPropertyName("buckets")]
        public List<Metric> Buckets { get; private set; }

        [JsonPropertyName("files")]
        public List<Metric> Files { get; private set; }

        [JsonPropertyName("storage")]
        public List<Metric> Storage { get; private set; }

        public UsageStorage(
            string range,
            long bucketsTotal,
            long filesTotal,
            long filesStorageTotal,
            List<Metric> buckets,
            List<Metric> files,
            List<Metric> storage
        ) {
            Range = range;
            BucketsTotal = bucketsTotal;
            FilesTotal = filesTotal;
            FilesStorageTotal = filesStorageTotal;
            Buckets = buckets;
            Files = files;
            Storage = storage;
        }

        public static UsageStorage From(Dictionary<string, object> map) => new UsageStorage(
            range: map["range"].ToString(),
            bucketsTotal: Convert.ToInt64(map["bucketsTotal"]),
            filesTotal: Convert.ToInt64(map["filesTotal"]),
            filesStorageTotal: Convert.ToInt64(map["filesStorageTotal"]),
            buckets: map["buckets"] is JsonElement jsonArray5 ? jsonArray5.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["buckets"]).Select(it => Metric.From(map: it)).ToList(),
            files: map["files"] is JsonElement jsonArray6 ? jsonArray6.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["files"]).Select(it => Metric.From(map: it)).ToList(),
            storage: map["storage"] is JsonElement jsonArray7 ? jsonArray7.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["storage"]).Select(it => Metric.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "range", Range },
            { "bucketsTotal", BucketsTotal },
            { "filesTotal", FilesTotal },
            { "filesStorageTotal", FilesStorageTotal },
            { "buckets", Buckets.Select(it => it.ToMap()) },
            { "files", Files.Select(it => it.ToMap()) },
            { "storage", Storage.Select(it => it.ToMap()) }
        };
    }
}
