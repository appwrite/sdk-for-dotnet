
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class TableList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("tables")]
        public List<Table> Tables { get; private set; }

        public TableList(
            long total,
            List<Table> tables
        ) {
            Total = total;
            Tables = tables;
        }

        public static TableList From(Dictionary<string, object> map) => new TableList(
            total: Convert.ToInt64(map["total"]),
            tables: map["tables"].ConvertToList<Dictionary<string, object>>().Select(it => Table.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "tables", Tables.Select(it => it.ToMap()) }
        };
    }
}
