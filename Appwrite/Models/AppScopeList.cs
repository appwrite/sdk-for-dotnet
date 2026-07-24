
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AppScopeList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("scopes")]
        public List<AppScope> Scopes { get; private set; }

        public AppScopeList(
            long total,
            List<AppScope> scopes
        )
        {
            Total = total;
            Scopes = scopes;
        }

        public static AppScopeList From(Dictionary<string, object> map) => new AppScopeList(
            total: Convert.ToInt64(map["total"]),
            scopes: map["scopes"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.AppScope.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "scopes", Scopes?.Select(it => it.ToMap()).ToList() }
        };
    }
}
