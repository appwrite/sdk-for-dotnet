
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Database
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }


        public Database(
            string id,
            string name
        ) {
            Id = id;
            Name = name;
        }

        public static Database From(Dictionary<string, object> map) => new Database(
            id: (string)map["$id"],
            name: (string)map["name"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "name", Name }
        };
    }
}