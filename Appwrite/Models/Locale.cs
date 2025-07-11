
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class Locale
    {
        [JsonPropertyName("ip")]
        public string Ip { get; private set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; private set; }

        [JsonPropertyName("country")]
        public string Country { get; private set; }

        [JsonPropertyName("continentCode")]
        public string ContinentCode { get; private set; }

        [JsonPropertyName("continent")]
        public string Continent { get; private set; }

        [JsonPropertyName("eu")]
        public bool Eu { get; private set; }

        [JsonPropertyName("currency")]
        public string Currency { get; private set; }

        public Locale(
            string ip,
            string countryCode,
            string country,
            string continentCode,
            string continent,
            bool eu,
            string currency
        ) {
            Ip = ip;
            CountryCode = countryCode;
            Country = country;
            ContinentCode = continentCode;
            Continent = continent;
            Eu = eu;
            Currency = currency;
        }

        public static Locale From(Dictionary<string, object> map) => new Locale(
            ip: map["ip"].ToString(),
            countryCode: map["countryCode"].ToString(),
            country: map["country"].ToString(),
            continentCode: map["continentCode"].ToString(),
            continent: map["continent"].ToString(),
            eu: (bool)map["eu"],
            currency: map["currency"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "ip", Ip },
            { "countryCode", CountryCode },
            { "country", Country },
            { "continentCode", ContinentCode },
            { "continent", Continent },
            { "eu", Eu },
            { "currency", Currency }
        };
    }
}
