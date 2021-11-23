
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class CountryList
    {
        [JsonProperty("sum")]
        public int Sum { get; set; }

        [JsonProperty("countries")]
        public List<Country> Countries { get; set; }


        public CountryList(
            int sum,
            List<Country> countries
        ) {
            Sum = sum;
            Countries = countries;
        }

        public static CountryList From(Dictionary<string, object> map) => new CountryList(
            sum: (int)map["sum"],
            countries: ((JArray)map["countries"]).ToObject<List<Country>>()!
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "sum", Sum },
            { "countries", Countries.Select(it => it.ToMap()) }
        };
    }
}