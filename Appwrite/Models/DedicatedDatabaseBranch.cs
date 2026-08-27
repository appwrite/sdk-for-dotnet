
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseBranch
    {
        [JsonPropertyName("branchId")]
        public string BranchId { get; private set; }

        [JsonPropertyName("branchName")]
        public string BranchName { get; private set; }

        [JsonPropertyName("namespace")]
        public string Namespace { get; private set; }

        [JsonPropertyName("expiresAt")]
        public long ExpiresAt { get; private set; }

        [JsonPropertyName("host")]
        public string Host { get; private set; }

        [JsonPropertyName("port")]
        public long Port { get; private set; }

        [JsonPropertyName("database")]
        public string Database { get; private set; }

        [JsonPropertyName("username")]
        public string Username { get; private set; }

        [JsonPropertyName("password")]
        public string Password { get; private set; }

        [JsonPropertyName("ssl")]
        public bool Ssl { get; private set; }

        [JsonPropertyName("engine")]
        public string Engine { get; private set; }

        [JsonPropertyName("connectionString")]
        public string ConnectionString { get; private set; }

        public DedicatedDatabaseBranch(
            string branchId,
            string branchName,
            string @namespace,
            long expiresAt,
            string host,
            long port,
            string database,
            string username,
            string password,
            bool ssl,
            string engine,
            string connectionString
        )
        {
            BranchId = branchId;
            BranchName = branchName;
            Namespace = @namespace;
            ExpiresAt = expiresAt;
            Host = host;
            Port = port;
            Database = database;
            Username = username;
            Password = password;
            Ssl = ssl;
            Engine = engine;
            ConnectionString = connectionString;
        }

        public static DedicatedDatabaseBranch From(Dictionary<string, object> map) => new DedicatedDatabaseBranch(
            branchId: map["branchId"].ToString(),
            branchName: map["branchName"].ToString(),
            @namespace: map["namespace"].ToString(),
            expiresAt: Convert.ToInt64(map["expiresAt"]),
            host: map["host"].ToString(),
            port: Convert.ToInt64(map["port"]),
            database: map["database"].ToString(),
            username: map["username"].ToString(),
            password: map["password"].ToString(),
            ssl: (bool)map["ssl"],
            engine: map["engine"].ToString(),
            connectionString: map["connectionString"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "branchId", BranchId },
            { "branchName", BranchName },
            { "namespace", Namespace },
            { "expiresAt", ExpiresAt },
            { "host", Host },
            { "port", Port },
            { "database", Database },
            { "username", Username },
            { "password", Password },
            { "ssl", Ssl },
            { "engine", Engine },
            { "connectionString", ConnectionString }
        };
    }
}
