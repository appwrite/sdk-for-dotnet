
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("databases")]
        public List<DedicatedDatabase> Databases { get; private set; }

        public DedicatedDatabaseList(
            long total,
            List<DedicatedDatabase> databases
        )
        {
            Total = total;
            Databases = databases;
        }

        public static DedicatedDatabaseList From(Dictionary<string, object> map) => new DedicatedDatabaseList(
            total: Convert.ToInt64(map["total"]),
            databases: map["databases"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.DedicatedDatabase.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "databases", Databases?.Select(it => it.ToMap()).ToList() }
        };
    }
}
