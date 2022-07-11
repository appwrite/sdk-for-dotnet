
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Currency
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbolNative")]
        public string SymbolNative { get; set; }

        [JsonProperty("decimalDigits")]
        public long DecimalDigits { get; set; }

        [JsonProperty("rounding")]
        public double Rounding { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("namePlural")]
        public string NamePlural { get; set; }


        public Currency(
            string symbol,
            string name,
            string symbolNative,
            long decimalDigits,
            double rounding,
            string code,
            string namePlural
        ) {
            Symbol = symbol;
            Name = name;
            SymbolNative = symbolNative;
            DecimalDigits = decimalDigits;
            Rounding = rounding;
            Code = code;
            NamePlural = namePlural;
        }

        public static Currency From(Dictionary<string, object> map) => new Currency(
            symbol: (string)map["symbol"],
            name: (string)map["name"],
            symbolNative: (string)map["symbolNative"],
            decimalDigits: Convert.ToInt64(map["decimalDigits"]),
            rounding: Convert.ToDouble(map["rounding"]),
            code: (string)map["code"],
            namePlural: (string)map["namePlural"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "symbol", Symbol },
            { "name", Name },
            { "symbolNative", SymbolNative },
            { "decimalDigits", DecimalDigits },
            { "rounding", Rounding },
            { "code", Code },
            { "namePlural", NamePlural }
        };
    }
}