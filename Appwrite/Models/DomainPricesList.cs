
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DomainPricesList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("prices")]
        public List<DomainPrice> Prices { get; private set; }

        public DomainPricesList(
            long total,
            List<DomainPrice> prices
        )
        {
            Total = total;
            Prices = prices;
        }

        public static DomainPricesList From(Dictionary<string, object> map) => new DomainPricesList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            prices: map["prices"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.DomainPrice.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "prices", Prices?.Select(it => it.ToMap()).ToList() }
        };
    }
}
