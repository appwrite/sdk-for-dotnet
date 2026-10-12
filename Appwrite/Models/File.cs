
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class File
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("bucketId")]
        public string BucketId { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("$permissions")]
        public List<string> Permissions { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("folder")]
        public string Folder { get; private set; }

        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("signature")]
        public string Signature { get; private set; }

        [JsonPropertyName("mimeType")]
        public string MimeType { get; private set; }

        [JsonPropertyName("sizeOriginal")]
        public long SizeOriginal { get; private set; }

        [JsonPropertyName("sizeActual")]
        public long SizeActual { get; private set; }

        [JsonPropertyName("chunksTotal")]
        public long ChunksTotal { get; private set; }

        [JsonPropertyName("chunksUploaded")]
        public long ChunksUploaded { get; private set; }

        [JsonPropertyName("encryption")]
        public bool Encryption { get; private set; }

        [JsonPropertyName("compression")]
        public string Compression { get; private set; }

        public File(
            string id,
            string bucketId,
            string createdAt,
            string updatedAt,
            List<string> permissions,
            string name,
            string folder,
            string key,
            string signature,
            string mimeType,
            long sizeOriginal,
            long sizeActual,
            long chunksTotal,
            long chunksUploaded,
            bool encryption,
            string compression
        )
        {
            Id = id;
            BucketId = bucketId;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Permissions = permissions;
            Name = name;
            Folder = folder;
            Key = key;
            Signature = signature;
            MimeType = mimeType;
            SizeOriginal = sizeOriginal;
            SizeActual = sizeActual;
            ChunksTotal = chunksTotal;
            ChunksUploaded = chunksUploaded;
            Encryption = encryption;
            Compression = compression;
        }

        public static File From(Dictionary<string, object> map) => new File(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            bucketId: (map.ContainsKey("bucketId") ? map["bucketId"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            permissions: (map.ContainsKey("$permissions") ? map["$permissions"] : new List<object>()).ConvertToList<string>(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            folder: (map.ContainsKey("folder") ? map["folder"] : "").ToString(),
            key: (map.ContainsKey("key") ? map["key"] : "").ToString(),
            signature: (map.ContainsKey("signature") ? map["signature"] : "").ToString(),
            mimeType: (map.ContainsKey("mimeType") ? map["mimeType"] : "").ToString(),
            sizeOriginal: Convert.ToInt64((map.ContainsKey("sizeOriginal") ? map["sizeOriginal"] : 0)),
            sizeActual: Convert.ToInt64((map.ContainsKey("sizeActual") ? map["sizeActual"] : 0)),
            chunksTotal: Convert.ToInt64((map.ContainsKey("chunksTotal") ? map["chunksTotal"] : 0)),
            chunksUploaded: Convert.ToInt64((map.ContainsKey("chunksUploaded") ? map["chunksUploaded"] : 0)),
            encryption: (bool)(map.ContainsKey("encryption") ? map["encryption"] : false),
            compression: (map.ContainsKey("compression") ? map["compression"] : "none").ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "bucketId", BucketId },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "$permissions", Permissions },
            { "name", Name },
            { "folder", Folder },
            { "key", Key },
            { "signature", Signature },
            { "mimeType", MimeType },
            { "sizeOriginal", SizeOriginal },
            { "sizeActual", SizeActual },
            { "chunksTotal", ChunksTotal },
            { "chunksUploaded", ChunksUploaded },
            { "encryption", Encryption },
            { "compression", Compression }
        };
    }
}
