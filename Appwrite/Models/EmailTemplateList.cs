
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class EmailTemplateList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("templates")]
        public List<EmailTemplate> Templates { get; private set; }

        public EmailTemplateList(
            long total,
            List<EmailTemplate> templates
        )
        {
            Total = total;
            Templates = templates;
        }

        public static EmailTemplateList From(Dictionary<string, object> map) => new EmailTemplateList(
            total: Convert.ToInt64(map["total"]),
            templates: map["templates"].ConvertToList<Dictionary<string, object>>().Select(it => EmailTemplate.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "templates", Templates.Select(it => it.ToMap()) }
        };
    }
}
