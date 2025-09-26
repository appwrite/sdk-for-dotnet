using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class Message
    {
        [JsonPropertyName("$id")]
        public string id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string createdAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string updatedAt { get; private set; }

        [JsonPropertyName("providerType")]
        public string ProviderType { get; private set; }

        [JsonPropertyName("topics")]
        public List&lt;string&gt; Topics { get; private set; }

        [JsonPropertyName("users")]
        public List&lt;string&gt; Users { get; private set; }

        [JsonPropertyName("targets")]
        public List&lt;string&gt; Targets { get; private set; }

        [JsonPropertyName("scheduledAt")]
        public string? ScheduledAt { get; private set; }

        [JsonPropertyName("deliveredAt")]
        public string? DeliveredAt { get; private set; }

        [JsonPropertyName("deliveryErrors")]
        public List&lt;string&gt;? DeliveryErrors { get; private set; }

        [JsonPropertyName("deliveredTotal")]
        public long DeliveredTotal { get; private set; }

        [JsonPropertyName("data")]
        public object Data { get; private set; }

        [JsonPropertyName("status")]
        public MessageStatus Status { get; private set; }

        public Message(
            string id,
            string createdAt,
            string updatedAt,
            string providerType,
            List&lt;string&gt; topics,
            List&lt;string&gt; users,
            List&lt;string&gt; targets,
            string? scheduledAt,
            string? deliveredAt,
            List&lt;string&gt;? deliveryErrors,
            long deliveredTotal,
            object data,
            MessageStatus status
        ) {
            id = id;
            createdAt = createdAt;
            updatedAt = updatedAt;
            ProviderType = providerType;
            Topics = topics;
            Users = users;
            Targets = targets;
            ScheduledAt = scheduledAt;
            DeliveredAt = deliveredAt;
            DeliveryErrors = deliveryErrors;
            DeliveredTotal = deliveredTotal;
            Data = data;
            Status = status;
        }

        public static Message From(Dictionary<string, object> map) => new Message(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            providerType: map["providerType"].ToString(),
            topics: map["topics"] is JsonElement jsonArrayProp5 ? jsonArrayProp5.Deserialize<List<string>>()! : (List<string>)map["topics"],
            users: map["users"] is JsonElement jsonArrayProp6 ? jsonArrayProp6.Deserialize<List<string>>()! : (List<string>)map["users"],
            targets: map["targets"] is JsonElement jsonArrayProp7 ? jsonArrayProp7.Deserialize<List<string>>()! : (List<string>)map["targets"],
            scheduledAt: map.TryGetValue("scheduledAt", out var scheduledAt) ? scheduledAt?.ToString() : null,
            deliveredAt: map.TryGetValue("deliveredAt", out var deliveredAt) ? deliveredAt?.ToString() : null,
            deliveryErrors: map["deliveryErrors"] is JsonElement jsonArrayProp10 ? jsonArrayProp10.Deserialize<List<string>>()! : (List<string>)map["deliveryErrors"],
            deliveredTotal: Convert.ToInt64(map["deliveredTotal"]),
            data: map["data"].ToString(),
            status: new MessageStatus(map["status"].ToString()!)
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", id },
            { "$createdAt", createdAt },
            { "$updatedAt", updatedAt },
            { "providerType", ProviderType },
            { "topics", Topics },
            { "users", Users },
            { "targets", Targets },
            { "scheduledAt", ScheduledAt },
            { "deliveredAt", DeliveredAt },
            { "deliveryErrors", DeliveryErrors },
            { "deliveredTotal", DeliveredTotal },
            { "data", Data },
            { "status", Status.Value }
        };
    }
}
