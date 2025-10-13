
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

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
            columns: map["columns"].ConvertToList<object>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "columns", Columns }
        };
    }
}
