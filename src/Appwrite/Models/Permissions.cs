
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Permissions
    {
        [JsonProperty("read")]
        public List<object> Read { get; set; }

        [JsonProperty("write")]
        public List<object> Write { get; set; }


        public Permissions(
            List<object> read,
            List<object> write
        ) {
            Read = read;
            Write = write;
        }

        public static Permissions From(Dictionary<string, object> map) => new Permissions(
            read: ((JArray)map["read"]).ToObject<List<object>>(),
            write: ((JArray)map["write"]).ToObject<List<object>>()
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "read", Read },
            { "write", Write }
        };
    }
}