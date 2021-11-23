
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

        [JsonProperty("$permissions")]
        public Permissions Permissions { get; set; }

        public Dictionary<string, object> Data { get; set; }

        public Document(
            string id,
            string collection,
            Permissions permissions,
            Dictionary<string, object> data
        ) {
            Id = id;
            Collection = collection;
            Permissions = permissions;
            Data = data;
        }

        public static Document From(Dictionary<string, object> map) => new Document(
            id: (string)map["$id"],
            collection: (string)map["$collection"],
            permissions: Permissions.From(map: ((JObject)map["$permissions"]).ToObject<Dictionary<string, object>>()!),
            data: map.ContainsKey("data")
                ? ((JObject)map["data"]).ToObject<Dictionary<string, object>>()!
                : new Dictionary<string, object>()
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "$id", Id },
            { "$collection", Collection },
            { "$permissions", Permissions.ToMap() },
            { "data", Data }
        };

        public T ConvertTo<T>(Func<Dictionary<string, object>, T> fromJson) =>
            fromJson.Invoke(Data);
    }
}