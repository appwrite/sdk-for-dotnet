
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class TeamList
    {
        [JsonProperty("sum")]
        public int Sum { get; set; }

        [JsonProperty("teams")]
        public List<Team> Teams { get; set; }


        public TeamList(
            int sum,
            List<Team> teams
        ) {
            Sum = sum;
            Teams = teams;
        }

        public static TeamList From(Dictionary<string, object> map) => new TeamList(
            sum: (int)map["sum"],
            teams: ((JArray)map["teams"]).ToObject<List<Team>>()!
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "sum", Sum },
            { "teams", Teams.Select(it => it.ToMap()) }
        };
    }
}