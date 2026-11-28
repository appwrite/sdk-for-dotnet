
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AnalyticsMetric
    {
        [JsonPropertyName("value")]
        public string? Value { get; private set; }

        [JsonPropertyName("date")]
        public string? Date { get; private set; }

        [JsonPropertyName("visitors")]
        public long Visitors { get; private set; }

        [JsonPropertyName("sessions")]
        public long Sessions { get; private set; }

        [JsonPropertyName("pageviews")]
        public long? Pageviews { get; private set; }

        [JsonPropertyName("events")]
        public long Events { get; private set; }

        [JsonPropertyName("users")]
        public long? Users { get; private set; }

        [JsonPropertyName("visits")]
        public long? Visits { get; private set; }

        [JsonPropertyName("bounceRate")]
        public double? BounceRate { get; private set; }

        [JsonPropertyName("visitDuration")]
        public double? VisitDuration { get; private set; }

        [JsonPropertyName("viewsPerVisit")]
        public double? ViewsPerVisit { get; private set; }

        [JsonPropertyName("scrollDepth")]
        public double? ScrollDepth { get; private set; }

        [JsonPropertyName("engagementTime")]
        public double? EngagementTime { get; private set; }

        public AnalyticsMetric(
            string? @value,
            string? date,
            long visitors,
            long sessions,
            long? pageviews,
            long events,
            long? users,
            long? visits,
            double? bounceRate,
            double? visitDuration,
            double? viewsPerVisit,
            double? scrollDepth,
            double? engagementTime
        )
        {
            Value = @value;
            Date = date;
            Visitors = visitors;
            Sessions = sessions;
            Pageviews = pageviews;
            Events = events;
            Users = users;
            Visits = visits;
            BounceRate = bounceRate;
            VisitDuration = visitDuration;
            ViewsPerVisit = viewsPerVisit;
            ScrollDepth = scrollDepth;
            EngagementTime = engagementTime;
        }

        public static AnalyticsMetric From(Dictionary<string, object> map) => new AnalyticsMetric(
            @value: map.TryGetValue("value", out var @value) ? @value?.ToString() : null,
            date: map.TryGetValue("date", out var date) ? date?.ToString() : null,
            visitors: Convert.ToInt64((map.ContainsKey("visitors") ? map["visitors"] : 0)),
            sessions: Convert.ToInt64((map.ContainsKey("sessions") ? map["sessions"] : 0)),
            pageviews: map.TryGetValue("pageviews", out var numberRaw5) && numberRaw5 != null
                                    ? Convert.ToInt64(numberRaw5)
                                    : null,
            events: Convert.ToInt64((map.ContainsKey("events") ? map["events"] : 0)),
            users: map.TryGetValue("users", out var numberRaw7) && numberRaw7 != null
                                    ? Convert.ToInt64(numberRaw7)
                                    : null,
            visits: map.TryGetValue("visits", out var numberRaw8) && numberRaw8 != null
                                    ? Convert.ToInt64(numberRaw8)
                                    : null,
            bounceRate: map.TryGetValue("bounceRate", out var numberRaw9) && numberRaw9 != null
                                    ? Convert.ToDouble(numberRaw9)
                                    : null,
            visitDuration: map.TryGetValue("visitDuration", out var numberRaw10) && numberRaw10 != null
                                    ? Convert.ToDouble(numberRaw10)
                                    : null,
            viewsPerVisit: map.TryGetValue("viewsPerVisit", out var numberRaw11) && numberRaw11 != null
                                    ? Convert.ToDouble(numberRaw11)
                                    : null,
            scrollDepth: map.TryGetValue("scrollDepth", out var numberRaw12) && numberRaw12 != null
                                    ? Convert.ToDouble(numberRaw12)
                                    : null,
            engagementTime: map.TryGetValue("engagementTime", out var numberRaw13) && numberRaw13 != null
                                    ? Convert.ToDouble(numberRaw13)
                                    : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "value", Value },
            { "date", Date },
            { "visitors", Visitors },
            { "sessions", Sessions },
            { "pageviews", Pageviews },
            { "events", Events },
            { "users", Users },
            { "visits", Visits },
            { "bounceRate", BounceRate },
            { "visitDuration", VisitDuration },
            { "viewsPerVisit", ViewsPerVisit },
            { "scrollDepth", ScrollDepth },
            { "engagementTime", EngagementTime }
        };
    }
}
