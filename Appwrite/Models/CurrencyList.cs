
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class CurrencyList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("currencies")]
        public List<Currency> Currencies { get; private set; }

        public CurrencyList(
            long total,
            List<Currency> currencies
        ) {
            Total = total;
            Currencies = currencies;
        }

        public static CurrencyList From(Dictionary<string, object> map) => new CurrencyList(
            total: Convert.ToInt64(map["total"]),
            currencies: ((JArray)map["currencies"]).ToObject<List<Dictionary<string, object>>>().Select(it => Currency.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "currencies", Currencies.Select(it => it.ToMap()) }
        };
    }
}