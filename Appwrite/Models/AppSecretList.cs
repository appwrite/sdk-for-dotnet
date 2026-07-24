
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AppSecretList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("secrets")]
        public List<AppSecret> Secrets { get; private set; }

        public AppSecretList(
            long total,
            List<AppSecret> secrets
        )
        {
            Total = total;
            Secrets = secrets;
        }

        public static AppSecretList From(Dictionary<string, object> map) => new AppSecretList(
            total: Convert.ToInt64(map["total"]),
            secrets: map["secrets"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.AppSecret.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "secrets", Secrets?.Select(it => it.ToMap()).ToList() }
        };
    }
}
