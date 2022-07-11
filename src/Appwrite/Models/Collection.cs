
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Collection
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

        [JsonProperty("databaseId")]
        public string DatabaseId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("permission")]
        public string Permission { get; set; }

        [JsonProperty("attributes")]
        public List<object> Attributes { get; set; }

        [JsonProperty("indexes")]
        public List<Index> Indexes { get; set; }


        public Collection(
            string id,
            long createdAt,
            long updatedAt,
            List<object> read,
            List<object> write,
            string databaseId,
            string name,
            bool enabled,
            string permission,
            List<object> attributes,
            List<Index> indexes
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Read = read;
            Write = write;
            DatabaseId = databaseId;
            Name = name;
            Enabled = enabled;
            Permission = permission;
            Attributes = attributes;
            Indexes = indexes;
        }

        public static Collection From(Dictionary<string, object> map) => new Collection(
            id: (string)map["$id"],
            createdAt: Convert.ToInt64(map["$createdAt"]),
            updatedAt: Convert.ToInt64(map["$updatedAt"]),
            read: ((JArray)map["$read"]).ToObject<List<object>>(),
            write: ((JArray)map["$write"]).ToObject<List<object>>(),
            databaseId: (string)map["databaseId"],
            name: (string)map["name"],
            enabled: (bool)map["enabled"],
            permission: (string)map["permission"],
            attributes: ((JArray)map["attributes"]).ToObject<List<object>>(),
            indexes: ((JArray)map["indexes"]).ToObject<List<Dictionary<string, object>>>().Select(it => Index.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "$read", Read },
            { "$write", Write },
            { "databaseId", DatabaseId },
            { "name", Name },
            { "enabled", Enabled },
            { "permission", Permission },
            { "attributes", Attributes },
            { "indexes", Indexes.Select(it => it.ToMap()) }
        };
    }
}