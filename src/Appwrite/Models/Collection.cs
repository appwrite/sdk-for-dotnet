
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Collection
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        [JsonProperty("$permissions")]
        public Permissions Permissions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("dateCreated")]
        public int DateCreated { get; set; }

        [JsonProperty("dateUpdated")]
        public int DateUpdated { get; set; }

        [JsonProperty("rules")]
        public List<Rule> Rules { get; set; }


        public Collection(
            string id,
            Permissions permissions,
            string name,
            int dateCreated,
            int dateUpdated,
            List<Rule> rules
        ) {
            Id = id;
            Permissions = permissions;
            Name = name;
            DateCreated = dateCreated;
            DateUpdated = dateUpdated;
            Rules = rules;
        }

        public static Collection From(Dictionary<string, object> map) => new Collection(
            id: (string)map["$id"],
            permissions: Permissions.From(map: ((JObject)map["$permissions"]).ToObject<Dictionary<string, object>>()!),
            name: (string)map["name"],
            dateCreated: (int)map["dateCreated"],
            dateUpdated: (int)map["dateUpdated"],
            rules: ((JArray)map["rules"]).ToObject<List<Rule>>()!
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "$id", Id },
            { "$permissions", Permissions.ToMap() },
            { "name", Name },
            { "dateCreated", DateCreated },
            { "dateUpdated", DateUpdated },
            { "rules", Rules.Select(it => it.ToMap()) }
        };
    }
}