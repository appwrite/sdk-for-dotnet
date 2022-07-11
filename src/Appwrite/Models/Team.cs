
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

        [JsonProperty("$createdAt")]
        public long CreatedAt { get; set; }

        [JsonProperty("$updatedAt")]
        public long UpdatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }


        public Team(
            string id,
            long createdAt,
            long updatedAt,
            string name,
            long total
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Total = total;
        }

        public static Team From(Dictionary<string, object> map) => new Team(
            id: (string)map["$id"],
            createdAt: Convert.ToInt64(map["$createdAt"]),
            updatedAt: Convert.ToInt64(map["$updatedAt"]),
            name: (string)map["name"],
            total: Convert.ToInt64(map["total"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "total", Total }
        };
    }
}