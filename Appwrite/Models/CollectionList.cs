
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class CollectionList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("collections")]
        public List<Collection> Collections { get; private set; }

        public CollectionList(
            long total,
            List<Collection> collections
        ) {
            Total = total;
            Collections = collections;
        }

        public static CollectionList From(Dictionary<string, object> map) => new CollectionList(
            total: Convert.ToInt64(map["total"]),
            collections: map["collections"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Collection.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["collections"]).Select(it => Collection.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "collections", Collections.Select(it => it.ToMap()) }
        };
    }
}
