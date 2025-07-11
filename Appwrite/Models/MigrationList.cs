
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class MigrationList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("migrations")]
        public List<Migration> Migrations { get; private set; }

        public MigrationList(
            long total,
            List<Migration> migrations
        ) {
            Total = total;
            Migrations = migrations;
        }

        public static MigrationList From(Dictionary<string, object> map) => new MigrationList(
            total: Convert.ToInt64(map["total"]),
            migrations: map["migrations"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Migration.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["migrations"]).Select(it => Migration.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "migrations", Migrations.Select(it => it.ToMap()) }
        };
    }
}
