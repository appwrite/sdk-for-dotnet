
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Device
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("expire")]
        public string Expire { get; private set; }

        [JsonPropertyName("activeSessionId")]
        public string ActiveSessionId { get; private set; }

        [JsonPropertyName("sessions")]
        public List<Session> Sessions { get; private set; }

        [JsonPropertyName("secret")]
        public string Secret { get; private set; }

        public Device(
            string id,
            string createdAt,
            string updatedAt,
            string expire,
            string activeSessionId,
            List<Session> sessions,
            string secret
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Expire = expire;
            ActiveSessionId = activeSessionId;
            Sessions = sessions;
            Secret = secret;
        }

        public static Device From(Dictionary<string, object> map) => new Device(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            expire: (map.ContainsKey("expire") ? map["expire"] : "").ToString(),
            activeSessionId: (map.ContainsKey("activeSessionId") ? map["activeSessionId"] : "").ToString(),
            sessions: (map.ContainsKey("sessions") ? map["sessions"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Session.From(map: it)).ToList(),
            secret: (map.ContainsKey("secret") ? map["secret"] : "").ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "expire", Expire },
            { "activeSessionId", ActiveSessionId },
            { "sessions", Sessions?.Select(it => it.ToMap()).ToList() },
            { "secret", Secret }
        };
    }
}
