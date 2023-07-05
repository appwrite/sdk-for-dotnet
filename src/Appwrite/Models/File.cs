
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class File
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("bucketId")]
        public string BucketId { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("$permissions")]
        public List<object> Permissions { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("signature")]
        public string Signature { get; private set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; private set; }

        [JsonProperty("sizeOriginal")]
        public long SizeOriginal { get; private set; }

        [JsonProperty("chunksTotal")]
        public long ChunksTotal { get; private set; }

        [JsonProperty("chunksUploaded")]
        public long ChunksUploaded { get; private set; }

        public File(
            string id,
            string bucketId,
            string createdAt,
            string updatedAt,
            List<object> permissions,
            string name,
            string signature,
            string mimeType,
            long sizeOriginal,
            long chunksTotal,
            long chunksUploaded
        ) {
            Id = id;
            BucketId = bucketId;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Permissions = permissions;
            Name = name;
            Signature = signature;
            MimeType = mimeType;
            SizeOriginal = sizeOriginal;
            ChunksTotal = chunksTotal;
            ChunksUploaded = chunksUploaded;
        }

        public static File From(Dictionary<string, object> map) => new File(
            id: map["$id"].ToString(),
            bucketId: map["bucketId"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            permissions: ((JArray)map["$permissions"]).ToObject<List<object>>(),
            name: map["name"].ToString(),
            signature: map["signature"].ToString(),
            mimeType: map["mimeType"].ToString(),
            sizeOriginal: Convert.ToInt64(map["sizeOriginal"]),
            chunksTotal: Convert.ToInt64(map["chunksTotal"]),
            chunksUploaded: Convert.ToInt64(map["chunksUploaded"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "bucketId", BucketId },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "$permissions", Permissions },
            { "name", Name },
            { "signature", Signature },
            { "mimeType", MimeType },
            { "sizeOriginal", SizeOriginal },
            { "chunksTotal", ChunksTotal },
            { "chunksUploaded", ChunksUploaded }
        };
    }
}