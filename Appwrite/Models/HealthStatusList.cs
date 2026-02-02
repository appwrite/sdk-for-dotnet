
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class HealthStatusList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("statuses")]
        public List<HealthStatus> Statuses { get; private set; }

        public HealthStatusList(
            long total,
            List<HealthStatus> statuses
        ) {
            Total = total;
            Statuses = statuses;
        }

        public static HealthStatusList From(Dictionary<string, object> map) => new HealthStatusList(
            total: Convert.ToInt64(map["total"]),
            statuses: map["statuses"].ConvertToList<Dictionary<string, object>>().Select(it => HealthStatus.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "statuses", Statuses.Select(it => it.ToMap()) }
        };
    }
}
