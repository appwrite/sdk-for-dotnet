
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class ProxyInvalidation
    {
        [JsonPropertyName("domain")]
        public string Domain { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("reference")]
        public string Reference { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        public ProxyInvalidation(
            string domain,
            string type,
            string reference,
            string status
        )
        {
            Domain = domain;
            Type = type;
            Reference = reference;
            Status = status;
        }

        public static ProxyInvalidation From(Dictionary<string, object> map) => new ProxyInvalidation(
            domain: map["domain"].ToString(),
            type: map["type"].ToString(),
            reference: map["reference"].ToString(),
            status: map["status"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "domain", Domain },
            { "type", Type },
            { "reference", Reference },
            { "status", Status }
        };
    }
}
