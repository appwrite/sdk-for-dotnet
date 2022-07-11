
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class AttributeString
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

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("default")]
        public string? Default { get; set; }


        public AttributeString(
            string key,
            string type,
            string status,
            bool required,
            bool? array,
            long size,
            string? xdefault
        ) {
            Key = key;
            Type = type;
            Status = status;
            Required = required;
            Array = array;
            Size = size;
            Default = xdefault;
        }

        public static AttributeString From(Dictionary<string, object> map) => new AttributeString(
            key: (string)map["key"],
            type: (string)map["type"],
            status: (string)map["status"],
            required: (bool)map["required"],
            array: (bool?)map["array"],
            size: Convert.ToInt64(map["size"]),
            xdefault: (string?)map["default"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "type", Type },
            { "status", Status },
            { "required", Required },
            { "array", Array },
            { "size", Size },
            { "default", Default }
        };
    }
}