
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class ColumnString
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
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("size")]
        public long Size { get; private set; }

        [JsonPropertyName("default")]
        public string? Default { get; private set; }

        [JsonPropertyName("encrypt")]
        public bool? Encrypt { get; private set; }

        public ColumnString(
            string key,
            string type,
            string status,
            string error,
            bool required,
            bool? array,
            string createdAt,
            string updatedAt,
            long size,
            string? xdefault,
            bool? encrypt
        ) {
            Key = key;
            Type = type;
            Status = status;
            Error = error;
            Required = required;
            Array = array;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Size = size;
            Default = xdefault;
            Encrypt = encrypt;
        }

        public static ColumnString From(Dictionary<string, object> map) => new ColumnString(
            key: map["key"].ToString(),
            type: map["type"].ToString(),
            status: map["status"].ToString(),
            error: map["error"].ToString(),
            required: (bool)map["required"],
            array: (bool?)map["array"],
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            size: Convert.ToInt64(map["size"]),
            xdefault: map.TryGetValue("default", out var xdefault) ? xdefault?.ToString() : null,
            encrypt: (bool?)map["encrypt"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "type", Type },
            { "status", Status },
            { "error", Error },
            { "required", Required },
            { "array", Array },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "size", Size },
            { "default", Default },
            { "encrypt", Encrypt }
        };
    }
}
