
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class PhoneList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("phones")]
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
            phones: ((JArray)map["phones"]).ToObject<List<Dictionary<string, object>>>().Select(it => Phone.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "phones", Phones.Select(it => it.ToMap()) }
        };
    }
}