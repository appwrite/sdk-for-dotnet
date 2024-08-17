
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class TemplateVariable
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("value")]
        public string Value { get; private set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; private set; }

        [JsonProperty("required")]
        public bool Required { get; private set; }

        [JsonProperty("type")]
        public string Type { get; private set; }

        public TemplateVariable(
            string name,
            string description,
            string xvalue,
            string placeholder,
            bool required,
            string type
        ) {
            Name = name;
            Description = description;
            Value = xvalue;
            Placeholder = placeholder;
            Required = required;
            Type = type;
        }

        public static TemplateVariable From(Dictionary<string, object> map) => new TemplateVariable(
            name: map["name"].ToString(),
            description: map["description"].ToString(),
            xvalue: map["value"].ToString(),
            placeholder: map["placeholder"].ToString(),
            required: (bool)map["required"],
            type: map["type"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "name", Name },
            { "description", Description },
            { "value", Value },
            { "placeholder", Placeholder },
            { "required", Required },
            { "type", Type }
        };
    }
}