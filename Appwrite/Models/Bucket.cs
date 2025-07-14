
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class Bucket
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("$permissions")]
        public List<string> Permissions { get; private set; }

        [JsonPropertyName("fileSecurity")]
        public bool FileSecurity { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("maximumFileSize")]
        public long MaximumFileSize { get; private set; }

        [JsonPropertyName("allowedFileExtensions")]
        public List<string> AllowedFileExtensions { get; private set; }

        [JsonPropertyName("compression")]
        public string Compression { get; private set; }

        [JsonPropertyName("encryption")]
        public bool Encryption { get; private set; }

        [JsonPropertyName("antivirus")]
        public bool Antivirus { get; private set; }

        public Bucket(
            string id,
            string createdAt,
            string updatedAt,
            List<string> permissions,
            bool fileSecurity,
            string name,
            bool enabled,
            long maximumFileSize,
            List<string> allowedFileExtensions,
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
            permissions: map["$permissions"] is JsonElement jsonArrayProp4 ? jsonArrayProp4.Deserialize<List<string>>()! : (List<string>)map["$permissions"],
            fileSecurity: (bool)map["fileSecurity"],
            name: map["name"].ToString(),
            enabled: (bool)map["enabled"],
            maximumFileSize: Convert.ToInt64(map["maximumFileSize"]),
            allowedFileExtensions: map["allowedFileExtensions"] is JsonElement jsonArrayProp9 ? jsonArrayProp9.Deserialize<List<string>>()! : (List<string>)map["allowedFileExtensions"],
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
