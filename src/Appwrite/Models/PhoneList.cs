
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class PhoneList
    {
        [JsonProperty("sum")]
        public int Sum { get; set; }

        [JsonProperty("phones")]
        public List<Phone> Phones { get; set; }


        public PhoneList(
            int sum,
            List<Phone> phones
        ) {
            Sum = sum;
            Phones = phones;
        }

        public static PhoneList From(Dictionary<string, object> map) => new PhoneList(
            sum: (int)map["sum"],
            phones: ((JArray)map["phones"]).ToObject<List<Phone>>()!
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "sum", Sum },
            { "phones", Phones.Select(it => it.ToMap()) }
        };
    }
}