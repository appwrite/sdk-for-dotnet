
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Bucket
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("$permissions")]
        public List<object> Permissions { get; private set; }

        [JsonProperty("fileSecurity")]
        public bool FileSecurity { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; private set; }

        [JsonProperty("maximumFileSize")]
        public long MaximumFileSize { get; private set; }

        [JsonProperty("allowedFileExtensions")]
        public List<object> AllowedFileExtensions { get; private set; }

        [JsonProperty("compression")]
        public string Compression { get; private set; }

        [JsonProperty("encryption")]
        public bool Encryption { get; private set; }

        [JsonProperty("antivirus")]
        public bool Antivirus { get; private set; }

        public Bucket(
            string id,
            string createdAt,
            string updatedAt,
            List<object> permissions,
            bool fileSecurity,
            string name,
            bool enabled,
            long maximumFileSize,
            List<object> allowedFileExtensions,
            string compression,
            bool encryption,
            bool antivirus
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Permissions = permissions;
            FileSecurity = fileSecurity;
            Name = name;
            Enabled = enabled;
            MaximumFileSize = maximumFileSize;
            AllowedFileExtensions = allowedFileExtensions;
            Compression = compression;
            Encryption = encryption;
            Antivirus = antivirus;
        }

        public static Bucket From(Dictionary<string, object> map) => new Bucket(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            permissions: ((JArray)map["$permissions"]).ToObject<List<object>>(),
            fileSecurity: (bool)map["fileSecurity"],
            name: map["name"].ToString(),
            enabled: (bool)map["enabled"],
            maximumFileSize: Convert.ToInt64(map["maximumFileSize"]),
            allowedFileExtensions: ((JArray)map["allowedFileExtensions"]).ToObject<List<object>>(),
            compression: map["compression"].ToString(),
            encryption: (bool)map["encryption"],
            antivirus: (bool)map["antivirus"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "$permissions", Permissions },
            { "fileSecurity", FileSecurity },
            { "name", Name },
            { "enabled", Enabled },
            { "maximumFileSize", MaximumFileSize },
            { "allowedFileExtensions", AllowedFileExtensions },
            { "compression", Compression },
            { "encryption", Encryption },
            { "antivirus", Antivirus }
        };
    }
}