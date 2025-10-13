
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class ColumnIndexList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("indexes")]
        public List<ColumnIndex> Indexes { get; private set; }

        public ColumnIndexList(
            long total,
            List<ColumnIndex> indexes
        ) {
            Total = total;
            Indexes = indexes;
        }

        public static ColumnIndexList From(Dictionary<string, object> map) => new ColumnIndexList(
            total: Convert.ToInt64(map["total"]),
            indexes: map["indexes"].ConvertToList<Dictionary<string, object>>().Select(it => ColumnIndex.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "indexes", Indexes.Select(it => it.ToMap()) }
        };
    }
}
