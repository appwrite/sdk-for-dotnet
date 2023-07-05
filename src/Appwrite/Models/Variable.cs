
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Variable
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("key")]
        public string Key { get; private set; }

        [JsonProperty("value")]
        public string Value { get; private set; }

        [JsonProperty("functionId")]
        public string FunctionId { get; private set; }

        public Variable(
            string id,
            string createdAt,
            string updatedAt,
            string key,
            string xvalue,
            string functionId
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Key = key;
            Value = xvalue;
            FunctionId = functionId;
        }

        public static Variable From(Dictionary<string, object> map) => new Variable(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            key: map["key"].ToString(),
            xvalue: map["value"].ToString(),
            functionId: map["functionId"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "key", Key },
            { "value", Value },
            { "functionId", FunctionId }
        };
    }
}