using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class ColumnFloat
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

        [JsonPropertyName("min")]
        public double? Min { get; private set; }

        [JsonPropertyName("max")]
        public double? Max { get; private set; }

        [JsonPropertyName("default")]
        public double? @Default { get; private set; }

        public ColumnFloat(
            string key,
            string type,
            ColumnStatus status,
            string error,
            bool required,
            bool? array,
            string createdAt,
            string updatedAt,
            double? min,
            double? max,
            double? xdefault
        ) {
            Key = key;
            Type = type;
            Status = status;
            Error = error;
            Required = required;
            Array = array;
            createdAt = createdAt;
            updatedAt = updatedAt;
            Min = min;
            Max = max;
            @Default = xdefault;
        }

        public static ColumnFloat From(Dictionary<string, object> map) => new ColumnFloat(
            key: map["key"].ToString(),
            type: map["type"].ToString(),
            status: new ColumnStatus(map["status"].ToString()!),
            error: map["error"].ToString(),
            required: (bool)map["required"],
            array: (bool?)map["array"],
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            min: map["min"] == null ? null :Convert.ToDouble(map["min"]),
            max: map["max"] == null ? null :Convert.ToDouble(map["max"]),
            xdefault: map["default"] == null ? null :Convert.ToDouble(map["default"])
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
            { "min", Min },
            { "max", Max },
            { "default", @Default }
        };
    }
}
