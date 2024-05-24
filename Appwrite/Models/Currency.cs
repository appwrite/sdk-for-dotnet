
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
        public string Symbol { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("symbolNative")]
        public string SymbolNative { get; private set; }

        [JsonProperty("decimalDigits")]
        public long DecimalDigits { get; private set; }

        [JsonProperty("rounding")]
        public double Rounding { get; private set; }

        [JsonProperty("code")]
        public string Code { get; private set; }

        [JsonProperty("namePlural")]
        public string NamePlural { get; private set; }

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
            symbol: map["symbol"].ToString(),
            name: map["name"].ToString(),
            symbolNative: map["symbolNative"].ToString(),
            decimalDigits: Convert.ToInt64(map["decimalDigits"]),
            rounding: Convert.ToDouble(map["rounding"]),
            code: map["code"].ToString(),
            namePlural: map["namePlural"].ToString()
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