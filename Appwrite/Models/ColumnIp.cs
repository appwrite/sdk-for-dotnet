using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class ColumnIp
    {
        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("status")]
        public ColumnStatus Status { get; private set; }

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

        [JsonPropertyName("format")]
        public string Format { get; private set; }

        [JsonPropertyName("default")]
        public string? @Default { get; private set; }

        public ColumnIp(
            string key,
            string type,
            ColumnStatus status,
            string error,
            bool required,
            bool? array,
            string createdAt,
            string updatedAt,
            string format,
            string? xdefault
        ) {
            Key = key;
            Type = type;
            Status = status;
            Error = error;
            Required = required;
            Array = array;
            createdAt = createdAt;
            updatedAt = updatedAt;
            Format = format;
            @Default = xdefault;
        }

        public static ColumnIp From(Dictionary<string, object> map) => new ColumnIp(
            key: map["key"].ToString(),
            type: map["type"].ToString(),
            status: new ColumnStatus(map["status"].ToString()!),
            error: map["error"].ToString(),
            required: (bool)map["required"],
            array: (bool?)map["array"],
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            format: map["format"].ToString(),
            xdefault: map.TryGetValue("default", out var xdefault) ? xdefault?.ToString() : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "type", Type },
            { "status", Status.Value },
            { "error", Error },
            { "required", Required },
            { "array", Array },
            { "$createdAt", createdAt },
            { "$updatedAt", updatedAt },
            { "format", Format },
            { "default", @Default }
        };
    }
}
