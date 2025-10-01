
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

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
            sessions: map["sessions"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Session.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["sessions"]).Select(it => Session.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "sessions", Sessions.Select(it => it.ToMap()) }
        };
    }
}
