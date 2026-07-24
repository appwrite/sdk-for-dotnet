
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class ColumnBoolean
    {
        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("status")]
        public Appwrite.Enums.ColumnStatus Status { get; private set; }

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

        [JsonPropertyName("default")]
        public bool? Default { get; private set; }

        public ColumnBoolean(
            string key,
            string type,
            Appwrite.Enums.ColumnStatus status,
            string error,
            bool required,
            bool? array,
            string createdAt,
            string updatedAt,
            bool? @default
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
            Default = @default;
        }

        public static ColumnBoolean From(Dictionary<string, object> map) => new ColumnBoolean(
            key: map["key"].ToString(),
            type: map["type"].ToString(),
            status: new Appwrite.Enums.ColumnStatus(map["status"].ToString()!),
            error: map["error"].ToString(),
            required: (bool)map["required"],
            array: map.TryGetValue("array", out var boolRaw6) && boolRaw6 != null
                                        ? (bool?)boolRaw6
                                        : null,
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            @default: map.TryGetValue("default", out var boolRaw9) && boolRaw9 != null
                                        ? (bool?)boolRaw9
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
            { "default", Default }
        };
    }
}
