
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class ResourceTokenList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("tokens")]
        public List<ResourceToken> Tokens { get; private set; }

        public ResourceTokenList(
            long total,
            List<ResourceToken> tokens
        ) {
            Total = total;
            Tokens = tokens;
        }

        public static ResourceTokenList From(Dictionary<string, object> map) => new ResourceTokenList(
            total: Convert.ToInt64(map["total"]),
            tokens: map["tokens"].ConvertToList<Dictionary<string, object>>().Select(it => ResourceToken.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "tokens", Tokens.Select(it => it.ToMap()) }
        };
    }
}
