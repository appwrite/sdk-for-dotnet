
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class ContinentList
    {
        [JsonProperty("sum")]
        public int Sum { get; set; }

        [JsonProperty("continents")]
        public List<Continent> Continents { get; set; }


        public ContinentList(
            int sum,
            List<Continent> continents
        ) {
            Sum = sum;
            Continents = continents;
        }

        public static ContinentList From(Dictionary<string, object> map) => new ContinentList(
            sum: (int)map["sum"],
            continents: ((JArray)map["continents"]).ToObject<List<Continent>>()!
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "sum", Sum },
            { "continents", Continents.Select(it => it.ToMap()) }
        };
    }
}