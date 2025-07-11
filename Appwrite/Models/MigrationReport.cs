
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class MigrationReport
    {
        [JsonPropertyName("user")]
        public long User { get; private set; }

        [JsonPropertyName("team")]
        public long Team { get; private set; }

        [JsonPropertyName("database")]
        public long Database { get; private set; }

        [JsonPropertyName("document")]
        public long Document { get; private set; }

        [JsonPropertyName("file")]
        public long File { get; private set; }

        [JsonPropertyName("bucket")]
        public long Bucket { get; private set; }

        [JsonPropertyName("function")]
        public long Function { get; private set; }

        [JsonPropertyName("size")]
        public long Size { get; private set; }

        [JsonPropertyName("version")]
        public string Version { get; private set; }

        public MigrationReport(
            long user,
            long team,
            long database,
            long document,
            long file,
            long bucket,
            long function,
            long size,
            string version
        ) {
            User = user;
            Team = team;
            Database = database;
            Document = document;
            File = file;
            Bucket = bucket;
            Function = function;
            Size = size;
            Version = version;
        }

        public static MigrationReport From(Dictionary<string, object> map) => new MigrationReport(
            user: Convert.ToInt64(map["user"]),
            team: Convert.ToInt64(map["team"]),
            database: Convert.ToInt64(map["database"]),
            document: Convert.ToInt64(map["document"]),
            file: Convert.ToInt64(map["file"]),
            bucket: Convert.ToInt64(map["bucket"]),
            function: Convert.ToInt64(map["function"]),
            size: Convert.ToInt64(map["size"]),
            version: map["version"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "user", User },
            { "team", Team },
            { "database", Database },
            { "document", Document },
            { "file", File },
            { "bucket", Bucket },
            { "function", Function },
            { "size", Size },
            { "version", Version }
        };
    }
}
