
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class TemplateVariable
    {
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("description")]
        public string Description { get; private set; }

        [JsonPropertyName("value")]
        public string Value { get; private set; }

        [JsonPropertyName("secret")]
        public bool Secret { get; private set; }

        [JsonPropertyName("placeholder")]
        public string Placeholder { get; private set; }

        [JsonPropertyName("required")]
        public bool Required { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        public TemplateVariable(
            string name,
            string description,
            string xvalue,
            bool secret,
            string placeholder,
            bool required,
            string type
        ) {
            Name = name;
            Description = description;
            Value = xvalue;
            Secret = secret;
            Placeholder = placeholder;
            Required = required;
            Type = type;
        }

        public static TemplateVariable From(Dictionary<string, object> map) => new TemplateVariable(
            name: map["name"].ToString(),
            description: map["description"].ToString(),
            xvalue: map["value"].ToString(),
            secret: (bool)map["secret"],
            placeholder: map["placeholder"].ToString(),
            required: (bool)map["required"],
            type: map["type"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "name", Name },
            { "description", Description },
            { "value", Value },
            { "secret", Secret },
            { "placeholder", Placeholder },
            { "required", Required },
            { "type", Type }
        };
    }
}
