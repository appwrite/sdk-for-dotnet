
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class LocaleCodeList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("localeCodes")]
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
            localeCodes: ((JArray)map["localeCodes"]).ToObject<List<Dictionary<string, object>>>().Select(it => LocaleCode.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "localeCodes", LocaleCodes.Select(it => it.ToMap()) }
        };
    }
}