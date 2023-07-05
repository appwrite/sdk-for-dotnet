
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class SessionList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("sessions")]
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
            sessions: ((JArray)map["sessions"]).ToObject<List<Dictionary<string, object>>>().Select(it => Session.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "sessions", Sessions.Select(it => it.ToMap()) }
        };
    }
}