
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class InsightCTA
    {
        [JsonPropertyName("label")]
        public string Label { get; private set; }

        [JsonPropertyName("service")]
        public string Service { get; private set; }

        [JsonPropertyName("method")]
        public string Method { get; private set; }

        [JsonPropertyName("params")]
        public object Params { get; private set; }

        public InsightCTA(
            string label,
            string service,
            string method,
            object xparams
        )
        {
            Label = label;
            Service = service;
            Method = method;
            Params = xparams;
        }

        public static InsightCTA From(Dictionary<string, object> map) => new InsightCTA(
            label: map["label"].ToString(),
            service: map["service"].ToString(),
            method: map["method"].ToString(),
            xparams: map["params"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "label", Label },
            { "service", Service },
            { "method", Method },
            { "params", Params }
        };
    }
}
