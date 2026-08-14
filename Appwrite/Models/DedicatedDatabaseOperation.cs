
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DedicatedDatabaseOperation
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("databaseId")]
        public string DatabaseId { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        [JsonPropertyName("attempts")]
        public long Attempts { get; private set; }

        [JsonPropertyName("requestedAt")]
        public string? RequestedAt { get; private set; }

        [JsonPropertyName("startedAt")]
        public string? StartedAt { get; private set; }

        [JsonPropertyName("completedAt")]
        public string? CompletedAt { get; private set; }

        [JsonPropertyName("errorCode")]
        public string ErrorCode { get; private set; }

        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; private set; }

        public DedicatedDatabaseOperation(
            string id,
            string createdAt,
            string databaseId,
            string type,
            string status,
            long attempts,
            string? requestedAt,
            string? startedAt,
            string? completedAt,
            string errorCode,
            string errorMessage
        )
        {
            Id = id;
            CreatedAt = createdAt;
            DatabaseId = databaseId;
            Type = type;
            Status = status;
            Attempts = attempts;
            RequestedAt = requestedAt;
            StartedAt = startedAt;
            CompletedAt = completedAt;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }

        public static DedicatedDatabaseOperation From(Dictionary<string, object> map) => new DedicatedDatabaseOperation(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            databaseId: map["databaseId"].ToString(),
            type: map["type"].ToString(),
            status: map["status"].ToString(),
            attempts: Convert.ToInt64(map["attempts"]),
            requestedAt: map.TryGetValue("requestedAt", out var requestedAt) ? requestedAt?.ToString() : null,
            startedAt: map.TryGetValue("startedAt", out var startedAt) ? startedAt?.ToString() : null,
            completedAt: map.TryGetValue("completedAt", out var completedAt) ? completedAt?.ToString() : null,
            errorCode: map["errorCode"].ToString(),
            errorMessage: map["errorMessage"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "databaseId", DatabaseId },
            { "type", Type },
            { "status", Status },
            { "attempts", Attempts },
            { "requestedAt", RequestedAt },
            { "startedAt", StartedAt },
            { "completedAt", CompletedAt },
            { "errorCode", ErrorCode },
            { "errorMessage", ErrorMessage }
        };
    }
}
