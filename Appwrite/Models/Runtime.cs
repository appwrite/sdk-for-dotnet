
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Runtime
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("version")]
        public string Version { get; private set; }

        [JsonPropertyName("base")]
        public string Base { get; private set; }

        [JsonPropertyName("image")]
        public string Image { get; private set; }

        [JsonPropertyName("logo")]
        public string Logo { get; private set; }

        [JsonPropertyName("supports")]
        public List<string> Supports { get; private set; }

        public Runtime(
            string id,
            string key,
            string name,
            string version,
            string xbase,
            string image,
            string logo,
            List<string> supports
        ) {
            Id = id;
            Key = key;
            Name = name;
            Version = version;
            Base = xbase;
            Image = image;
            Logo = logo;
            Supports = supports;
        }

        public static Runtime From(Dictionary<string, object> map) => new Runtime(
            id: map["$id"].ToString(),
            key: map["key"].ToString(),
            name: map["name"].ToString(),
            version: map["version"].ToString(),
            xbase: map["base"].ToString(),
            image: map["image"].ToString(),
            logo: map["logo"].ToString(),
            supports: map["supports"].ConvertToList<string>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "key", Key },
            { "name", Name },
            { "version", Version },
            { "base", Base },
            { "image", Image },
            { "logo", Logo },
            { "supports", Supports }
        };
    }
}
