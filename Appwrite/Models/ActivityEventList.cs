
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class ActivityEventList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("events")]
        public List<ActivityEvent> Events { get; private set; }

        public ActivityEventList(
            long total,
            List<ActivityEvent> events
        ) {
            Total = total;
            Events = events;
        }

        public static ActivityEventList From(Dictionary<string, object> map) => new ActivityEventList(
            total: Convert.ToInt64(map["total"]),
            events: map["events"].ConvertToList<Dictionary<string, object>>().Select(it => ActivityEvent.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "events", Events.Select(it => it.ToMap()) }
        };
    }
}
