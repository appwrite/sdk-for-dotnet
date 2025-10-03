using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class LanguageList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("languages")]
        public List&lt;Language&gt; Languages { get; private set; }

        public LanguageList(
            long total,
            List&lt;Language&gt; languages
        ) {
            Total = total;
            Languages = languages;
        }

        public static LanguageList From(Dictionary<string, object> map) => new LanguageList(
            total: Convert.ToInt64(map["total"]),
            languages: map["languages"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Language.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["languages"]).Select(it => Language.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "languages", Languages.Select(it => it.ToMap()) }
        };
    }
}
