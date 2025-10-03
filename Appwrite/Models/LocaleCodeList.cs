
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class LocaleCodeList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("localeCodes")]
        public List<LocaleCode> LocaleCodes { get; private set; }

        public LocaleCodeList(
            long total,
            List<LocaleCode> localeCodes
        ) {
            Total = total;
            LocaleCodes = localeCodes;
        }

        public static LocaleCodeList From(Dictionary<string, object> map) => new LocaleCodeList(
            total: Convert.ToInt64(map["total"]),
            localeCodes: map["localeCodes"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => LocaleCode.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["localeCodes"]).Select(it => LocaleCode.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "localeCodes", LocaleCodes.Select(it => it.ToMap()) }
        };
    }
}
