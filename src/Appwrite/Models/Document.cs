
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Document
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        [JsonProperty("$collection")]
        public string Collection { get; set; }

        [JsonProperty("$createdAt")]
        public long CreatedAt { get; set; }

        [JsonProperty("$updatedAt")]
        public long UpdatedAt { get; set; }

        [JsonProperty("$read")]
        public List<object> Read { get; set; }

        [JsonProperty("$write")]
        public List<object> Write { get; set; }

        public Dictionary<string, object> Data { get; set; }

        public Document(
            string id,
            string collection,
            long createdAt,
            long updatedAt,
            List<object> read,
            List<object> write,
            Dictionary<string, object> data
        ) {
            Id = id;
            Collection = collection;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Read = read;
            Write = write;
            Data = data;
        }

        public static Document From(Dictionary<string, object> map) => new Document(
            id: (string)map["$id"],
            collection: (string)map["$collection"],
            createdAt: Convert.ToInt64(map["$createdAt"]),
            updatedAt: Convert.ToInt64(map["$updatedAt"]),
            read: ((JArray)map["$read"]).ToObject<List<object>>(),
            write: ((JArray)map["$write"]).ToObject<List<object>>(),
            data: map
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$collection", Collection },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "$read", Read },
            { "$write", Write },
            { "data", Data }
        };

        public T ConvertTo<T>(Func<Dictionary<string, object>, T> fromJson) =>
            fromJson.Invoke(Data);
    }
}