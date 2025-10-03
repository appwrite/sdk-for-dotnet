using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class BucketList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("buckets")]
        public List&lt;Bucket&gt; Buckets { get; private set; }

        public BucketList(
            long total,
            List&lt;Bucket&gt; buckets
        ) {
            Total = total;
            Buckets = buckets;
        }

        public static BucketList From(Dictionary<string, object> map) => new BucketList(
            total: Convert.ToInt64(map["total"]),
            buckets: map["buckets"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Bucket.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["buckets"]).Select(it => Bucket.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "buckets", Buckets.Select(it => it.ToMap()) }
        };
    }
}
