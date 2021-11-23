
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class LanguageList
    {
        [JsonProperty("sum")]
        public int Sum { get; set; }

        [JsonProperty("languages")]
        public List<Language> Languages { get; set; }


        public LanguageList(
            int sum,
            List<Language> languages
        ) {
            Sum = sum;
            Languages = languages;
        }

        public static LanguageList From(Dictionary<string, object> map) => new LanguageList(
            sum: (int)map["sum"],
            languages: ((JArray)map["languages"]).ToObject<List<Language>>()!
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "sum", Sum },
            { "languages", Languages.Select(it => it.ToMap()) }
        };
    }
}