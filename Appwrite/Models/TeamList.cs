using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class TeamList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("teams")]
        public List&lt;Team&gt; Teams { get; private set; }

        public TeamList(
            long total,
            List&lt;Team&gt; teams
        ) {
            Total = total;
            Teams = teams;
        }

        public static TeamList From(Dictionary<string, object> map) => new TeamList(
            total: Convert.ToInt64(map["total"]),
            teams: map["teams"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Team.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["teams"]).Select(it => Team.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "teams", Teams.Select(it => it.ToMap()) }
        };
    }
}
