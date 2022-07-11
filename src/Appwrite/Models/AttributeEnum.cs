
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class AttributeEnum
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

        [JsonProperty("elements")]
        public List<object> Elements { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("default")]
        public string? Default { get; set; }


        public AttributeEnum(
            string key,
            string type,
            string status,
            bool required,
            bool? array,
            List<object> elements,
            string format,
            string? xdefault
        ) {
            Key = key;
            Type = type;
            Status = status;
            Required = required;
            Array = array;
            Elements = elements;
            Format = format;
            Default = xdefault;
        }

        public static AttributeEnum From(Dictionary<string, object> map) => new AttributeEnum(
            key: (string)map["key"],
            type: (string)map["type"],
            status: (string)map["status"],
            required: (bool)map["required"],
            array: (bool?)map["array"],
            elements: ((JArray)map["elements"]).ToObject<List<object>>(),
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
            { "elements", Elements },
            { "format", Format },
            { "default", Default }
        };
    }
}