
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class ProviderRepositoryFramework
    {
        [JsonPropertyName("id")]
        public string Id { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("organization")]
        public string Organization { get; private set; }

        [JsonPropertyName("provider")]
        public string Provider { get; private set; }

        [JsonPropertyName("private")]
        public bool Private { get; private set; }

        [JsonPropertyName("pushedAt")]
        public string PushedAt { get; private set; }

        [JsonPropertyName("framework")]
        public string Framework { get; private set; }

        public ProviderRepositoryFramework(
            string id,
            string name,
            string organization,
            string provider,
            bool xprivate,
            string pushedAt,
            string framework
        ) {
            Id = id;
            Name = name;
            Organization = organization;
            Provider = provider;
            Private = xprivate;
            PushedAt = pushedAt;
            Framework = framework;
        }

        public static ProviderRepositoryFramework From(Dictionary<string, object> map) => new ProviderRepositoryFramework(
            id: map["id"].ToString(),
            name: map["name"].ToString(),
            organization: map["organization"].ToString(),
            provider: map["provider"].ToString(),
            xprivate: (bool)map["private"],
            pushedAt: map["pushedAt"].ToString(),
            framework: map["framework"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "id", Id },
            { "name", Name },
            { "organization", Organization },
            { "provider", Provider },
            { "private", Private },
            { "pushedAt", PushedAt },
            { "framework", Framework }
        };
    }
}
