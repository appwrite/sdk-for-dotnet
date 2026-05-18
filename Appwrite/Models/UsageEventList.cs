
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class UsageEventList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("events")]
        public List<UsageEvent> Events { get; private set; }

        public UsageEventList(
            long total,
            List<UsageEvent> events
        )
        {
            Total = total;
            Events = events;
        }

        public static UsageEventList From(Dictionary<string, object> map) => new UsageEventList(
            total: Convert.ToInt64(map["total"]),
            events: map["events"].ConvertToList<Dictionary<string, object>>().Select(it => UsageEvent.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "events", Events?.Select(it => it.ToMap()).ToList() }
        };
    }
}
