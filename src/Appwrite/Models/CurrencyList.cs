
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class CurrencyList
    {
        [JsonProperty("sum")]
        public int Sum { get; set; }

        [JsonProperty("currencies")]
        public List<Currency> Currencies { get; set; }


        public CurrencyList(
            int sum,
            List<Currency> currencies
        ) {
            Sum = sum;
            Currencies = currencies;
        }

        public static CurrencyList From(Dictionary<string, object> map) => new CurrencyList(
            sum: (int)map["sum"],
            currencies: ((JArray)map["currencies"]).ToObject<List<Currency>>()!
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "sum", Sum },
            { "currencies", Currencies.Select(it => it.ToMap()) }
        };
    }
}