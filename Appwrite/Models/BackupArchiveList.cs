
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class BackupArchiveList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("archives")]
        public List<BackupArchive> Archives { get; private set; }

        public BackupArchiveList(
            long total,
            List<BackupArchive> archives
        ) {
            Total = total;
            Archives = archives;
        }

        public static BackupArchiveList From(Dictionary<string, object> map) => new BackupArchiveList(
            total: Convert.ToInt64(map["total"]),
            archives: map["archives"].ConvertToList<Dictionary<string, object>>().Select(it => BackupArchive.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "archives", Archives.Select(it => it.ToMap()) }
        };
    }
}
