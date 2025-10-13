
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class SessionList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("sessions")]
        public List<Session> Sessions { get; private set; }

        public SessionList(
            long total,
            List<Session> sessions
        ) {
            Total = total;
            Sessions = sessions;
        }

        public static SessionList From(Dictionary<string, object> map) => new SessionList(
            total: Convert.ToInt64(map["total"]),
            sessions: map["sessions"].ConvertToList<Dictionary<string, object>>().Select(it => Session.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "sessions", Sessions.Select(it => it.ToMap()) }
        };
    }
}
