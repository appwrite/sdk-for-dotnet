
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class TopicList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("topics")]
        public List<Topic> Topics { get; private set; }

        public TopicList(
            long total,
            List<Topic> topics
        ) {
            Total = total;
            Topics = topics;
        }

        public static TopicList From(Dictionary<string, object> map) => new TopicList(
            total: Convert.ToInt64(map["total"]),
            topics: map["topics"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Topic.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["topics"]).Select(it => Topic.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "topics", Topics.Select(it => it.ToMap()) }
        };
    }
}
