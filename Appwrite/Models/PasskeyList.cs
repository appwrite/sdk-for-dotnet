
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PasskeyList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("passkeys")]
        public List<Passkey> Passkeys { get; private set; }

        public PasskeyList(
            long total,
            List<Passkey> passkeys
        )
        {
            Total = total;
            Passkeys = passkeys;
        }

        public static PasskeyList From(Dictionary<string, object> map) => new PasskeyList(
            total: Convert.ToInt64(map["total"]),
            passkeys: map["passkeys"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Passkey.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "passkeys", Passkeys?.Select(it => it.ToMap()).ToList() }
        };
    }
}
