
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AppsList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("apps")]
        public List<App> Apps { get; private set; }

        public AppsList(
            long total,
            List<App> apps
        )
        {
            Total = total;
            Apps = apps;
        }

        public static AppsList From(Dictionary<string, object> map) => new AppsList(
            total: Convert.ToInt64(map["total"]),
            apps: map["apps"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.App.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "apps", Apps?.Select(it => it.ToMap()).ToList() }
        };
    }
}
