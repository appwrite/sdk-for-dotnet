
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class CurrencyList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("currencies")]
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
            currencies: map["currencies"].ConvertToList<Dictionary<string, object>>().Select(it => Currency.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "currencies", Currencies.Select(it => it.ToMap()) }
        };
    }
}
