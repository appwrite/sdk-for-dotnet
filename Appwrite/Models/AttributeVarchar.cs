
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AttributeVarchar
    {
        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("status")]
        public AttributeStatus Status { get; private set; }

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

        public AttributeVarchar(
            string key,
            string type,
            AttributeStatus status,
            string error,
            bool required,
            bool? array,
            string createdAt,
            string updatedAt,
            long size,
            string? @default,
            bool? encrypt
        )
        {
            Key = key;
            Type = type;
            Status = status;
            Error = error;
            Required = required;
            Array = array;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Size = size;
            Default = @default;
            Encrypt = encrypt;
        }

        public static AttributeVarchar From(Dictionary<string, object> map) => new AttributeVarchar(
            key: map["key"].ToString(),
            type: map["type"].ToString(),
            status: new AttributeStatus(map["status"].ToString()!),
            error: map["error"].ToString(),
            required: (bool)map["required"],
            array: map.TryGetValue("array", out var boolRaw6) && boolRaw6 != null
                                        ? (bool?)boolRaw6
                                        : null,
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            size: Convert.ToInt64(map["size"]),
            @default: map.TryGetValue("default", out var @default) ? @default?.ToString() : null,
            encrypt: map.TryGetValue("encrypt", out var boolRaw11) && boolRaw11 != null
                                        ? (bool?)boolRaw11
                                        : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "type", Type },
            { "status", Status.Value },
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
