
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

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
            subscribers: map["subscribers"].ConvertToList<Dictionary<string, object>>().Select(it => Subscriber.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "subscribers", Subscribers.Select(it => it.ToMap()) }
        };
    }
}
