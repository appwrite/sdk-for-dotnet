
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class Platform
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("store")]
        public string Store { get; private set; }

        [JsonPropertyName("hostname")]
        public string Hostname { get; private set; }

        [JsonPropertyName("httpUser")]
        public string HttpUser { get; private set; }

        [JsonPropertyName("httpPass")]
        public string HttpPass { get; private set; }

        public Platform(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            string type,
            string key,
            string store,
            string hostname,
            string httpUser,
            string httpPass
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Type = type;
            Key = key;
            Store = store;
            Hostname = hostname;
            HttpUser = httpUser;
            HttpPass = httpPass;
        }

        public static Platform From(Dictionary<string, object> map) => new Platform(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            name: map["name"].ToString(),
            type: map["type"].ToString(),
            key: map["key"].ToString(),
            store: map["store"].ToString(),
            hostname: map["hostname"].ToString(),
            httpUser: map["httpUser"].ToString(),
            httpPass: map["httpPass"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "type", Type },
            { "key", Key },
            { "store", Store },
            { "hostname", Hostname },
            { "httpUser", HttpUser },
            { "httpPass", HttpPass }
        };
    }
}
