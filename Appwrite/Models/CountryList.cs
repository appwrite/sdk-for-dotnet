
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class CountryList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("countries")]
        public List<Country> Countries { get; private set; }

        public CountryList(
            long total,
            List<Country> countries
        ) {
            Total = total;
            Countries = countries;
        }

        public static CountryList From(Dictionary<string, object> map) => new CountryList(
            total: Convert.ToInt64(map["total"]),
            countries: ((JArray)map["countries"]).ToObject<List<Dictionary<string, object>>>().Select(it => Country.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "countries", Countries.Select(it => it.ToMap()) }
        };
    }
}