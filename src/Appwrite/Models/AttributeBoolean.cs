
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class AttributeBoolean
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

        [JsonProperty("default")]
        public bool? Default { get; set; }


        public AttributeBoolean(
            string key,
            string type,
            string status,
            bool required,
            bool? array,
            bool? xdefault
        ) {
            Key = key;
            Type = type;
            Status = status;
            Required = required;
            Array = array;
            Default = xdefault;
        }

        public static AttributeBoolean From(Dictionary<string, object> map) => new AttributeBoolean(
            key: (string)map["key"],
            type: (string)map["type"],
            status: (string)map["status"],
            required: (bool)map["required"],
            array: (bool?)map["array"],
            xdefault: (bool?)map["default"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "type", Type },
            { "status", Status },
            { "required", Required },
            { "array", Array },
            { "default", Default }
        };
    }
}