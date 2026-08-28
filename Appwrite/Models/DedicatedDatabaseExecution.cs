
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseExecution
    {
        [JsonPropertyName("rows")]
        public List<object> Rows { get; private set; }

        [JsonPropertyName("rowCount")]
        public long RowCount { get; private set; }

        [JsonPropertyName("columns")]
        public List<DedicatedDatabaseExecutionColumn> Columns { get; private set; }

        [JsonPropertyName("durationMs")]
        public long DurationMs { get; private set; }

        [JsonPropertyName("truncated")]
        public bool Truncated { get; private set; }

        [JsonPropertyName("bytes")]
        public long Bytes { get; private set; }

        public DedicatedDatabaseExecution(
            List<object> rows,
            long rowCount,
            List<DedicatedDatabaseExecutionColumn> columns,
            long durationMs,
            bool truncated,
            long bytes
        )
        {
            Rows = rows;
            RowCount = rowCount;
            Columns = columns;
            DurationMs = durationMs;
            Truncated = truncated;
            Bytes = bytes;
        }

        public static DedicatedDatabaseExecution From(Dictionary<string, object> map) => new DedicatedDatabaseExecution(
            rows: map["rows"].ConvertToList<object>(),
            rowCount: Convert.ToInt64(map["rowCount"]),
            columns: map["columns"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.DedicatedDatabaseExecutionColumn.From(map: it)).ToList(),
            durationMs: Convert.ToInt64(map["durationMs"]),
            truncated: (bool)map["truncated"],
            bytes: Convert.ToInt64(map["bytes"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "rows", Rows },
            { "rowCount", RowCount },
            { "columns", Columns?.Select(it => it.ToMap()).ToList() },
            { "durationMs", DurationMs },
            { "truncated", Truncated },
            { "bytes", Bytes }
        };
    }
}
