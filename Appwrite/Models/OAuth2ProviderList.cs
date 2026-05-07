
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2ProviderList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("providers")]
        public List<object> Providers { get; private set; }

        public OAuth2ProviderList(
            long total,
            List<object> providers
        )
        {
            Total = total;
            Providers = providers;
        }

        public static OAuth2ProviderList From(Dictionary<string, object> map) => new OAuth2ProviderList(
            total: Convert.ToInt64(map["total"]),
            providers: map["providers"].ConvertToList<object>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "providers", Providers }
        };
    }
}
