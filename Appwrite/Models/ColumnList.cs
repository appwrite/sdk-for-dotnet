
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class ColumnList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("columns")]
        public List<object> Columns { get; private set; }

        public ColumnList(
            long total,
            List<object> columns
        ) {
            Total = total;
            Columns = columns;
        }

        public static ColumnList From(Dictionary<string, object> map) => new ColumnList(
            total: Convert.ToInt64(map["total"]),
            columns: map["columns"] is JsonElement jsonArrayProp2 ? jsonArrayProp2.Deserialize<List<object>>()! : (List<object>)map["columns"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "columns", Columns }
        };
    }
}
