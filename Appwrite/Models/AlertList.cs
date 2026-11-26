
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AlertList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("alerts")]
        public List<Alert> Alerts { get; private set; }

        public AlertList(
            long total,
            List<Alert> alerts
        )
        {
            Total = total;
            Alerts = alerts;
        }

        public static AlertList From(Dictionary<string, object> map) => new AlertList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            alerts: (map.ContainsKey("alerts") ? map["alerts"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Alert.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "alerts", Alerts?.Select(it => it.ToMap()).ToList() }
        };
    }
}
