
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class CollectionList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("collections")]
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
            collections: ((JArray)map["collections"]).ToObject<List<Dictionary<string, object>>>().Select(it => Collection.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "collections", Collections.Select(it => it.ToMap()) }
        };
    }
}