
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class LocaleCode
    {
        [JsonProperty("code")]
        public string Code { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        public LocaleCode(
            string code,
            string name
        ) {
            Code = code;
            Name = name;
        }

        public static LocaleCode From(Dictionary<string, object> map) => new LocaleCode(
            code: map["code"].ToString(),
            name: map["name"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "code", Code },
            { "name", Name }
        };
    }
}