
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class ReportList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("reports")]
        public List<Report> Reports { get; private set; }

        public ReportList(
            long total,
            List<Report> reports
        )
        {
            Total = total;
            Reports = reports;
        }

        public static ReportList From(Dictionary<string, object> map) => new ReportList(
            total: Convert.ToInt64(map["total"]),
            reports: map["reports"].ConvertToList<Dictionary<string, object>>().Select(it => Report.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "reports", Reports?.Select(it => it.ToMap()).ToList() }
        };
    }
}
