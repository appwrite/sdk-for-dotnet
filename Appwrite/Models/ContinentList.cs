
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class ContinentList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("continents")]
        public List<Continent> Continents { get; private set; }

        public ContinentList(
            long total,
            List<Continent> continents
        ) {
            Total = total;
            Continents = continents;
        }

        public static ContinentList From(Dictionary<string, object> map) => new ContinentList(
            total: Convert.ToInt64(map["total"]),
            continents: ((JArray)map["continents"]).ToObject<List<Dictionary<string, object>>>().Select(it => Continent.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "continents", Continents.Select(it => it.ToMap()) }
        };
    }
}