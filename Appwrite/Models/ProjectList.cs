
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class ProjectList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("projects")]
        public List<Project> Projects { get; private set; }

        public ProjectList(
            long total,
            List<Project> projects
        ) {
            Total = total;
            Projects = projects;
        }

        public static ProjectList From(Dictionary<string, object> map) => new ProjectList(
            total: Convert.ToInt64(map["total"]),
            projects: map["projects"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Project.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["projects"]).Select(it => Project.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "projects", Projects.Select(it => it.ToMap()) }
        };
    }
}
