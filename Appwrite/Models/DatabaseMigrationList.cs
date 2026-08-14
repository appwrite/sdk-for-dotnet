
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DatabaseMigrationList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("migrations")]
        public List<DatabaseMigration> Migrations { get; private set; }

        public DatabaseMigrationList(
            long total,
            List<DatabaseMigration> migrations
        )
        {
            Total = total;
            Migrations = migrations;
        }

        public static DatabaseMigrationList From(Dictionary<string, object> map) => new DatabaseMigrationList(
            total: Convert.ToInt64(map["total"]),
            migrations: map["migrations"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.DatabaseMigration.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "migrations", Migrations?.Select(it => it.ToMap()).ToList() }
        };
    }
}
