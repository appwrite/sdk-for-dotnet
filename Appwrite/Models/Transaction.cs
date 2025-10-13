
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Transaction
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        [JsonPropertyName("operations")]
        public long Operations { get; private set; }

        [JsonPropertyName("expiresAt")]
        public string ExpiresAt { get; private set; }

        public Transaction(
            string id,
            string createdAt,
            string updatedAt,
            string status,
            long operations,
            string expiresAt
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Status = status;
            Operations = operations;
            ExpiresAt = expiresAt;
        }

        public static Transaction From(Dictionary<string, object> map) => new Transaction(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            status: map["status"].ToString(),
            operations: Convert.ToInt64(map["operations"]),
            expiresAt: map["expiresAt"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "status", Status },
            { "operations", Operations },
            { "expiresAt", ExpiresAt }
        };
    }
}
