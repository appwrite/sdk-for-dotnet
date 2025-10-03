using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class RowList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("rows")]
        public List&lt;Row&gt; Rows { get; private set; }

        public RowList(
            long total,
            List&lt;Row&gt; rows
        ) {
            Total = total;
            Rows = rows;
        }

        public static RowList From(Dictionary<string, object> map) => new RowList(
            total: Convert.ToInt64(map["total"]),
            rows: map["rows"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Row.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["rows"]).Select(it => Row.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "rows", Rows.Select(it => it.ToMap()) }
        };

        public T ConvertTo<T>(Func<Dictionary<string, object>, T> fromJson) =>
            (T)Rows.Select(it => it.ConvertTo(fromJson));

    }
}
