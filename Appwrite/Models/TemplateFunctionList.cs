
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class TemplateFunctionList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("templates")]
        public List<TemplateFunction> Templates { get; private set; }

        public TemplateFunctionList(
            long total,
            List<TemplateFunction> templates
        ) {
            Total = total;
            Templates = templates;
        }

        public static TemplateFunctionList From(Dictionary<string, object> map) => new TemplateFunctionList(
            total: Convert.ToInt64(map["total"]),
            templates: ((JArray)map["templates"]).ToObject<List<Dictionary<string, object>>>().Select(it => TemplateFunction.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "templates", Templates.Select(it => it.ToMap()) }
        };
    }
}