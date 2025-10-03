using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class TableList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("tables")]
        public List&lt;Table&gt; Tables { get; private set; }

        public TableList(
            long total,
            List&lt;Table&gt; tables
        ) {
            Total = total;
            Tables = tables;
        }

        public static TableList From(Dictionary<string, object> map) => new TableList(
            total: Convert.ToInt64(map["total"]),
            tables: map["tables"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Table.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["tables"]).Select(it => Table.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "tables", Tables.Select(it => it.ToMap()) }
        };
    }
}
