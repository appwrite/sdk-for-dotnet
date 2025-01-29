
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class TopicList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("topics")]
        public List<Topic> Topics { get; private set; }

        public TopicList(
            long total,
            List<Topic> topics
        ) {
            Total = total;
            Topics = topics;
        }

        public static TopicList From(Dictionary<string, object> map) => new TopicList(
            total: Convert.ToInt64(map["total"])
,
            topics: 
                        ((JArray)map["topics"])
                            .ToObject<List<Dictionary<string, object>>>()
                            .Select(it => Topic.From(map: it))
                            .ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "topics", Topics.Select(it => it.ToMap()) }
        };
    }
}