
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PresenceList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("presences")]
        public List<Presence> Presences { get; private set; }

        public PresenceList(
            long total,
            List<Presence> presences
        )
        {
            Total = total;
            Presences = presences;
        }

        public static PresenceList From(Dictionary<string, object> map) => new PresenceList(
            total: Convert.ToInt64(map["total"]),
            presences: map["presences"].ConvertToList<Dictionary<string, object>>().Select(it => Presence.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "presences", Presences.Select(it => it.ToMap()) }
        };

        public T ConvertTo<T>(Func<Dictionary<string, object>, T> fromJson) =>
            (T)Presences.Select(it => it.ConvertTo(fromJson));

    }
}
