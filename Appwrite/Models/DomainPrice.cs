
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DomainPrice
    {
        [JsonPropertyName("domain")]
        public string Domain { get; private set; }

        [JsonPropertyName("tld")]
        public string Tld { get; private set; }

        [JsonPropertyName("available")]
        public bool Available { get; private set; }

        [JsonPropertyName("price")]
        public double? Price { get; private set; }

        [JsonPropertyName("periodYears")]
        public long PeriodYears { get; private set; }

        [JsonPropertyName("premium")]
        public bool Premium { get; private set; }

        [JsonPropertyName("renewalPrice")]
        public double? RenewalPrice { get; private set; }

        [JsonPropertyName("renewalPeriodYears")]
        public long RenewalPeriodYears { get; private set; }

        public DomainPrice(
            string domain,
            string tld,
            bool available,
            double? price,
            long periodYears,
            bool premium,
            double? renewalPrice,
            long renewalPeriodYears
        )
        {
            Domain = domain;
            Tld = tld;
            Available = available;
            Price = price;
            PeriodYears = periodYears;
            Premium = premium;
            RenewalPrice = renewalPrice;
            RenewalPeriodYears = renewalPeriodYears;
        }

        public static DomainPrice From(Dictionary<string, object> map) => new DomainPrice(
            domain: map["domain"].ToString(),
            tld: map["tld"].ToString(),
            available: (bool)map["available"],
            price: map.TryGetValue("price", out var numberRaw4) && numberRaw4 != null
                                    ? Convert.ToDouble(numberRaw4)
                                    : null,
            periodYears: Convert.ToInt64(map["periodYears"]),
            premium: (bool)map["premium"],
            renewalPrice: map.TryGetValue("renewalPrice", out var numberRaw7) && numberRaw7 != null
                                    ? Convert.ToDouble(numberRaw7)
                                    : null,
            renewalPeriodYears: Convert.ToInt64(map["renewalPeriodYears"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "domain", Domain },
            { "tld", Tld },
            { "available", Available },
            { "price", Price },
            { "periodYears", PeriodYears },
            { "premium", Premium },
            { "renewalPrice", RenewalPrice },
            { "renewalPeriodYears", RenewalPeriodYears }
        };
    }
}
