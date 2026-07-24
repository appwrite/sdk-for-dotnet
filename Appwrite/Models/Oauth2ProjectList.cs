
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Oauth2ProjectList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("projects")]
        public List<Oauth2Project> Projects { get; private set; }

        public Oauth2ProjectList(
            long total,
            List<Oauth2Project> projects
        )
        {
            Total = total;
            Projects = projects;
        }

        public static Oauth2ProjectList From(Dictionary<string, object> map) => new Oauth2ProjectList(
            total: Convert.ToInt64(map["total"]),
            projects: map["projects"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Oauth2Project.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "projects", Projects?.Select(it => it.ToMap()).ToList() }
        };
    }
}
