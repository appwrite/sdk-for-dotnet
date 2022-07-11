
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
        public string Id { get; set; }

        [JsonProperty("$createdAt")]
        public long CreatedAt { get; set; }

        [JsonProperty("$updatedAt")]
        public long UpdatedAt { get; set; }

        [JsonProperty("$read")]
        public List<object> Read { get; set; }

        [JsonProperty("$write")]
        public List<object> Write { get; set; }

        [JsonProperty("permission")]
        public string Permission { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("maximumFileSize")]
        public long MaximumFileSize { get; set; }

        [JsonProperty("allowedFileExtensions")]
        public List<object> AllowedFileExtensions { get; set; }

        [JsonProperty("encryption")]
        public bool Encryption { get; set; }

        [JsonProperty("antivirus")]
        public bool Antivirus { get; set; }


        public Bucket(
            string id,
            long createdAt,
            long updatedAt,
            List<object> read,
            List<object> write,
            string permission,
            string name,
            bool enabled,
            long maximumFileSize,
            List<object> allowedFileExtensions,
            bool encryption,
            bool antivirus
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Read = read;
            Write = write;
            Permission = permission;
            Name = name;
            Enabled = enabled;
            MaximumFileSize = maximumFileSize;
            AllowedFileExtensions = allowedFileExtensions;
            Encryption = encryption;
            Antivirus = antivirus;
        }

        public static Bucket From(Dictionary<string, object> map) => new Bucket(
            id: (string)map["$id"],
            createdAt: Convert.ToInt64(map["$createdAt"]),
            updatedAt: Convert.ToInt64(map["$updatedAt"]),
            read: ((JArray)map["$read"]).ToObject<List<object>>(),
            write: ((JArray)map["$write"]).ToObject<List<object>>(),
            permission: (string)map["permission"],
            name: (string)map["name"],
            enabled: (bool)map["enabled"],
            maximumFileSize: Convert.ToInt64(map["maximumFileSize"]),
            allowedFileExtensions: ((JArray)map["allowedFileExtensions"]).ToObject<List<object>>(),
            encryption: (bool)map["encryption"],
            antivirus: (bool)map["antivirus"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "$read", Read },
            { "$write", Write },
            { "permission", Permission },
            { "name", Name },
            { "enabled", Enabled },
            { "maximumFileSize", MaximumFileSize },
            { "allowedFileExtensions", AllowedFileExtensions },
            { "encryption", Encryption },
            { "antivirus", Antivirus }
        };
    }
}