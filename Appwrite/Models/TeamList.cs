
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class TeamList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("teams")]
        public List<Team> Teams { get; private set; }

        public TeamList(
            long total,
            List<Team> teams
        )
        {
            Total = total;
            Teams = teams;
        }

        public static TeamList From(Dictionary<string, object> map) => new TeamList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            teams: (map.ContainsKey("teams") ? map["teams"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Team.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "teams", Teams?.Select(it => it.ToMap()).ToList() }
        };
    }
}
