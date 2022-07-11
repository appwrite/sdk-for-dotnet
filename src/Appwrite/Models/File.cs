
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
        public string Id { get; set; }

        [JsonProperty("bucketId")]
        public string BucketId { get; set; }

        [JsonProperty("$createdAt")]
        public long CreatedAt { get; set; }

        [JsonProperty("$updatedAt")]
        public long UpdatedAt { get; set; }

        [JsonProperty("$read")]
        public List<object> Read { get; set; }

        [JsonProperty("$write")]
        public List<object> Write { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("sizeOriginal")]
        public long SizeOriginal { get; set; }

        [JsonProperty("chunksTotal")]
        public long ChunksTotal { get; set; }

        [JsonProperty("chunksUploaded")]
        public long ChunksUploaded { get; set; }


        public File(
            string id,
            string bucketId,
            long createdAt,
            long updatedAt,
            List<object> read,
            List<object> write,
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
            Read = read;
            Write = write;
            Name = name;
            Signature = signature;
            MimeType = mimeType;
            SizeOriginal = sizeOriginal;
            ChunksTotal = chunksTotal;
            ChunksUploaded = chunksUploaded;
        }

        public static File From(Dictionary<string, object> map) => new File(
            id: (string)map["$id"],
            bucketId: (string)map["bucketId"],
            createdAt: Convert.ToInt64(map["$createdAt"]),
            updatedAt: Convert.ToInt64(map["$updatedAt"]),
            read: ((JArray)map["$read"]).ToObject<List<object>>(),
            write: ((JArray)map["$write"]).ToObject<List<object>>(),
            name: (string)map["name"],
            signature: (string)map["signature"],
            mimeType: (string)map["mimeType"],
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
            { "$read", Read },
            { "$write", Write },
            { "name", Name },
            { "signature", Signature },
            { "mimeType", MimeType },
            { "sizeOriginal", SizeOriginal },
            { "chunksTotal", ChunksTotal },
            { "chunksUploaded", ChunksUploaded }
        };
    }
}