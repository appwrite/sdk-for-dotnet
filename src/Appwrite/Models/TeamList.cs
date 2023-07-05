
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class TeamList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("teams")]
        public List<Team> Teams { get; private set; }

        public TeamList(
            long total,
            List<Team> teams
        ) {
            Total = total;
            Teams = teams;
        }

        public static TeamList From(Dictionary<string, object> map) => new TeamList(
            total: Convert.ToInt64(map["total"]),
            teams: ((JArray)map["teams"]).ToObject<List<Dictionary<string, object>>>().Select(it => Team.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "teams", Teams.Select(it => it.ToMap()) }
        };
    }
}