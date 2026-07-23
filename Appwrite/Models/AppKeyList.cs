
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AppKeyList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("keys")]
        public List<AppKey> Keys { get; private set; }

        public AppKeyList(
            long total,
            List<AppKey> keys
        )
        {
            Total = total;
            Keys = keys;
        }

        public static AppKeyList From(Dictionary<string, object> map) => new AppKeyList(
            total: Convert.ToInt64(map["total"]),
            keys: map["keys"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.AppKey.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "keys", Keys?.Select(it => it.ToMap()).ToList() }
        };
    }
}
