
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Team
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("dateCreated")]
        public int DateCreated { get; set; }

        [JsonProperty("sum")]
        public int Sum { get; set; }


        public Team(
            string id,
            string name,
            int dateCreated,
            int sum
        ) {
            Id = id;
            Name = name;
            DateCreated = dateCreated;
            Sum = sum;
        }

        public static Team From(Dictionary<string, object> map) => new Team(
            id: (string)map["$id"],
            name: (string)map["name"],
            dateCreated: (int)map["dateCreated"],
            sum: (int)map["sum"]
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "$id", Id },
            { "name", Name },
            { "dateCreated", DateCreated },
            { "sum", Sum }
        };
    }
}