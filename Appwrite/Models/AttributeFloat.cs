
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AttributeFloat
    {
        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("status")]
        public Appwrite.Enums.AttributeStatus Status { get; private set; }

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

        public AttributeFloat(
            string key,
            string type,
            Appwrite.Enums.AttributeStatus status,
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

        public static AttributeFloat From(Dictionary<string, object> map) => new AttributeFloat(
            key: map["key"].ToString(),
            type: map["type"].ToString(),
            status: new Appwrite.Enums.AttributeStatus(map["status"].ToString()!),
            error: map["error"].ToString(),
            required: (bool)map["required"],
            array: map.TryGetValue("array", out var boolRaw6) && boolRaw6 != null
                                        ? (bool?)boolRaw6
                                        : null,
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            min: map.TryGetValue("min", out var numberRaw9) && numberRaw9 != null
                                    ? Convert.ToDouble(numberRaw9)
                                    : null,
            max: map.TryGetValue("max", out var numberRaw10) && numberRaw10 != null
                                    ? Convert.ToDouble(numberRaw10)
                                    : null,
            @default: map.TryGetValue("default", out var numberRaw11) && numberRaw11 != null
                                    ? Convert.ToDouble(numberRaw11)
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
            { "min", Min },
            { "max", Max },
            { "default", Default }
        };
    }
}
