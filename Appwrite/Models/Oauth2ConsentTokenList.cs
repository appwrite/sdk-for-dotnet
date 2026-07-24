
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Oauth2ConsentTokenList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("tokens")]
        public List<Oauth2ConsentToken> Tokens { get; private set; }

        public Oauth2ConsentTokenList(
            long total,
            List<Oauth2ConsentToken> tokens
        )
        {
            Total = total;
            Tokens = tokens;
        }

        public static Oauth2ConsentTokenList From(Dictionary<string, object> map) => new Oauth2ConsentTokenList(
            total: Convert.ToInt64(map["total"]),
            tokens: map["tokens"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Oauth2ConsentToken.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "tokens", Tokens?.Select(it => it.ToMap()).ToList() }
        };
    }
}
