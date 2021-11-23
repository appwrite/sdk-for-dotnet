
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Rule
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        [JsonProperty("$collection")]
        public string Collection { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("default")]
        public string Default { get; set; }

        [JsonProperty("array")]
        public bool Array { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("list")]
        public List<object> List { get; set; }


        public Rule(
            string id,
            string collection,
            string type,
            string key,
            string label,
            string xdefault,
            bool array,
            bool required,
            List<object> list
        ) {
            Id = id;
            Collection = collection;
            Type = type;
            Key = key;
            Label = label;
            Default = xdefault;
            Array = array;
            Required = required;
            List = list;
        }

        public static Rule From(Dictionary<string, object> map) => new Rule(
            id: (string)map["$id"],
            collection: (string)map["$collection"],
            type: (string)map["type"],
            key: (string)map["key"],
            label: (string)map["label"],
            xdefault: (string)map["default"],
            array: (bool)map["array"],
            required: (bool)map["required"],
            list: ((JArray)map["list"]).ToObject<List<object>>()
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "$id", Id },
            { "$collection", Collection },
            { "type", Type },
            { "key", Key },
            { "label", Label },
            { "default", Default },
            { "array", Array },
            { "required", Required },
            { "list", List }
        };
    }
}