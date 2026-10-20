
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AttributePoint
    {
        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("description")]
        public string Description { get; private set; }

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

        [JsonPropertyName("default")]
        public List<double>? Default { get; private set; }

        public AttributePoint(
            string key,
            string description,
            string type,
            Appwrite.Enums.AttributeStatus status,
            string error,
            bool required,
            bool? array,
            string createdAt,
            string updatedAt,
            List<double>? @default
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
            Default = @default;
        }

        public static AttributePoint From(Dictionary<string, object> map) => new AttributePoint(
            key: (map.ContainsKey("key") ? map["key"] : "").ToString(),
            description: (map.ContainsKey("description") ? map["description"] : "").ToString(),
            type: (map.ContainsKey("type") ? map["type"] : "").ToString(),
            status: new Appwrite.Enums.AttributeStatus(map["status"].ToString()!),
            error: (map.ContainsKey("error") ? map["error"] : "").ToString(),
            required: (bool)(map.ContainsKey("required") ? map["required"] : false),
            array: map.TryGetValue("array", out var boolRaw7) && boolRaw7 != null
                                        ? (bool?)boolRaw7
                                        : null,
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            @default: map.TryGetValue("default", out var arrayRaw10) && arrayRaw10 != null
                                ? arrayRaw10.ConvertToList<double>()
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
            { "default", Default }
        };
    }
}
