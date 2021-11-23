
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class SessionList
    {
        [JsonProperty("sum")]
        public int Sum { get; set; }

        [JsonProperty("sessions")]
        public List<Session> Sessions { get; set; }


        public SessionList(
            int sum,
            List<Session> sessions
        ) {
            Sum = sum;
            Sessions = sessions;
        }

        public static SessionList From(Dictionary<string, object> map) => new SessionList(
            sum: (int)map["sum"],
            sessions: ((JArray)map["sessions"]).ToObject<List<Session>>()!
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "sum", Sum },
            { "sessions", Sessions.Select(it => it.ToMap()) }
        };
    }
}