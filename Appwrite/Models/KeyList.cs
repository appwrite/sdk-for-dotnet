
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class KeyList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("keys")]
        public List<Key> Keys { get; private set; }

        public KeyList(
            long total,
            List<Key> keys
        ) {
            Total = total;
            Keys = keys;
        }

        public static KeyList From(Dictionary<string, object> map) => new KeyList(
            total: Convert.ToInt64(map["total"]),
            keys: map["keys"].ConvertToList<Dictionary<string, object>>().Select(it => Key.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "keys", Keys.Select(it => it.ToMap()) }
        };
    }
}
