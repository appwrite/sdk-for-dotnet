
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class ContinentList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("continents")]
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
            continents: map["continents"].ConvertToList<Dictionary<string, object>>().Select(it => Continent.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "continents", Continents.Select(it => it.ToMap()) }
        };
    }
}
