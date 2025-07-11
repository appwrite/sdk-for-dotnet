
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class UsageDatabase
    {
        [JsonPropertyName("range")]
        public string Range { get; private set; }

        [JsonPropertyName("collectionsTotal")]
        public long CollectionsTotal { get; private set; }

        [JsonPropertyName("documentsTotal")]
        public long DocumentsTotal { get; private set; }

        [JsonPropertyName("storageTotal")]
        public long StorageTotal { get; private set; }

        [JsonPropertyName("databaseReadsTotal")]
        public long DatabaseReadsTotal { get; private set; }

        [JsonPropertyName("databaseWritesTotal")]
        public long DatabaseWritesTotal { get; private set; }

        [JsonPropertyName("collections")]
        public List<Metric> Collections { get; private set; }

        [JsonPropertyName("documents")]
        public List<Metric> Documents { get; private set; }

        [JsonPropertyName("storage")]
        public List<Metric> Storage { get; private set; }

        [JsonPropertyName("databaseReads")]
        public List<Metric> DatabaseReads { get; private set; }

        [JsonPropertyName("databaseWrites")]
        public List<Metric> DatabaseWrites { get; private set; }

        public UsageDatabase(
            string range,
            long collectionsTotal,
            long documentsTotal,
            long storageTotal,
            long databaseReadsTotal,
            long databaseWritesTotal,
            List<Metric> collections,
            List<Metric> documents,
            List<Metric> storage,
            List<Metric> databaseReads,
            List<Metric> databaseWrites
        ) {
            Range = range;
            CollectionsTotal = collectionsTotal;
            DocumentsTotal = documentsTotal;
            StorageTotal = storageTotal;
            DatabaseReadsTotal = databaseReadsTotal;
            DatabaseWritesTotal = databaseWritesTotal;
            Collections = collections;
            Documents = documents;
            Storage = storage;
            DatabaseReads = databaseReads;
            DatabaseWrites = databaseWrites;
        }

        public static UsageDatabase From(Dictionary<string, object> map) => new UsageDatabase(
            range: map["range"].ToString(),
            collectionsTotal: Convert.ToInt64(map["collectionsTotal"]),
            documentsTotal: Convert.ToInt64(map["documentsTotal"]),
            storageTotal: Convert.ToInt64(map["storageTotal"]),
            databaseReadsTotal: Convert.ToInt64(map["databaseReadsTotal"]),
            databaseWritesTotal: Convert.ToInt64(map["databaseWritesTotal"]),
            collections: map["collections"] is JsonElement jsonArray7 ? jsonArray7.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["collections"]).Select(it => Metric.From(map: it)).ToList(),
            documents: map["documents"] is JsonElement jsonArray8 ? jsonArray8.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["documents"]).Select(it => Metric.From(map: it)).ToList(),
            storage: map["storage"] is JsonElement jsonArray9 ? jsonArray9.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["storage"]).Select(it => Metric.From(map: it)).ToList(),
            databaseReads: map["databaseReads"] is JsonElement jsonArray10 ? jsonArray10.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["databaseReads"]).Select(it => Metric.From(map: it)).ToList(),
            databaseWrites: map["databaseWrites"] is JsonElement jsonArray11 ? jsonArray11.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["databaseWrites"]).Select(it => Metric.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "range", Range },
            { "collectionsTotal", CollectionsTotal },
            { "documentsTotal", DocumentsTotal },
            { "storageTotal", StorageTotal },
            { "databaseReadsTotal", DatabaseReadsTotal },
            { "databaseWritesTotal", DatabaseWritesTotal },
            { "collections", Collections.Select(it => it.ToMap()) },
            { "documents", Documents.Select(it => it.ToMap()) },
            { "storage", Storage.Select(it => it.ToMap()) },
            { "databaseReads", DatabaseReads.Select(it => it.ToMap()) },
            { "databaseWrites", DatabaseWrites.Select(it => it.ToMap()) }
        };
    }
}
