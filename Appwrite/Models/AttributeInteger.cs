using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class AttributeInteger
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
        public string createdAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string updatedAt { get; private set; }

        [JsonPropertyName("min")]
        public long? Min { get; private set; }

        [JsonPropertyName("max")]
        public long? Max { get; private set; }

        [JsonPropertyName("default")]
        public long? @Default { get; private set; }

        public AttributeInteger(
            string key,
            string type,
            AttributeStatus status,
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
            createdAt = createdAt;
            updatedAt = updatedAt;
            Min = min;
            Max = max;
            @Default = xdefault;
        }

        public static AttributeInteger From(Dictionary<string, object> map) => new AttributeInteger(
            key: map["key"].ToString(),
            type: map["type"].ToString(),
            status: new AttributeStatus(map["status"].ToString()!),
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
            { "$createdAt", createdAt },
            { "$updatedAt", updatedAt },
            { "min", Min },
            { "max", Max },
            { "default", @Default }
        };
    }
}
