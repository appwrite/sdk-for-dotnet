
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class UsageBuckets
    {
        [JsonPropertyName("range")]
        public string Range { get; private set; }

        [JsonPropertyName("filesTotal")]
        public long FilesTotal { get; private set; }

        [JsonPropertyName("filesStorageTotal")]
        public long FilesStorageTotal { get; private set; }

        [JsonPropertyName("files")]
        public List<Metric> Files { get; private set; }

        [JsonPropertyName("storage")]
        public List<Metric> Storage { get; private set; }

        [JsonPropertyName("imageTransformations")]
        public List<Metric> ImageTransformations { get; private set; }

        [JsonPropertyName("imageTransformationsTotal")]
        public long ImageTransformationsTotal { get; private set; }

        public UsageBuckets(
            string range,
            long filesTotal,
            long filesStorageTotal,
            List<Metric> files,
            List<Metric> storage,
            List<Metric> imageTransformations,
            long imageTransformationsTotal
        ) {
            Range = range;
            FilesTotal = filesTotal;
            FilesStorageTotal = filesStorageTotal;
            Files = files;
            Storage = storage;
            ImageTransformations = imageTransformations;
            ImageTransformationsTotal = imageTransformationsTotal;
        }

        public static UsageBuckets From(Dictionary<string, object> map) => new UsageBuckets(
            range: map["range"].ToString(),
            filesTotal: Convert.ToInt64(map["filesTotal"]),
            filesStorageTotal: Convert.ToInt64(map["filesStorageTotal"]),
            files: map["files"] is JsonElement jsonArray4 ? jsonArray4.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["files"]).Select(it => Metric.From(map: it)).ToList(),
            storage: map["storage"] is JsonElement jsonArray5 ? jsonArray5.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["storage"]).Select(it => Metric.From(map: it)).ToList(),
            imageTransformations: map["imageTransformations"] is JsonElement jsonArray6 ? jsonArray6.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["imageTransformations"]).Select(it => Metric.From(map: it)).ToList(),
            imageTransformationsTotal: Convert.ToInt64(map["imageTransformationsTotal"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "range", Range },
            { "filesTotal", FilesTotal },
            { "filesStorageTotal", FilesStorageTotal },
            { "files", Files.Select(it => it.ToMap()) },
            { "storage", Storage.Select(it => it.ToMap()) },
            { "imageTransformations", ImageTransformations.Select(it => it.ToMap()) },
            { "imageTransformationsTotal", ImageTransformationsTotal }
        };
    }
}
