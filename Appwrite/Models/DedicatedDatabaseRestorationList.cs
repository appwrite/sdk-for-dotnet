
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseRestorationList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("restorations")]
        public List<DedicatedDatabaseRestoration> Restorations { get; private set; }

        public DedicatedDatabaseRestorationList(
            long total,
            List<DedicatedDatabaseRestoration> restorations
        )
        {
            Total = total;
            Restorations = restorations;
        }

        public static DedicatedDatabaseRestorationList From(Dictionary<string, object> map) => new DedicatedDatabaseRestorationList(
            total: Convert.ToInt64(map["total"]),
            restorations: map["restorations"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.DedicatedDatabaseRestoration.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "restorations", Restorations?.Select(it => it.ToMap()).ToList() }
        };
    }
}
