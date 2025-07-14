
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class SubscriberList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("subscribers")]
        public List<Subscriber> Subscribers { get; private set; }

        public SubscriberList(
            long total,
            List<Subscriber> subscribers
        ) {
            Total = total;
            Subscribers = subscribers;
        }

        public static SubscriberList From(Dictionary<string, object> map) => new SubscriberList(
            total: Convert.ToInt64(map["total"]),
            subscribers: map["subscribers"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Subscriber.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["subscribers"]).Select(it => Subscriber.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "subscribers", Subscribers.Select(it => it.ToMap()) }
        };
    }
}
