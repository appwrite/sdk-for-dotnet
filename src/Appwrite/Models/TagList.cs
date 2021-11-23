
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class TagList
    {
        [JsonProperty("sum")]
        public int Sum { get; set; }

        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }


        public TagList(
            int sum,
            List<Tag> tags
        ) {
            Sum = sum;
            Tags = tags;
        }

        public static TagList From(Dictionary<string, object> map) => new TagList(
            sum: (int)map["sum"],
            tags: ((JArray)map["tags"]).ToObject<List<Tag>>()!
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "sum", Sum },
            { "tags", Tags.Select(it => it.ToMap()) }
        };
    }
}