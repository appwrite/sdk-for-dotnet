
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Topic
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("total")]
        public long Total { get; private set; }

        public Topic(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            long total
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Total = total;
        }

        public static Topic From(Dictionary<string, object> map) => new Topic(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            name: map["name"].ToString(),
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