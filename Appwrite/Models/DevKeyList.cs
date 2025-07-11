
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class DevKeyList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("devKeys")]
        public List<DevKey> DevKeys { get; private set; }

        public DevKeyList(
            long total,
            List<DevKey> devKeys
        ) {
            Total = total;
            DevKeys = devKeys;
        }

        public static DevKeyList From(Dictionary<string, object> map) => new DevKeyList(
            total: Convert.ToInt64(map["total"]),
            devKeys: map["devKeys"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => DevKey.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["devKeys"]).Select(it => DevKey.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "devKeys", DevKeys.Select(it => it.ToMap()) }
        };
    }
}
