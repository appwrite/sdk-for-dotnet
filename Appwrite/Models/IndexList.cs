
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class IndexList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("indexes")]
        public List<Index> Indexes { get; private set; }

        public IndexList(
            long total,
            List<Index> indexes
        ) {
            Total = total;
            Indexes = indexes;
        }

        public static IndexList From(Dictionary<string, object> map) => new IndexList(
            total: Convert.ToInt64(map["total"]),
            indexes: map["indexes"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Index.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["indexes"]).Select(it => Index.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "indexes", Indexes.Select(it => it.ToMap()) }
        };
    }
}
