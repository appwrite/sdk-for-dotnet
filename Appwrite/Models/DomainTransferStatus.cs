
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DomainTransferStatus
    {
        [JsonPropertyName("status")]
        public Appwrite.Enums.DomainTransferStatusEnum Status { get; private set; }

        [JsonPropertyName("reason")]
        public string Reason { get; private set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; private set; }

        public DomainTransferStatus(
            Appwrite.Enums.DomainTransferStatusEnum status,
            string reason,
            string timestamp
        )
        {
            Status = status;
            Reason = reason;
            Timestamp = timestamp;
        }

        public static DomainTransferStatus From(Dictionary<string, object> map) => new DomainTransferStatus(
            status: new Appwrite.Enums.DomainTransferStatusEnum(map["status"].ToString()!),
            reason: map.TryGetValue("reason", out var reason) ? reason?.ToString() ?? "" : "",
            timestamp: map["timestamp"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "status", Status.Value },
            { "reason", Reason },
            { "timestamp", Timestamp }
        };
    }
}
