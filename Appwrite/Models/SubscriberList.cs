
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class SubscriberList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("subscribers")]
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
            subscribers: ((JArray)map["subscribers"]).ToObject<List<Dictionary<string, object>>>().Select(it => Subscriber.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "subscribers", Subscribers.Select(it => it.ToMap()) }
        };
    }
}
