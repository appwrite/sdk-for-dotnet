
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class BackupRestorationList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("restorations")]
        public List<BackupRestoration> Restorations { get; private set; }

        public BackupRestorationList(
            long total,
            List<BackupRestoration> restorations
        ) {
            Total = total;
            Restorations = restorations;
        }

        public static BackupRestorationList From(Dictionary<string, object> map) => new BackupRestorationList(
            total: Convert.ToInt64(map["total"]),
            restorations: map["restorations"].ConvertToList<Dictionary<string, object>>().Select(it => BackupRestoration.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "restorations", Restorations.Select(it => it.ToMap()) }
        };
    }
}
