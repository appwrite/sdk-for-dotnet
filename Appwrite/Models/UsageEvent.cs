
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class UsageEvent
    {
        [JsonPropertyName("metric")]
        public string Metric { get; private set; }

        [JsonPropertyName("value")]
        public long Value { get; private set; }

        [JsonPropertyName("time")]
        public string Time { get; private set; }

        [JsonPropertyName("path")]
        public string Path { get; private set; }

        [JsonPropertyName("method")]
        public string Method { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        [JsonPropertyName("resourceType")]
        public string ResourceType { get; private set; }

        [JsonPropertyName("resourceId")]
        public string ResourceId { get; private set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; private set; }

        [JsonPropertyName("userAgent")]
        public string UserAgent { get; private set; }

        public UsageEvent(
            string metric,
            long xvalue,
            string time,
            string xpath,
            string method,
            string status,
            string resourceType,
            string resourceId,
            string countryCode,
            string userAgent
        )
        {
            Metric = metric;
            Value = xvalue;
            Time = time;
            Path = xpath;
            Method = method;
            Status = status;
            ResourceType = resourceType;
            ResourceId = resourceId;
            CountryCode = countryCode;
            UserAgent = userAgent;
        }

        public static UsageEvent From(Dictionary<string, object> map) => new UsageEvent(
            metric: map["metric"].ToString(),
            xvalue: Convert.ToInt64(map["value"]),
            time: map["time"].ToString(),
            xpath: map["path"].ToString(),
            method: map["method"].ToString(),
            status: map["status"].ToString(),
            resourceType: map["resourceType"].ToString(),
            resourceId: map["resourceId"].ToString(),
            countryCode: map["countryCode"].ToString(),
            userAgent: map["userAgent"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "metric", Metric },
            { "value", Value },
            { "time", Time },
            { "path", Path },
            { "method", Method },
            { "status", Status },
            { "resourceType", ResourceType },
            { "resourceId", ResourceId },
            { "countryCode", CountryCode },
            { "userAgent", UserAgent }
        };
    }
}
