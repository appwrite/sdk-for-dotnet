
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseOperationList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("operations")]
        public List<DedicatedDatabaseOperation> Operations { get; private set; }

        public DedicatedDatabaseOperationList(
            long total,
            List<DedicatedDatabaseOperation> operations
        )
        {
            Total = total;
            Operations = operations;
        }

        public static DedicatedDatabaseOperationList From(Dictionary<string, object> map) => new DedicatedDatabaseOperationList(
            total: Convert.ToInt64(map["total"]),
            operations: map["operations"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.DedicatedDatabaseOperation.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "operations", Operations?.Select(it => it.ToMap()).ToList() }
        };
    }
}
