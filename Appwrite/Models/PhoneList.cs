
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PhoneList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("phones")]
        public List<Phone> Phones { get; private set; }

        public PhoneList(
            long total,
            List<Phone> phones
        ) {
            Total = total;
            Phones = phones;
        }

        public static PhoneList From(Dictionary<string, object> map) => new PhoneList(
            total: Convert.ToInt64(map["total"]),
            phones: map["phones"].ConvertToList<Dictionary<string, object>>().Select(it => Phone.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "phones", Phones.Select(it => it.ToMap()) }
        };
    }
}
