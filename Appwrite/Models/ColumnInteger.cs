
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class ColumnInteger
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
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("min")]
        public long? Min { get; private set; }

        [JsonPropertyName("max")]
        public long? Max { get; private set; }

        [JsonPropertyName("default")]
        public long? Default { get; private set; }

        public ColumnInteger(
            string key,
            string type,
            ColumnStatus status,
            string error,
            bool required,
            bool? array,
            string createdAt,
            string updatedAt,
            long? min,
            long? max,
            long? xdefault
        ) {
            Key = key;
            Type = type;
            Status = status;
            Error = error;
            Required = required;
            Array = array;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Min = min;
            Max = max;
            Default = xdefault;
        }

        public static ColumnInteger From(Dictionary<string, object> map) => new ColumnInteger(
            key: map["key"].ToString(),
            type: map["type"].ToString(),
            status: new ColumnStatus(map["status"].ToString()!),
            error: map["error"].ToString(),
            required: (bool)map["required"],
            array: (bool?)map["array"],
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            min: map["min"] == null ? null :Convert.ToInt64(map["min"]),
            max: map["max"] == null ? null :Convert.ToInt64(map["max"]),
            xdefault: map["default"] == null ? null :Convert.ToInt64(map["default"])
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
            { "min", Min },
            { "max", Max },
            { "default", Default }
        };
    }
}
