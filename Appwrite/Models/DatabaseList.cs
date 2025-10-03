using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class DatabaseList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("databases")]
        public List&lt;Database&gt; Databases { get; private set; }

        public DatabaseList(
            long total,
            List&lt;Database&gt; databases
        ) {
            Total = total;
            Databases = databases;
        }

        public static DatabaseList From(Dictionary<string, object> map) => new DatabaseList(
            total: Convert.ToInt64(map["total"]),
            databases: map["databases"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Database.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["databases"]).Select(it => Database.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "databases", Databases.Select(it => it.ToMap()) }
        };
    }
}
