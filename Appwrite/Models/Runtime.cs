
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
        public string Id { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("version")]
        public string Version { get; private set; }

        [JsonProperty("base")]
        public string Base { get; private set; }

        [JsonProperty("image")]
        public string Image { get; private set; }

        [JsonProperty("logo")]
        public string Logo { get; private set; }

        [JsonProperty("supports")]
        public List<object> Supports { get; private set; }

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
            id: map["$id"].ToString(),
            name: map["name"].ToString(),
            version: map["version"].ToString(),
            xbase: map["base"].ToString(),
            image: map["image"].ToString(),
            logo: map["logo"].ToString(),
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