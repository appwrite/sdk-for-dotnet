
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class EscalationList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("escalations")]
        public List<Escalation> Escalations { get; private set; }

        public EscalationList(
            long total,
            List<Escalation> escalations
        )
        {
            Total = total;
            Escalations = escalations;
        }

        public static EscalationList From(Dictionary<string, object> map) => new EscalationList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            escalations: (map.ContainsKey("escalations") ? map["escalations"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Escalation.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "escalations", Escalations?.Select(it => it.ToMap()).ToList() }
        };
    }
}
