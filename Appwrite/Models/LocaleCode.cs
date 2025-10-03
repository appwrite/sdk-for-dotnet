
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class LocaleCode
    {
        [JsonPropertyName("code")]
        public string Code { get; private set; }

        [JsonPropertyName("name")]
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
