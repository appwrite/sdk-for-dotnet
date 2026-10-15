
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class VectorsdbCollectionList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("collections")]
        public List<VectorsdbCollection> Collections { get; private set; }

        public VectorsdbCollectionList(
            long total,
            List<VectorsdbCollection> collections
        )
        {
            Total = total;
            Collections = collections;
        }

        public static VectorsdbCollectionList From(Dictionary<string, object> map) => new VectorsdbCollectionList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            collections: (map.ContainsKey("collections") ? map["collections"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.VectorsdbCollection.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "collections", Collections?.Select(it => it.ToMap()).ToList() }
        };
    }
}
