
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class LanguageList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("languages")]
        public List<Language> Languages { get; private set; }

        public LanguageList(
            long total,
            List<Language> languages
        ) {
            Total = total;
            Languages = languages;
        }

        public static LanguageList From(Dictionary<string, object> map) => new LanguageList(
            total: Convert.ToInt64(map["total"]),
            languages: ((JArray)map["languages"]).ToObject<List<Dictionary<string, object>>>().Select(it => Language.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "languages", Languages.Select(it => it.ToMap()) }
        };
    }
}