
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class ColumnFloat
    {
        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("description")]
        public string Description { get; private set; }

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

        [JsonPropertyName("min")]
        public double? Min { get; private set; }

        [JsonPropertyName("max")]
        public double? Max { get; private set; }

        [JsonPropertyName("default")]
        public double? Default { get; private set; }

        public ColumnFloat(
            string key,
            string description,
            string type,
            Appwrite.Enums.ColumnStatus status,
            string error,
            bool required,
            bool? array,
            string createdAt,
            string updatedAt,
            double? min,
            double? max,
            double? @default
        )
        {
            Key = key;
            Description = description;
            Type = type;
            Status = status;
            Error = error;
            Required = required;
            Array = array;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Min = min;
            Max = max;
            Default = @default;
        }

        public static ColumnFloat From(Dictionary<string, object> map) => new ColumnFloat(
            key: (map.ContainsKey("key") ? map["key"] : "").ToString(),
            description: (map.ContainsKey("description") ? map["description"] : "").ToString(),
            type: (map.ContainsKey("type") ? map["type"] : "").ToString(),
            status: new Appwrite.Enums.ColumnStatus(map["status"].ToString()!),
            error: (map.ContainsKey("error") ? map["error"] : "").ToString(),
            required: (bool)(map.ContainsKey("required") ? map["required"] : false),
            array: map.TryGetValue("array", out var boolRaw7) && boolRaw7 != null
                                        ? (bool?)boolRaw7
                                        : null,
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            min: map.TryGetValue("min", out var numberRaw10) && numberRaw10 != null
                                    ? Convert.ToDouble(numberRaw10)
                                    : null,
            max: map.TryGetValue("max", out var numberRaw11) && numberRaw11 != null
                                    ? Convert.ToDouble(numberRaw11)
                                    : null,
            @default: map.TryGetValue("default", out var numberRaw12) && numberRaw12 != null
                                    ? Convert.ToDouble(numberRaw12)
                                    : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "description", Description },
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
