
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class UsageCollection
    {
        [JsonPropertyName("range")]
        public string Range { get; private set; }

        [JsonPropertyName("documentsTotal")]
        public long DocumentsTotal { get; private set; }

        [JsonPropertyName("documents")]
        public List<Metric> Documents { get; private set; }

        public UsageCollection(
            string range,
            long documentsTotal,
            List<Metric> documents
        ) {
            Range = range;
            DocumentsTotal = documentsTotal;
            Documents = documents;
        }

        public static UsageCollection From(Dictionary<string, object> map) => new UsageCollection(
            range: map["range"].ToString(),
            documentsTotal: Convert.ToInt64(map["documentsTotal"]),
            documents: map["documents"] is JsonElement jsonArray3 ? jsonArray3.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["documents"]).Select(it => Metric.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "range", Range },
            { "documentsTotal", DocumentsTotal },
            { "documents", Documents.Select(it => it.ToMap()) }
        };
    }
}
