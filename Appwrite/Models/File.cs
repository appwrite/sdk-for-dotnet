using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class File
    {
        [JsonPropertyName("$id")]
        public string id { get; private set; }

        [JsonPropertyName("bucketId")]
        public string BucketId { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string createdAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string updatedAt { get; private set; }

        [JsonPropertyName("$permissions")]
        public List&lt;string&gt; permissions { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("signature")]
        public string Signature { get; private set; }

        [JsonPropertyName("mimeType")]
        public string MimeType { get; private set; }

        [JsonPropertyName("sizeOriginal")]
        public long SizeOriginal { get; private set; }

        [JsonPropertyName("chunksTotal")]
        public long ChunksTotal { get; private set; }

        [JsonPropertyName("chunksUploaded")]
        public long ChunksUploaded { get; private set; }

        public File(
            string id,
            string bucketId,
            string createdAt,
            string updatedAt,
            List&lt;string&gt; permissions,
            string name,
            string signature,
            string mimeType,
            long sizeOriginal,
            long chunksTotal,
            long chunksUploaded
        ) {
            id = id;
            BucketId = bucketId;
            createdAt = createdAt;
            updatedAt = updatedAt;
            permissions = permissions;
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
            permissions: map["$permissions"] is JsonElement jsonArrayProp5 ? jsonArrayProp5.Deserialize<List<string>>()! : (List<string>)map["$permissions"],
            name: map["name"].ToString(),
            signature: map["signature"].ToString(),
            mimeType: map["mimeType"].ToString(),
            sizeOriginal: Convert.ToInt64(map["sizeOriginal"]),
            chunksTotal: Convert.ToInt64(map["chunksTotal"]),
            chunksUploaded: Convert.ToInt64(map["chunksUploaded"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", id },
            { "bucketId", BucketId },
            { "$createdAt", createdAt },
            { "$updatedAt", updatedAt },
            { "$permissions", permissions },
            { "name", Name },
            { "signature", Signature },
            { "mimeType", MimeType },
            { "sizeOriginal", SizeOriginal },
            { "chunksTotal", ChunksTotal },
            { "chunksUploaded", ChunksUploaded }
        };
    }
}
