
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class CountryList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("countries")]
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
            countries: map["countries"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Country.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["countries"]).Select(it => Country.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "countries", Countries.Select(it => it.ToMap()) }
        };
    }
}
