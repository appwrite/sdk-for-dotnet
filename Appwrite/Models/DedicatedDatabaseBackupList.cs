
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseBackupList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("backups")]
        public List<DedicatedDatabaseBackup> Backups { get; private set; }

        public DedicatedDatabaseBackupList(
            long total,
            List<DedicatedDatabaseBackup> backups
        )
        {
            Total = total;
            Backups = backups;
        }

        public static DedicatedDatabaseBackupList From(Dictionary<string, object> map) => new DedicatedDatabaseBackupList(
            total: Convert.ToInt64(map["total"]),
            backups: map["backups"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.DedicatedDatabaseBackup.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "backups", Backups?.Select(it => it.ToMap()).ToList() }
        };
    }
}
