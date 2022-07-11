
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class AttributeEmail
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("array")]
        public bool? Array { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("default")]
        public string? Default { get; set; }


        public AttributeEmail(
            string key,
            string type,
            string status,
            bool required,
            bool? array,
            string format,
            string? xdefault
        ) {
            Key = key;
            Type = type;
            Status = status;
            Required = required;
            Array = array;
            Format = format;
            Default = xdefault;
        }

        public static AttributeEmail From(Dictionary<string, object> map) => new AttributeEmail(
            key: (string)map["key"],
            type: (string)map["type"],
            status: (string)map["status"],
            required: (bool)map["required"],
            array: (bool?)map["array"],
            format: (string)map["format"],
            xdefault: (string?)map["default"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "type", Type },
            { "status", Status },
            { "required", Required },
            { "array", Array },
            { "format", Format },
            { "default", Default }
        };
    }
}