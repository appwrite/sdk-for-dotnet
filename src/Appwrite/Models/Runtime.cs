
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Runtime
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("supports")]
        public List<object> Supports { get; set; }


        public Runtime(
            string id,
            string name,
            string version,
            string xbase,
            string image,
            string logo,
            List<object> supports
        ) {
            Id = id;
            Name = name;
            Version = version;
            Base = xbase;
            Image = image;
            Logo = logo;
            Supports = supports;
        }

        public static Runtime From(Dictionary<string, object> map) => new Runtime(
            id: (string)map["$id"],
            name: (string)map["name"],
            version: (string)map["version"],
            xbase: (string)map["base"],
            image: (string)map["image"],
            logo: (string)map["logo"],
            supports: ((JArray)map["supports"]).ToObject<List<object>>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "name", Name },
            { "version", Version },
            { "base", Base },
            { "image", Image },
            { "logo", Logo },
            { "supports", Supports }
        };
    }
}