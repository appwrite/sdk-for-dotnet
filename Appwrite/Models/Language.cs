
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Language
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("code")]
        public string Code { get; private set; }

        [JsonProperty("nativeName")]
        public string NativeName { get; private set; }

        public Language(
            string name,
            string code,
            string nativeName
        ) {
            Name = name;
            Code = code;
            NativeName = nativeName;
        }

        public static Language From(Dictionary<string, object> map) => new Language(
            name: map["name"].ToString(),
            code: map["code"].ToString(),
            nativeName: map["nativeName"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "name", Name },
            { "code", Code },
            { "nativeName", NativeName }
        };
    }
}