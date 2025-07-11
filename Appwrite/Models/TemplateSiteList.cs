
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class TemplateSiteList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("templates")]
        public List<TemplateSite> Templates { get; private set; }

        public TemplateSiteList(
            long total,
            List<TemplateSite> templates
        ) {
            Total = total;
            Templates = templates;
        }

        public static TemplateSiteList From(Dictionary<string, object> map) => new TemplateSiteList(
            total: Convert.ToInt64(map["total"]),
            templates: map["templates"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => TemplateSite.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["templates"]).Select(it => TemplateSite.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "templates", Templates.Select(it => it.ToMap()) }
        };
    }
}
