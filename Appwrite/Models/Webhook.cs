
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

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

        [JsonPropertyName("tls")]
        public bool Tls { get; private set; }

        [JsonPropertyName("authUsername")]
        public string AuthUsername { get; private set; }

        [JsonPropertyName("authPassword")]
        public string AuthPassword { get; private set; }

        [JsonPropertyName("secret")]
        public string Secret { get; private set; }

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
            bool tls,
            string authUsername,
            string authPassword,
            string secret,
            bool enabled,
            string logs,
            long attempts
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Url = url;
            Events = events;
            Tls = tls;
            AuthUsername = authUsername;
            AuthPassword = authPassword;
            Secret = secret;
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
            events: map["events"].ConvertToList<string>(),
            tls: (bool)map["tls"],
            authUsername: map["authUsername"].ToString(),
            authPassword: map["authPassword"].ToString(),
            secret: map["secret"].ToString(),
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
            { "tls", Tls },
            { "authUsername", AuthUsername },
            { "authPassword", AuthPassword },
            { "secret", Secret },
            { "enabled", Enabled },
            { "logs", Logs },
            { "attempts", Attempts }
        };
    }
}
