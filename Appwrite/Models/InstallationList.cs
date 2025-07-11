
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class InstallationList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("installations")]
        public List<Installation> Installations { get; private set; }

        public InstallationList(
            long total,
            List<Installation> installations
        ) {
            Total = total;
            Installations = installations;
        }

        public static InstallationList From(Dictionary<string, object> map) => new InstallationList(
            total: Convert.ToInt64(map["total"]),
            installations: map["installations"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Installation.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["installations"]).Select(it => Installation.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "installations", Installations.Select(it => it.ToMap()) }
        };
    }
}
