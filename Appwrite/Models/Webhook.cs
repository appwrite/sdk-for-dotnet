
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class Webhook
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("url")]
        public string Url { get; private set; }

        [JsonPropertyName("events")]
        public List<string> Events { get; private set; }

        [JsonPropertyName("security")]
        public bool Security { get; private set; }

        [JsonPropertyName("httpUser")]
        public string HttpUser { get; private set; }

        [JsonPropertyName("httpPass")]
        public string HttpPass { get; private set; }

        [JsonPropertyName("signatureKey")]
        public string SignatureKey { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("logs")]
        public string Logs { get; private set; }

        [JsonPropertyName("attempts")]
        public long Attempts { get; private set; }

        public Webhook(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            string url,
            List<string> events,
            bool security,
            string httpUser,
            string httpPass,
            string signatureKey,
            bool enabled,
            string logs,
            long attempts
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Url = url;
            Events = events;
            Security = security;
            HttpUser = httpUser;
            HttpPass = httpPass;
            SignatureKey = signatureKey;
            Enabled = enabled;
            Logs = logs;
            Attempts = attempts;
        }

        public static Webhook From(Dictionary<string, object> map) => new Webhook(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            name: map["name"].ToString(),
            url: map["url"].ToString(),
            events: map["events"] is JsonElement jsonArrayProp6 ? jsonArrayProp6.Deserialize<List<string>>()! : (List<string>)map["events"],
            security: (bool)map["security"],
            httpUser: map["httpUser"].ToString(),
            httpPass: map["httpPass"].ToString(),
            signatureKey: map["signatureKey"].ToString(),
            enabled: (bool)map["enabled"],
            logs: map["logs"].ToString(),
            attempts: Convert.ToInt64(map["attempts"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "url", Url },
            { "events", Events },
            { "security", Security },
            { "httpUser", HttpUser },
            { "httpPass", HttpPass },
            { "signatureKey", SignatureKey },
            { "enabled", Enabled },
            { "logs", Logs },
            { "attempts", Attempts }
        };
    }
}
