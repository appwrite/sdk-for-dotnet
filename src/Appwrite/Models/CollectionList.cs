
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class CollectionList
    {
        [JsonProperty("sum")]
        public int Sum { get; set; }

        [JsonProperty("collections")]
        public List<Collection> Collections { get; set; }


        public CollectionList(
            int sum,
            List<Collection> collections
        ) {
            Sum = sum;
            Collections = collections;
        }

        public static CollectionList From(Dictionary<string, object> map) => new CollectionList(
            sum: (int)map["sum"],
            collections: ((JArray)map["collections"]).ToObject<List<Collection>>()!
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "sum", Sum },
            { "collections", Collections.Select(it => it.ToMap()) }
        };
    }
}