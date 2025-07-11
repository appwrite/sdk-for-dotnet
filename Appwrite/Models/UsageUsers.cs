
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class UsageUsers
    {
        [JsonPropertyName("range")]
        public string Range { get; private set; }

        [JsonPropertyName("usersTotal")]
        public long UsersTotal { get; private set; }

        [JsonPropertyName("sessionsTotal")]
        public long SessionsTotal { get; private set; }

        [JsonPropertyName("users")]
        public List<Metric> Users { get; private set; }

        [JsonPropertyName("sessions")]
        public List<Metric> Sessions { get; private set; }

        public UsageUsers(
            string range,
            long usersTotal,
            long sessionsTotal,
            List<Metric> users,
            List<Metric> sessions
        ) {
            Range = range;
            UsersTotal = usersTotal;
            SessionsTotal = sessionsTotal;
            Users = users;
            Sessions = sessions;
        }

        public static UsageUsers From(Dictionary<string, object> map) => new UsageUsers(
            range: map["range"].ToString(),
            usersTotal: Convert.ToInt64(map["usersTotal"]),
            sessionsTotal: Convert.ToInt64(map["sessionsTotal"]),
            users: map["users"] is JsonElement jsonArray4 ? jsonArray4.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["users"]).Select(it => Metric.From(map: it)).ToList(),
            sessions: map["sessions"] is JsonElement jsonArray5 ? jsonArray5.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["sessions"]).Select(it => Metric.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "range", Range },
            { "usersTotal", UsersTotal },
            { "sessionsTotal", SessionsTotal },
            { "users", Users.Select(it => it.ToMap()) },
            { "sessions", Sessions.Select(it => it.ToMap()) }
        };
    }
}
