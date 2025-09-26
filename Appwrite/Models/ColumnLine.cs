using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class ColumnLine
    {
        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        [JsonPropertyName("error")]
        public string Error { get; private set; }

        [JsonPropertyName("required")]
        public bool Required { get; private set; }

        [JsonPropertyName("array")]
        public bool? Array { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string createdAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string updatedAt { get; private set; }

        [JsonPropertyName("default")]
        public List&lt;object&gt;? @Default { get; private set; }

        public ColumnLine(
            string key,
            string type,
            string status,
            string error,
            bool required,
            bool? array,
            string createdAt,
            string updatedAt,
            List&lt;object&gt;? xdefault
        ) {
            Key = key;
            Type = type;
            Status = status;
            Error = error;
            Required = required;
            Array = array;
            createdAt = createdAt;
            updatedAt = updatedAt;
            @Default = xdefault;
        }

        public static ColumnLine From(Dictionary<string, object> map) => new ColumnLine(
            key: map["key"].ToString(),
            type: map["type"].ToString(),
            status: map["status"].ToString(),
            error: map["error"].ToString(),
            required: (bool)map["required"],
            array: (bool?)map["array"],
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            xdefault: map["default"] is JsonElement jsonArrayProp9 ? jsonArrayProp9.Deserialize<List<object>>()! : (List<object>)map["default"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "type", Type },
            { "status", Status },
            { "error", Error },
            { "required", Required },
            { "array", Array },
            { "$createdAt", createdAt },
            { "$updatedAt", updatedAt },
            { "default", @Default }
        };
    }
}
