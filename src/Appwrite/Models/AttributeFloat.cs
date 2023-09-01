
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class AttributeFloat
    {
        [JsonProperty("key")]
        public string Key { get; private set; }

        [JsonProperty("type")]
        public string Type { get; private set; }

        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("error")]
        public string Error { get; private set; }

        [JsonProperty("required")]
        public bool Required { get; private set; }

        [JsonProperty("array")]
        public bool? Array { get; private set; }

        [JsonProperty("min")]
        public double? Min { get; private set; }

        [JsonProperty("max")]
        public double? Max { get; private set; }

        [JsonProperty("default")]
        public double? Default { get; private set; }

        public AttributeFloat(
            string key,
            string type,
            string status,
            string error,
            bool required,
            bool? array,
            double? min,
            double? max,
            double? xdefault
        ) {
            Key = key;
            Type = type;
            Status = status;
            Error = error;
            Required = required;
            Array = array;
            Min = min;
            Max = max;
            Default = xdefault;
        }

        public static AttributeFloat From(Dictionary<string, object> map) => new AttributeFloat(
            key: map["key"].ToString(),
            type: map["type"].ToString(),
            status: map["status"].ToString(),
            error: map["error"].ToString(),
            required: (bool)map["required"],
            array: (bool?)map["array"],
            min: map["min"] == null ? null : Convert.ToDouble(map["min"]),
            max: map["max"] == null ? null : Convert.ToDouble(map["max"]),
            xdefault: map["default"] == null ? null : Convert.ToDouble(map["default"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "type", Type },
            { "status", Status },
            { "error", Error },
            { "required", Required },
            { "array", Array },
            { "min", Min },
            { "max", Max },
            { "default", Default }
        };
    }
}