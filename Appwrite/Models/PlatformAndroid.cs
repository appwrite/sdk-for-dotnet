
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PlatformAndroid
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
        public Appwrite.Enums.PlatformType Type { get; private set; }

        [JsonPropertyName("applicationId")]
        public string ApplicationId { get; private set; }

        [JsonPropertyName("fingerprints")]
        public List<string> Fingerprints { get; private set; }

        public PlatformAndroid(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            Appwrite.Enums.PlatformType type,
            string applicationId,
            List<string> fingerprints
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Type = type;
            ApplicationId = applicationId;
            Fingerprints = fingerprints;
        }

        public static PlatformAndroid From(Dictionary<string, object> map) => new PlatformAndroid(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            type: new Appwrite.Enums.PlatformType(map["type"].ToString()!),
            applicationId: (map.ContainsKey("applicationId") ? map["applicationId"] : "").ToString(),
            fingerprints: (map.ContainsKey("fingerprints") ? map["fingerprints"] : new List<object>()).ConvertToList<string>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "type", Type.Value },
            { "applicationId", ApplicationId },
            { "fingerprints", Fingerprints }
        };
    }
}
