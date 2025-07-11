
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class UsageDatabases
    {
        [JsonPropertyName("range")]
        public string Range { get; private set; }

        [JsonPropertyName("databasesTotal")]
        public long DatabasesTotal { get; private set; }

        [JsonPropertyName("collectionsTotal")]
        public long CollectionsTotal { get; private set; }

        [JsonPropertyName("documentsTotal")]
        public long DocumentsTotal { get; private set; }

        [JsonPropertyName("storageTotal")]
        public long StorageTotal { get; private set; }

        [JsonPropertyName("databasesReadsTotal")]
        public long DatabasesReadsTotal { get; private set; }

        [JsonPropertyName("databasesWritesTotal")]
        public long DatabasesWritesTotal { get; private set; }

        [JsonPropertyName("databases")]
        public List<Metric> Databases { get; private set; }

        [JsonPropertyName("collections")]
        public List<Metric> Collections { get; private set; }

        [JsonPropertyName("documents")]
        public List<Metric> Documents { get; private set; }

        [JsonPropertyName("storage")]
        public List<Metric> Storage { get; private set; }

        [JsonPropertyName("databasesReads")]
        public List<Metric> DatabasesReads { get; private set; }

        [JsonPropertyName("databasesWrites")]
        public List<Metric> DatabasesWrites { get; private set; }

        public UsageDatabases(
            string range,
            long databasesTotal,
            long collectionsTotal,
            long documentsTotal,
            long storageTotal,
            long databasesReadsTotal,
            long databasesWritesTotal,
            List<Metric> databases,
            List<Metric> collections,
            List<Metric> documents,
            List<Metric> storage,
            List<Metric> databasesReads,
            List<Metric> databasesWrites
        ) {
            Range = range;
            DatabasesTotal = databasesTotal;
            CollectionsTotal = collectionsTotal;
            DocumentsTotal = documentsTotal;
            StorageTotal = storageTotal;
            DatabasesReadsTotal = databasesReadsTotal;
            DatabasesWritesTotal = databasesWritesTotal;
            Databases = databases;
            Collections = collections;
            Documents = documents;
            Storage = storage;
            DatabasesReads = databasesReads;
            DatabasesWrites = databasesWrites;
        }

        public static UsageDatabases From(Dictionary<string, object> map) => new UsageDatabases(
            range: map["range"].ToString(),
            databasesTotal: Convert.ToInt64(map["databasesTotal"]),
            collectionsTotal: Convert.ToInt64(map["collectionsTotal"]),
            documentsTotal: Convert.ToInt64(map["documentsTotal"]),
            storageTotal: Convert.ToInt64(map["storageTotal"]),
            databasesReadsTotal: Convert.ToInt64(map["databasesReadsTotal"]),
            databasesWritesTotal: Convert.ToInt64(map["databasesWritesTotal"]),
            databases: map["databases"] is JsonElement jsonArray8 ? jsonArray8.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["databases"]).Select(it => Metric.From(map: it)).ToList(),
            collections: map["collections"] is JsonElement jsonArray9 ? jsonArray9.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["collections"]).Select(it => Metric.From(map: it)).ToList(),
            documents: map["documents"] is JsonElement jsonArray10 ? jsonArray10.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["documents"]).Select(it => Metric.From(map: it)).ToList(),
            storage: map["storage"] is JsonElement jsonArray11 ? jsonArray11.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["storage"]).Select(it => Metric.From(map: it)).ToList(),
            databasesReads: map["databasesReads"] is JsonElement jsonArray12 ? jsonArray12.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["databasesReads"]).Select(it => Metric.From(map: it)).ToList(),
            databasesWrites: map["databasesWrites"] is JsonElement jsonArray13 ? jsonArray13.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["databasesWrites"]).Select(it => Metric.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "range", Range },
            { "databasesTotal", DatabasesTotal },
            { "collectionsTotal", CollectionsTotal },
            { "documentsTotal", DocumentsTotal },
            { "storageTotal", StorageTotal },
            { "databasesReadsTotal", DatabasesReadsTotal },
            { "databasesWritesTotal", DatabasesWritesTotal },
            { "databases", Databases.Select(it => it.ToMap()) },
            { "collections", Collections.Select(it => it.ToMap()) },
            { "documents", Documents.Select(it => it.ToMap()) },
            { "storage", Storage.Select(it => it.ToMap()) },
            { "databasesReads", DatabasesReads.Select(it => it.ToMap()) },
            { "databasesWrites", DatabasesWrites.Select(it => it.ToMap()) }
        };
    }
}
