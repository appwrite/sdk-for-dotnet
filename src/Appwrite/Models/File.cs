
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

        [JsonProperty("$permissions")]
        public Permissions Permissions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("dateCreated")]
        public int DateCreated { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("sizeOriginal")]
        public int SizeOriginal { get; set; }


        public File(
            string id,
            Permissions permissions,
            string name,
            int dateCreated,
            string signature,
            string mimeType,
            int sizeOriginal
        ) {
            Id = id;
            Permissions = permissions;
            Name = name;
            DateCreated = dateCreated;
            Signature = signature;
            MimeType = mimeType;
            SizeOriginal = sizeOriginal;
        }

        public static File From(Dictionary<string, object> map) => new File(
            id: (string)map["$id"],
            permissions: Permissions.From(map: ((JObject)map["$permissions"]).ToObject<Dictionary<string, object>>()!),
            name: (string)map["name"],
            dateCreated: (int)map["dateCreated"],
            signature: (string)map["signature"],
            mimeType: (string)map["mimeType"],
            sizeOriginal: (int)map["sizeOriginal"]
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "$id", Id },
            { "$permissions", Permissions.ToMap() },
            { "name", Name },
            { "dateCreated", DateCreated },
            { "signature", Signature },
            { "mimeType", MimeType },
            { "sizeOriginal", SizeOriginal }
        };
    }
}