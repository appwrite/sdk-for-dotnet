
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AttributeEnum
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

        [JsonPropertyName("elements")]
        public List<string> Elements { get; private set; }

        [JsonPropertyName("format")]
        public string Format { get; private set; }

        [JsonPropertyName("default")]
        public string? Default { get; private set; }

        public AttributeEnum(
            string key,
            string type,
            AttributeStatus status,
            string error,
            bool required,
            bool? array,
            string createdAt,
            string updatedAt,
            List<string> elements,
            string format,
            string? xdefault
        ) {
            Key = key;
            Type = type;
            Status = status;
            Error = error;
            Required = required;
            Array = array;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Elements = elements;
            Format = format;
            Default = xdefault;
        }

        public static AttributeEnum From(Dictionary<string, object> map) => new AttributeEnum(
            key: map["key"].ToString(),
            type: map["type"].ToString(),
            status: new AttributeStatus(map["status"].ToString()!),
            error: map["error"].ToString(),
            required: (bool)map["required"],
            array: (bool?)map["array"],
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            elements: map["elements"].ConvertToList<string>(),
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
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "elements", Elements },
            { "format", Format },
            { "default", Default }
        };
    }
}
