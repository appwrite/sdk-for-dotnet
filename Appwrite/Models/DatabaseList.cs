
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class DatabaseList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("databases")]
        public List<Database> Databases { get; private set; }

        public DatabaseList(
            long total,
            List<Database> databases
        ) {
            Total = total;
            Databases = databases;
        }

        public static DatabaseList From(Dictionary<string, object> map) => new DatabaseList(
            total: Convert.ToInt64(map["total"]),
            databases: ((JArray)map["databases"]).ToObject<List<Dictionary<string, object>>>().Select(it => Database.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "databases", Databases.Select(it => it.ToMap()) }
        };
    }
}