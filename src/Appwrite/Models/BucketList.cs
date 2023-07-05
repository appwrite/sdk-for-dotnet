
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class BucketList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("buckets")]
        public List<Bucket> Buckets { get; private set; }

        public BucketList(
            long total,
            List<Bucket> buckets
        ) {
            Total = total;
            Buckets = buckets;
        }

        public static BucketList From(Dictionary<string, object> map) => new BucketList(
            total: Convert.ToInt64(map["total"]),
            buckets: ((JArray)map["buckets"]).ToObject<List<Dictionary<string, object>>>().Select(it => Bucket.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "buckets", Buckets.Select(it => it.ToMap()) }
        };
    }
}