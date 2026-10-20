
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

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

        [JsonPropertyName("description")]
        public string Description { get; private set; }

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

        [JsonPropertyName("transformations")]
        public bool Transformations { get; private set; }

        [JsonPropertyName("totalSize")]
        public long TotalSize { get; private set; }

        public Bucket(
            string id,
            string createdAt,
            string updatedAt,
            List<string> permissions,
            bool fileSecurity,
            string name,
            string description,
            bool enabled,
            long maximumFileSize,
            List<string> allowedFileExtensions,
            string compression,
            bool encryption,
            bool antivirus,
            bool transformations,
            long totalSize
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Permissions = permissions;
            FileSecurity = fileSecurity;
            Name = name;
            Description = description;
            Enabled = enabled;
            MaximumFileSize = maximumFileSize;
            AllowedFileExtensions = allowedFileExtensions;
            Compression = compression;
            Encryption = encryption;
            Antivirus = antivirus;
            Transformations = transformations;
            TotalSize = totalSize;
        }

        public static Bucket From(Dictionary<string, object> map) => new Bucket(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            permissions: (map.ContainsKey("$permissions") ? map["$permissions"] : new List<object>()).ConvertToList<string>(),
            fileSecurity: (bool)(map.ContainsKey("fileSecurity") ? map["fileSecurity"] : false),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            description: (map.ContainsKey("description") ? map["description"] : "").ToString(),
            enabled: (bool)(map.ContainsKey("enabled") ? map["enabled"] : true),
            maximumFileSize: Convert.ToInt64((map.ContainsKey("maximumFileSize") ? map["maximumFileSize"] : 0)),
            allowedFileExtensions: (map.ContainsKey("allowedFileExtensions") ? map["allowedFileExtensions"] : new List<object>()).ConvertToList<string>(),
            compression: (map.ContainsKey("compression") ? map["compression"] : "").ToString(),
            encryption: (bool)(map.ContainsKey("encryption") ? map["encryption"] : true),
            antivirus: (bool)(map.ContainsKey("antivirus") ? map["antivirus"] : true),
            transformations: (bool)(map.ContainsKey("transformations") ? map["transformations"] : true),
            totalSize: Convert.ToInt64((map.ContainsKey("totalSize") ? map["totalSize"] : 0))
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "$permissions", Permissions },
            { "fileSecurity", FileSecurity },
            { "name", Name },
            { "description", Description },
            { "enabled", Enabled },
            { "maximumFileSize", MaximumFileSize },
            { "allowedFileExtensions", AllowedFileExtensions },
            { "compression", Compression },
            { "encryption", Encryption },
            { "antivirus", Antivirus },
            { "transformations", Transformations },
            { "totalSize", TotalSize }
        };
    }
}
