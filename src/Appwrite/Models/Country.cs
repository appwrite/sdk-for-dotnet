
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Country
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("code")]
        public string Code { get; private set; }

        public Country(
            string name,
            string code
        ) {
            Name = name;
            Code = code;
        }

        public static Country From(Dictionary<string, object> map) => new Country(
            name: map["name"].ToString(),
            code: map["code"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "name", Name },
            { "code", Code }
        };
    }
}